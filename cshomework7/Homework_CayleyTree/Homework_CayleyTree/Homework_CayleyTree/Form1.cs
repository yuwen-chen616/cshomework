using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double Degree1;
        double Degree2;
        double per1 ;
        double per2 ;
        double len;
        public Form1()
        {
            InitializeComponent();
            for(int i=7;i<=14;i++)
            deepth.Items.Add($"{i}");                   //深度
            for (int i = 4; i <=8; i++)
                leftRatio.Items.Add($"0.{i}");           //左长度比例
            for (int i = 4; i <= 8; i++)
                rightRatio.Items.Add($"0.{i}");             //右长度比例
            ColorSelect.Items.Add("red");
            ColorSelect.Items.Add("yellow");
            ColorSelect.Items.Add("black");
            ColorSelect.Items.Add("blue");
            ColorSelect.Items.Add("green");
            ColorSelect.Items.Add("purple");
        }
        private void drawTree(object sender, EventArgs e)
        {
            if (double.TryParse(length.Text, out len) )              
            {
                per2 = Convert.ToDouble(leftRatio.SelectedItem.ToString());
                per1 = Convert.ToDouble(rightRatio.SelectedItem.ToString());
                if (graphics == null)graphics = this.panel1.CreateGraphics();
                drawCayleyTree(Convert.ToInt32(deepth.SelectedItem.ToString()),150, 300, len, -Math.PI / 2);
            }
        }

        void drawCayleyTree(int n, double x0, double y0,double len,double degree)
        {
            if (n == 0) return;
            Degree1 = rightDegree.Value * Math.PI / 180;
            Degree2 = leftDegree.Value * Math.PI / 180;
            double x1 = x0 + len * Math.Cos(degree);
            double y1 = y0 + len * Math.Sin(degree);
            int i = ColorSelect.SelectedIndex;
            Pen[] color = { Pens.Red, Pens.Yellow, Pens.Black, Pens.Blue, Pens.Green, Pens.Purple };
            graphics.DrawLine(color[i], (int)x0, (int)y0, (int)x1, (int)y1);
            drawCayleyTree(n - 1, x1, y1, per1 * len, degree + Degree1);
            drawCayleyTree(n - 1, x1, y1, per2 * len, degree - Degree2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftAngle_ValueChanged(object sender, EventArgs e)
        {
            leftAngleShow.Text = $"{leftDegree.Value}°";
        }

        private void rightAngle_ValueChanged(object sender, EventArgs e)
        {
            rightAngleShow.Text = $"{rightDegree.Value}°";
        }

        private void clear(object sender, EventArgs e)
        {
            panel1.Refresh();       
        }

        private void leftRatio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
