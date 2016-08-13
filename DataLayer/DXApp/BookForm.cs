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
        //BookData current = new BookData();
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
            getDataSource();
        }

        public void getDataSource()
        {
            try
            {
                table = proxy.GetAllBook();
                dgvBook.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void setCurrent()
        {
            if (dgvBook.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBook.SelectedRows[0];
                txtID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook AddBookForm = new AddBook();
            AddBookForm.ShowDialog();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = proxy.GetAllCategory();
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "name";
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setCurrent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookData b = new BookData()
            {
                ID = int.Parse(txtID.Text)
            };
            proxy.IRemoveBook(b);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getDataSource();
        }

        private void btnSearchByPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                string publisher = txtPublisher.Text;
                table = proxy.SearchBookByPublisher(publisher);
                if(table.Rows.Count == 0 || table == null)
                {
                    MessageBox.Show("No Solution");
                }
                else
                {
                    dgvBook.DataSource = table;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                string author = txtAuthor.Text;
                table = proxy.SearchBookByAuthor(author);
                if (table.Rows.Count == 0 || table == null)
                {
                    MessageBox.Show("No Solution");
                }
                else
                {
                    dgvBook.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFilterByCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string category = cboCategory.SelectedValue.ToString();
                table = proxy.FilterBookByCategory(category);
                if (table.Rows.Count == 0 || table == null)
                {
                    MessageBox.Show("This Category is empty");
                }
                else
                {
                    dgvBook.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text)) {
                try
                {
                    UpdateBook form = new UpdateBook(int.Parse(txtID.Text));
                    form.ShowDialog();
                }
                catch (Exception)
                {

                    MessageBox.Show("Please Enter correct ISBN");
                }
                
                


            }
        }
    }
}
