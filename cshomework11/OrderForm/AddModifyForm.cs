using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseOrder;
namespace OrderForm
{
    public partial class AddModifyForm : Form
    {
        public Order CurrentOrder;
        public bool edit;
        public AddModifyForm(bool mode)
        {
            InitializeComponent();
            edit = mode;
            
           
            if (edit == false)
            {
                Modifybtn.Visible = false;
                CurrentOrder = new Order();
                AddModifySource1.DataSource = CurrentOrder.OrderItems;
                itemsGridview.DataSource = AddModifySource1;
                IDtbx.DataBindings.Add("Text", CurrentOrder, "ID");
                Custbx.DataBindings.Add("Text", CurrentOrder, "Customer");
            }
            else
            {
                
                Addbtn.Visible = false;
                IDtbx.Enabled = false;
            }
            

        }
        public void Addbindings(Order order)
        {
            IDtbx.DataBindings.Clear();
            Custbx.DataBindings.Clear();
            IDtbx.DataBindings.Add("Text", order, "ID");
            Custbx.DataBindings.Add("Text", order, "Customer");
            AddModifySource1.DataSource = order.OrderItems;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            
            OrderService.AddOrder(CurrentOrder);
        

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {

            CurrentOrder.OrderItems.ForEach(item => {
               
                item.OrderID = CurrentOrder.ID;
            });

            OrderService.UpdateOrder(CurrentOrder);
            
            this.Close();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = AddModifySource1.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveItem(orderItem);
            OrderService.RemoveItem(orderItem);
            AddModifySource1.ResetBindings(true);

        }
    }
}
