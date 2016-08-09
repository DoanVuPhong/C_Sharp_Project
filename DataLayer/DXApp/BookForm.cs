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
                Publisher_ID = int.Parse(publisher.Publisher_ID.ToString()),
                Status = txtStatus.Text,
                Year = txtYear.Text
            };
            proxy.IAddBook(book);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            List<dynamic> Publishers = new List<dynamic>
            {
                new {Publisher_ID = 1, Name = "LT"},
                new {Publisher_ID = 2, Name = "TL"}
            };
            cboPublisher.DataSource = Publishers;
            cboPublisher.DisplayMember = "Name";
            cboPublisher.ValueMember = "Publisher_ID";
        }
    }
}
