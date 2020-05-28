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
    public partial class Form1 : Form
    {
        public String Keyword { get; set; }
        public Form1()
        {
            InitializeComponent();
            SearchModecbx.SelectedIndex = 0;
            SearchModetbx.DataBindings.Add("Text", this, "Keyword");
            QueryAll();
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {

            AddModifyForm form2 = new AddModifyForm(false);
            form2.ShowDialog();

            QueryAll();

        }
        private void QueryAll()
        {
            OrderSource1.DataSource = OrderService.GetAllOrders();
            OrderSource1.ResetBindings(true);
        }

        private void Allordersbtn_Click(object sender, EventArgs e)
        {
            OrderSource1.DataSource = OrderService.GetAllOrders();
            OrderSource1.ResetBindings(true);
        }

        private void MODIFYbtn_Click(object sender, EventArgs e)
        {
            Order order = OrderSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }


            AddModifyForm form2 = new AddModifyForm(true);
            form2.CurrentOrder = order;
            form2.Addbindings(order);
            
            form2.ShowDialog();
            QueryAll();

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            Order order = OrderSource1.Current as Order;
            
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            OrderService.RemoveOrder(order.ID);
            QueryAll();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            switch (SearchModecbx.SelectedIndex)
            {
                case 0://根据ID查询
                    Order order = OrderService.GetOrder(Keyword);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    OrderSource1.DataSource = result;
                    break;
                case 1://根据客户查询
                    OrderSource1.DataSource = OrderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 2://根据货物查询
                    OrderSource1.DataSource = OrderService.QueryOrdersByGoodsName(Keyword);
                    break;

            }
        }
    }
}
