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
        BookData current = new BookData();
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
                bindingBook.DataSource = table;
                if (bindingBook != null)
                {
                    MessageBox.Show(bindingBook.ToString());
                    txtID.DataBindings.Clear();

                    txtID.DataBindings.Add("Text", bindingBook, "ID");
                    dgvBook.DataSource = bindingBook;
                }
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
                //int id = (int)row.Cells[0].Value;
                //current.ID = id;
                //current.Name = row.Cells[1].Value.ToString();
                //current.Status = row.Cells[2].Value.ToString();
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            
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
    }
}
