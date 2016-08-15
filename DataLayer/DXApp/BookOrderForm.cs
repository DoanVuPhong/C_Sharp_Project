﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Interface_Data;
using System.ServiceModel;

namespace DXApp
{

    public partial class BookOrderForm : Form
    {
        IBussinessLogic proxy;
        DataTable datatable;
        List<BookOrderObj> OrderList = new List<BookOrderObj>();

        public BookOrderForm()
        {
            InitializeComponent();
            ChannelFactory<IBussinessLogic> chanel = new ChannelFactory<IBussinessLogic>("ClientEndPoint");
            proxy = chanel.CreateChannel();
        }

        private bool loadData()
        {
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomSearch_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;
            string BookName = txtBookName.Text;
            string AuthorName = txtAuthorName.Text;
            datatable = proxy.CustomSearchBook(ISBN, BookName, AuthorName);
            dgvBook.DataSource = datatable;
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int ID = int.Parse(dgvBook.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                string ISBN = dgvBook.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                string Name = dgvBook.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                int OrderQuantity = 1;
                BookOrderObj re = OrderList.SingleOrDefault(o => o.ID == ID);
                if (re != null)
                {
                    OrderQuantity = re.Quantity + 1;
                    re.Quantity = OrderQuantity;
                }
                else
                {
                    OrderList.Add(new BookOrderObj
                    {
                        ID = ID,
                        ISBN = ISBN,
                        Name = Name,
                        Quantity = 1
                    });
                }

                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
            }
            else
            {
                return;
            }




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvOrderBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrderBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                int ID = int.Parse(dgvOrderBook.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                BookOrderObj re = OrderList.SingleOrDefault(o => o.ID == ID);
                if (re != null)
                {
                    re.Quantity = re.Quantity - 1;
                    if (re.Quantity == 0)
                    {
                        OrderList.Remove(re);
                    }
                }
                else
                {
                    return;
                }

                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
            }
            else
            {
                return;
            }

    */

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (OrderList.Count <= 0)
            {
                errOrder.SetError(dgvOrderBook, "Empty Book in Order list.");
                return;
            }
            else
            {
                errOrder.Clear();
            }
            if (string.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                errCustomerName.SetError(txtCustomerName, "Customer name not empty!");
                return;
            }
            else
            {
                errCustomerName.Clear();
            }
            bool check = true;

            int IdOrder = proxy.AddReturnIDOrder(new OrderData()
            {
                customer_name = txtCustomerName.Text.Trim(),
                date = DateTime.Now,
                account_ID = 1,
                status = "complete"
            });
            if (IdOrder > 0)
            {
                foreach (var item in OrderList)
                {
                    check = proxy.AddOrderDetail(new OrderDetailData()
                    {
                        book_ID = item.ID,
                        quantity = item.Quantity,
                        order_ID = IdOrder
                    });
                }
            }
            else
            {
                check = false;
            }
            if (check == true)
            {
                MessageBox.Show("Check Out Successful");
                OrderList.Clear();

                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
                txtCustomerName.Text = "";
            }
            else
            {
                MessageBox.Show("Check Out Fail");
            }

        }

        private void dgvOrderBook_DragOver(object sender, DragEventArgs e)
        {
        }

        private void dgvOrderBook_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            int current = dgvOrderBook.CurrentCell.RowIndex;

            if (current >= 0)
            {
                int ID = int.Parse(dgvOrderBook.Rows[current].Cells["ID"].Value.ToString());

                BookOrderObj re = OrderList.SingleOrDefault(o => o.ID == ID);
                if (re != null)
                {
                    re.Quantity = re.Quantity + 1;
                   
                }
                else
                {
                    return;
                }

                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
            }
            else
            {
                return;
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int current = dgvOrderBook.CurrentCell.RowIndex;

            if (current >= 0)
            {
                int ID = int.Parse(dgvOrderBook.Rows[current].Cells["ID"].Value.ToString());

                DialogResult r = MessageBox.Show("Do you want delete this items?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    BookOrderObj re = OrderList.SingleOrDefault(o => o.ID == ID);
                    if (re != null)
                    {
                        OrderList.Remove(re);
                    }
                    else
                    {
                        return;
                    } 
                }

                
                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
            }
            else
            {
                return;
            }
        }

        private void dgvOrderBook_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void dgvOrderBook_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            int current = dgvOrderBook.CurrentCell.RowIndex;
            if (current >= 0)
            {
                int ID = int.Parse(dgvOrderBook.Rows[current].Cells["ID"].Value.ToString());

                BookOrderObj re = OrderList.SingleOrDefault(o => o.ID == ID);
                if (re != null)
                {
                    re.Quantity = re.Quantity - 1;
                    if (re.Quantity == 1)
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

                var bindingList = new BindingList<BookOrderObj>(OrderList);
                dynamic source = new BindingSource(bindingList, null);
                dgvOrderBook.DataSource = source;
            }
            else
            {
                return;
            }
            */
        }
    }
}
