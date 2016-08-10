using Interface_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApp
{
    public partial class BookForm : Form
    {
        IBussinessLogic proxy;
        DataTable table = new DataTable();
        public BookForm()
        {
            InitializeComponent();
            dgvBook.MultiSelect = false;
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        public void getDataSource()
        {
            try
            {
                table = proxy.GetAllBook();
                bindingBook.DataSource = table;
                if (bindingBook != null)
                {
                    txtName.DataBindings.Clear();
                    txtStatus.DataBindings.Clear();
                    txtISBN.DataBindings.Clear();
                    txtDesc.DataBindings.Clear();
                    txtPrice.DataBindings.Clear();
                    txtQuantity.DataBindings.Clear();
                    txtThumbnail.DataBindings.Clear();
                    txtYear.DataBindings.Clear();
                    
                    //txtName.DataBindings.Add("Text", bindingBook, "name");
                    //txtStatus.DataBindings.Add("Text", bindingBook, "status");
                    //txtDesc.DataBindings.Add("Text", bindingBook, "description");
                    //txtYear.DataBindings.Add("Text", bindingBook, "year");
                    //txtPrice.DataBindings.Add("Text", bindingBook, "price");
                    //txtQuantity.DataBindings.Add("Text", bindingBook, "quantity");
                    //txtThumbnail.DataBindings.Add("Text", bindingBook, "thumbnail");
                    //txtISBN.DataBindings.Add("Text", bindingBook, "ISBN");
                    //cboPublisher.DataBindings.Add("Text", bindingBook, "publisher_ID");
                    dgvBook.DataSource = bindingBook;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dynamic publisher = cboPublisher.SelectedItem;
            BookData book = new BookData()
            {
                ISBN = txtISBN.Text,
                Name = txtName.Text,
                Description = txtDesc.Text.ToString(),
                Thumnail = txtThumbnail.Text,
                Quantity = int.Parse(txtQuantity.Text.ToString()),
                Price = float.Parse(txtPrice.Text.ToString()),
                //Publisher_ID = int.Parse(publisher.ID.ToString()),
                Publisher_ID = publisher.ID,
                Status = txtStatus.Text,
                Year = txtYear.Text
            };
            proxy.IAddBook(book);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            List<PublisherData> Publishers = proxy.getAllPublisher();
            cboPublisher.DataSource = Publishers;
            cboPublisher.DisplayMember = "name";
            cboPublisher.ValueMember = "ID";
            getDataSource();
        }
    }
}
