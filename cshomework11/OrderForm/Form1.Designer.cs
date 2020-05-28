namespace OrderForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Allordersbtn = new System.Windows.Forms.Button();
            this.Searchlabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchModecbx = new System.Windows.Forms.ComboBox();
            this.SearchModetbx = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.MODIFYbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ordersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.detailsdataGridView2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Allordersbtn);
            this.panel1.Controls.Add(this.Searchlabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchModecbx);
            this.panel1.Controls.Add(this.SearchModetbx);
            this.panel1.Controls.Add(this.Searchbtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 109);
            this.panel1.TabIndex = 14;
            // 
            // Allordersbtn
            // 
            this.Allordersbtn.Location = new System.Drawing.Point(732, 24);
            this.Allordersbtn.Name = "Allordersbtn";
            this.Allordersbtn.Size = new System.Drawing.Size(95, 26);
            this.Allordersbtn.TabIndex = 12;
            this.Allordersbtn.Text = "所有订单";
            this.Allordersbtn.UseVisualStyleBackColor = true;
            this.Allordersbtn.Click += new System.EventHandler(this.Allordersbtn_Click);
            // 
            // Searchlabel2
            // 
            this.Searchlabel2.AutoSize = true;
            this.Searchlabel2.Location = new System.Drawing.Point(453, 62);
            this.Searchlabel2.Name = "Searchlabel2";
            this.Searchlabel2.Size = new System.Drawing.Size(0, 15);
            this.Searchlabel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "查询方式";
            // 
            // SearchModecbx
            // 
            this.SearchModecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchModecbx.FormattingEnabled = true;
            this.SearchModecbx.Items.AddRange(new object[] {
            "ID",
            "Customer",
            "ItemName"});
            this.SearchModecbx.Location = new System.Drawing.Point(353, 24);
            this.SearchModecbx.Name = "SearchModecbx";
            this.SearchModecbx.Size = new System.Drawing.Size(121, 23);
            this.SearchModecbx.TabIndex = 8;
            // 
            // SearchModetbx
            // 
            this.SearchModetbx.Location = new System.Drawing.Point(480, 24);
            this.SearchModetbx.Name = "SearchModetbx";
            this.SearchModetbx.Size = new System.Drawing.Size(100, 25);
            this.SearchModetbx.TabIndex = 9;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(600, 23);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 26);
            this.Searchbtn.TabIndex = 5;
            this.Searchbtn.Text = "查询";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ADDbtn);
            this.panel2.Controls.Add(this.MODIFYbtn);
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Location = new System.Drawing.Point(340, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 100);
            this.panel2.TabIndex = 16;
            // 
            // ADDbtn
            // 
            this.ADDbtn.Location = new System.Drawing.Point(12, 33);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(75, 31);
            this.ADDbtn.TabIndex = 2;
            this.ADDbtn.Text = "添加";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // MODIFYbtn
            // 
            this.MODIFYbtn.Location = new System.Drawing.Point(175, 33);
            this.MODIFYbtn.Name = "MODIFYbtn";
            this.MODIFYbtn.Size = new System.Drawing.Size(75, 31);
            this.MODIFYbtn.TabIndex = 4;
            this.MODIFYbtn.Text = "修改";
            this.MODIFYbtn.UseVisualStyleBackColor = true;
            this.MODIFYbtn.Click += new System.EventHandler(this.MODIFYbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(343, 33);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 31);
            this.Deletebtn.TabIndex = 3;
            this.Deletebtn.Text = "删除";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 124);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ordersdataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailsdataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 208);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 19;
            // 
            // ordersdataGridView1
            // 
            this.ordersdataGridView1.AutoGenerateColumns = false;
            this.ordersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.totalPrizeDataGridViewTextBoxColumn1});
            this.ordersdataGridView1.DataSource = this.OrderSource1;
            this.ordersdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersdataGridView1.Location = new System.Drawing.Point(0, 0);
            this.ordersdataGridView1.Name = "ordersdataGridView1";
            this.ordersdataGridView1.RowTemplate.Height = 27;
            this.ordersdataGridView1.Size = new System.Drawing.Size(534, 208);
            this.ordersdataGridView1.TabIndex = 1;
            // 
            // detailsdataGridView2
            // 
            this.detailsdataGridView2.AutoGenerateColumns = false;
            this.detailsdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsdataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.prizeDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn});
            this.detailsdataGridView2.DataMember = "OrderItems";
            this.detailsdataGridView2.DataSource = this.OrderSource1;
            this.detailsdataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsdataGridView2.Location = new System.Drawing.Point(0, 0);
            this.detailsdataGridView2.Name = "detailsdataGridView2";
            this.detailsdataGridView2.RowTemplate.Height = 27;
            this.detailsdataGridView2.Size = new System.Drawing.Size(577, 208);
            this.detailsdataGridView2.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            // 
            // totalPrizeDataGridViewTextBoxColumn1
            // 
            this.totalPrizeDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrize";
            this.totalPrizeDataGridViewTextBoxColumn1.HeaderText = "TotalPrize";
            this.totalPrizeDataGridViewTextBoxColumn1.Name = "totalPrizeDataGridViewTextBoxColumn1";
            this.totalPrizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // OrderSource1
            // 
            this.OrderSource1.DataSource = typeof(DatabaseOrder.Order);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // prizeDataGridViewTextBoxColumn
            // 
            this.prizeDataGridViewTextBoxColumn.DataPropertyName = "Prize";
            this.prizeDataGridViewTextBoxColumn.HeaderText = "Prize";
            this.prizeDataGridViewTextBoxColumn.Name = "prizeDataGridViewTextBoxColumn";
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Allordersbtn;
        private System.Windows.Forms.Label Searchlabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchModecbx;
        private System.Windows.Forms.TextBox SearchModetbx;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.Button MODIFYbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView ordersdataGridView1;
        private System.Windows.Forms.DataGridView detailsdataGridView2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource OrderSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
    }
}

