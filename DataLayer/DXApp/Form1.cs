using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DXApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCagatory_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.ShowDialog();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
            
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            //MessageBox.Show("ABC");
            AuthorForm authorform = new AuthorForm();
            authorform.ShowDialog();

        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            PublisherForm pubForm = new PublisherForm();
            pubForm.ShowDialog();
        }
    }
}
