using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Desktop
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();
        private string imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "book_cover.png");

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
            LoadSampleData();
        }

        private void InitializeForm()
        {
            // Configure form
            this.Text = "Sistema de Biblioteca";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize controls
            InitializeControls();
        }

        private void InitializeControls()
        {
            // PictureBox for book cover
            PictureBox pictureBox = new PictureBox
            {
                Name = "picBookCover",
                Size = new Size(200, 250),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Load default book cover
            if (File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }

            // Labels
            Label lblTitle = new Label { Text = "Título:", Location = new Point(240, 20), AutoSize = true };
            Label lblAuthor = new Label { Text = "Autor:", Location = new Point(240, 60), AutoSize = true };
            Label lblGenre = new Label { Text = "Gênero:", Location = new Point(240, 100), AutoSize = true };
            Label lblPublishDate = new Label { Text = "Data de Publicação:", Location = new Point(240, 140), AutoSize = true };

            // TextBox for title
            TextBox txtTitle = new TextBox { Location = new Point(340, 20), Width = 200 };

            // ComboBox for author
            ComboBox cmbAuthor = new ComboBox
            {
                Location = new Point(340, 60),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbAuthor.Items.AddRange(new string[] { "Autor 1", "Autor 2", "Autor 3" });
            if (cmbAuthor.Items.Count > 0) cmbAuthor.SelectedIndex = 0;

            // ComboBox for genre
            ComboBox cmbGenre = new ComboBox
            {
                Location = new Point(340, 100),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbGenre.Items.AddRange(new string[] { "Ficção", "Não-Ficção", "Técnico", "Biografia" });
            if (cmbGenre.Items.Count > 0) cmbGenre.SelectedIndex = 0;

            // DateTimePicker for publish date
            DateTimePicker dtpPublishDate = new DateTimePicker
            {
                Location = new Point(340, 140),
                Width = 200,
                Format = DateTimePickerFormat.Short
            };

            // Buttons
            Button btnAdd = new Button { Text = "Adicionar", Location = new Point(240, 190), Width = 100 };
            Button btnUpdate = new Button { Text = "Atualizar", Location = new Point(350, 190), Width = 100 };
            Button btnDelete = new Button { Text = "Excluir", Location = new Point(460, 190), Width = 80 };

            // DataGridView for book list
            DataGridView dgvBooks = new DataGridView
            {
                Location = new Point(20, 280),
                Size = new Size(840, 250),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Add columns to DataGridView
            dgvBooks.Columns.Add("Title", "Título");
            dgvBooks.Columns.Add("Author", "Autor");
            dgvBooks.Columns.Add("Genre", "Gênero");
            dgvBooks.Columns.Add("PublishDate", "Data de Publicação");

            // Add controls to form
            this.Controls.Add(pictureBox);
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);
            this.Controls.Add(lblAuthor);
            this.Controls.Add(cmbAuthor);
            this.Controls.Add(lblGenre);
            this.Controls.Add(cmbGenre);
            this.Controls.Add(lblPublishDate);
            this.Controls.Add(dtpPublishDate);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvBooks);

            // Event handlers
            btnAdd.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Por favor, insira um título para o livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var book = new Book
                {
                    Title = txtTitle.Text,
                    Author = cmbAuthor.SelectedItem?.ToString(),
                    Genre = cmbGenre.SelectedItem?.ToString(),
                    PublishDate = dtpPublishDate.Value
                };

                books.Add(book);
                UpdateBookList(dgvBooks);
                ClearForm(txtTitle, cmbAuthor, cmbGenre, dtpPublishDate);
            };

            btnUpdate.Click += (s, e) =>
            {
                if (dgvBooks.SelectedRows.Count == 0) return;

                var selectedIndex = dgvBooks.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < books.Count)
                {
                    books[selectedIndex].Title = txtTitle.Text;
                    books[selectedIndex].Author = cmbAuthor.SelectedItem?.ToString();
                    books[selectedIndex].Genre = cmbGenre.SelectedItem?.ToString();
                    books[selectedIndex].PublishDate = dtpPublishDate.Value;
                    UpdateBookList(dgvBooks);
                }
            };

            btnDelete.Click += (s, e) =>
            {
                if (dgvBooks.SelectedRows.Count == 0) return;

                var selectedIndex = dgvBooks.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < books.Count)
                {
                    books.RemoveAt(selectedIndex);
                    UpdateBookList(dgvBooks);
                    ClearForm(txtTitle, cmbAuthor, cmbGenre, dtpPublishDate);
                }
            };

            dgvBooks.SelectionChanged += (s, e) =>
            {
                if (dgvBooks.SelectedRows.Count > 0 && dgvBooks.SelectedRows[0].Index < books.Count)
                {
                    var book = books[dgvBooks.SelectedRows[0].Index];
                    txtTitle.Text = book.Title;
                    cmbAuthor.SelectedItem = book.Author;
                    cmbGenre.SelectedItem = book.Genre;
                    dtpPublishDate.Value = book.PublishDate;
                }
            };
        }

        private void UpdateBookList(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var book in books)
            {
                dgv.Rows.Add(book.Title, book.Author, book.Genre, book.PublishDate.ToShortDateString());
            }
        }

        private void ClearForm(TextBox txtTitle, ComboBox cmbAuthor, ComboBox cmbGenre, DateTimePicker dtpPublishDate)
        {
            txtTitle.Clear();
            if (cmbAuthor.Items.Count > 0) cmbAuthor.SelectedIndex = 0;
            if (cmbGenre.Items.Count > 0) cmbGenre.SelectedIndex = 0;
            dtpPublishDate.Value = DateTime.Today;
        }

        private void LoadSampleData()
        {
            // Add some sample data
            books.Add(new Book
            {
                Title = "Dom Casmurro",
                Author = "Machado de Assis",
                Genre = "Ficção",
                PublishDate = new DateTime(1899, 1, 1)
            });

            books.Add(new Book
            {
                Title = "O Cortiço",
                Author = "Aluísio Azevedo",
                Genre = "Ficção",
                PublishDate = new DateTime(1890, 1, 1)
            });

            // Update the DataGridView
            if (this.Controls.OfType<DataGridView>().FirstOrDefault() is DataGridView dgv)
            {
                UpdateBookList(dgv);
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
