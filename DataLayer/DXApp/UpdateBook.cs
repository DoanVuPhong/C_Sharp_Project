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
    public partial class UpdateBook : Form
    {

        BookData book = new BookData();
        IBussinessLogic proxy;
        BindingSource bidding = new BindingSource();


        public UpdateBook(int ID)
        {
            InitializeComponent();
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
            book = proxy.GetBookDataByID(ID);
            ListAuthors.DataSource = proxy.GetAllBookAuthor();
            ListAuthors.DisplayMember = "name";
            ListAuthors.ValueMember = "id";
            ListCategory.DataSource = proxy.GetBookAllCategory();
            ListCategory.DisplayMember = "name";
            ListCategory.ValueMember = "id";
            cboPublisher.DataSource = proxy.getAllPublisher();
            cboPublisher.DisplayMember = "name";
            cboPublisher.ValueMember = "id";
            ListAuthors.ClearSelected();
            ListCategory.ClearSelected();
            ListAuthors.SelectionMode = SelectionMode.MultiExtended;
            ListCategory.SelectionMode = SelectionMode.MultiExtended;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            txtISBN.Text = book.ISBN;
            txtName.Text = book.Name;
            txtPrice.Text = book.Price.ToString();
            txtQuantity.Text = book.Quantity.ToString();
            txtDesc.Text = book.Description;
            txtPrice.Text = book.Price.ToString();
            txtStatus.Text = book.Status;
          

            for (int i = 0; i < ListAuthors.Items.Count; i++)
            {
                int count = 0;
                for (int t = count; t < book.Author.Count; t++)
                {
                    if (book.Author[t].ID == ((AuthorData)ListAuthors.Items[i]).ID)
                    {
                        ListAuthors.SetSelected(i, true);
                        count = t;
                        break;
                    }
                }
            }

            for (int i = 0; i < ListCategory.Items.Count; i++)
            {
                for (int t = 0; t < book.Category.Count; t++)
                {
                    if (((CategoryData)ListCategory.Items[i]).ID == book.Category[t].ID)
                    {
                        ListCategory.SetSelected(i, true);
                        break;
                    }
                }
            }
            for (int i = 0; i <cboPublisher.Items.Count; i++)
            {
                if (book.Publisher_ID == ((PublisherData)cboPublisher.Items[i]).ID) {
                    cboPublisher.SelectedIndex = i;
                }
            }



        }



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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                MessageBox.Show("Your input is not valid please check again (Not leave field empty or too long)");
                return;
            }
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
            if (book.Price < 0 || book.Quantity < 0)
            {
                MessageBox.Show("quantity and price must not negative");
                return;
            }
            foreach (CategoryData item in ListCategory.SelectedItems)
            {
                book.Category.Add(item);
            }
            foreach (AuthorData item in ListAuthors.SelectedItems)
            {
                book.Author.Add(item);
            }

            bool result = proxy.IUpdateBook(book);
            if (result)
            {
                MessageBox.Show("Update Book Successful!");
            }
            else {
                MessageBox.Show("Please Check book ISBN , This ISBN is existed!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Text ="";
            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtStatus.Text = "";
            ListAuthors.ClearSelected();
            ListCategory.ClearSelected();
            cboPublisher.SelectedIndex = 0;
        }

       
    }
}
