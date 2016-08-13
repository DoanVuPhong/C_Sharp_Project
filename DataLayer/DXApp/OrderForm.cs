using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Interface_Data;
using System.ServiceModel;

namespace DXApp
{
    
    public partial class frmOrder : Form
    {
        IBussinessLogic proxy;
        DataTable datatable;
        List<Panel> listPanel = new List<Panel>();

        public frmOrder()
        {
            InitializeComponent();

            listPanel.Add(panel0);
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            for (int i = 0; i < listPanel.Count; i++)
            {
                
                if (i == 3)
                {
                    listPanel[i].Visible = true;
                }
                else
                {
                    listPanel[i].Visible = false;
                }
               
            }
            chDate.CustomFormat = "yyyy/MM/dd";
            chDate.Format = DateTimePickerFormat.Custom;
            //chDate.Format = DateTimePickerFormat.Time;

            chDateFrom.CustomFormat = "yyyy/MM/dd";
            chDateFrom.Format = DateTimePickerFormat.Custom;
            //chDateFrom.Format = DateTimePickerFormat.Time;

            chDateTo.CustomFormat = "yyyy/MM/dd";
            chDateTo.Format = DateTimePickerFormat.Custom;

            cbbChoiceSearch.SelectedIndex = 3;
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByName.Text))
            {
                errName.SetError(txtSearchByName,"Name is not empty.");
                return;
            }
            else
            {
                errName.Clear();
            }

            string keyname = txtSearchByName.Text.Trim();
            datatable = proxy.SearchByCustomerNameOrder(keyname);
            dgvOrder.DataSource = datatable;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }

        private void cbbChoiceSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = cbbChoiceSearch.SelectedIndex;
            for (int i = 0; i < listPanel.Count; i++)
            {
                if (pos == i) {
                    listPanel[i].Visible = true;
                }
                else
                {
                    listPanel[i].Visible = false;
                }
            }
        }

        private void txtSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime date = chDate.Value;
            datatable = proxy.SearchByDate(date);
            dgvOrder.DataSource = datatable;
        }

        private void chDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByRangeDate_Click(object sender, EventArgs e)
        {
            DateTime from = chDateFrom.Value;
            DateTime to = chDateTo.Value;
            datatable = proxy.SearchByRangeDateOrder(from, to);
            dgvOrder.DataSource = datatable;
        }

        private void chDateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSearchByID.Text);
                errID.Clear();
            }
            catch (Exception)
            {
                errID.SetError(txtSearchByID, "ID not null or empty.");
                
                return;
            }
            int ID = int.Parse(txtSearchByID.Text);
            datatable = proxy.SearchByIDOrder(ID);
            dgvOrder.DataSource = datatable;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string textID = dgvOrder.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                int ID = int.Parse(textID);
                datatable = proxy.GetAllOrderDetailByID(ID);
                dgvOrderDetail.DataSource = datatable;
            }
            else
            {
                return;
            }
        }

        private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
