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
    public partial class SearchIDForm : Form
    {
       public Order order;
        public string ID { get; set; }


        public SearchIDForm()
        {
            InitializeComponent();
            SearchIDtbx.DataBindings.Clear();
            SearchIDtbx.DataBindings.Add("Text", this, "ID");
        }

        private void searchIDbtn_Click(object sender, EventArgs e)
        {
            SearchIDtbx.DataBindings.Clear();
            SearchIDtbx.DataBindings.Add("Text", this, "ID");
            order = OrderService.GetOrder(ID);

            if (order == null) label1.Text = "订单不存在";
            else this.Close();

        }
    }
}
