using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface_Data;
using System.ServiceModel;

namespace DXApp
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
            ChannelFactory<IBussinessLogic> chanel =
                new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        IBussinessLogic proxy;

        private void AddBook_Load(object sender, EventArgs e)
        {
            ListAuthors.DataSource = proxy.GetAllBookAuthor();
            ListAuthors.DisplayMember = "Name";
            ListAuthors.ValueMember = "Id";
            ListCategory.DataSource = proxy.GetBookAllCategory();
            ListCategory.DisplayMember = "name";
            ListCategory.ValueMember = "Id";
            ListCategory.SelectionMode = SelectionMode.MultiExtended;
            ListAuthors.SelectionMode = SelectionMode.MultiExtended;
            publishYearPicker.Format = DateTimePickerFormat.Custom;
            publishYearPicker.CustomFormat = "yyyy";
            publishYearPicker.ShowUpDown = true;
            cboPublisher.DataSource = proxy.getAllPublisher();
            cboPublisher.DisplayMember = "name";
            cboPublisher.ValueMember = "id";
            ListAuthors.ClearSelected();
            
        }



        // validate if empty or can not part return true . if valid return false;
        bool validate()
        {
            try
            {
                int.Parse(txtPrice.Text);
                int.Parse(txtQuantity.Text);
                bool isEmpty = String.IsNullOrEmpty(txtISBN.Text)
            || String.IsNullOrEmpty(txtPrice.Text)
            || String.IsNullOrEmpty(txtQuantity.Text)
            || String.IsNullOrEmpty(txtName.Text)
            || String.IsNullOrEmpty(txtDesc.Text)
            || String.IsNullOrEmpty(txtStatus.Text);

                bool isTooLong = txtISBN.Text.Length > 250
                                    || txtDesc.Text.Length > 4000
                                    || txtName.Text.Length > 1000
                                    || txtStatus.Text.Length > 10;

                return isEmpty || isTooLong;
            }
            catch
            {
                return true;
            }
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (validate())
            {
                MessageBox.Show("Your input is not valid please check again (Not leave field empty or too long)");
                return;

            }


            BookData book = new BookData();
            book.Author = new List<AuthorData>();
            book.Category = new List<CategoryData>();
            book.Name = txtName.Text;
            book.ISBN = txtISBN.Text;
            book.Description = txtDesc.Text;
            book.Price = int.Parse(txtPrice.Text);
            book.Quantity = int.Parse(txtQuantity.Text);
            book.Publisher_ID = (int)cboPublisher.SelectedValue;
            book.Status = txtStatus.Text;
            book.Year = publishYearPicker.Value.ToString("yyyy");
            foreach (CategoryData item in ListCategory.SelectedItems)
            {
                book.Category.Add(item);
            }
            foreach (AuthorData item in ListAuthors.SelectedItems)
            {
                book.Author.Add(item);
            }
            
          bool result=proxy.IAddBook(book) ;

            if (result)
            {
                MessageBox.Show("Add Book Successful!");
            }
            else {
                MessageBox.Show("Please Check book ISBN , This ISBN is existed!");

            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtISBN.Text = "";
            txtName.Text = "";
            txtStatus.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDesc.Text = "";
            ListAuthors.ClearSelected() ;
            ListCategory.ClearSelected();
            cboPublisher.SelectedIndex = 0;
        }
    }
}
