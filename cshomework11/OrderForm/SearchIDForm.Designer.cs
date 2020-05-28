namespace OrderForm
{
    partial class SearchIDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.SearchIDtbx = new System.Windows.Forms.TextBox();
            this.searchIDbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入订单ID";
            // 
            // SearchIDtbx
            // 
            this.SearchIDtbx.Location = new System.Drawing.Point(386, 184);
            this.SearchIDtbx.Name = "SearchIDtbx";
            this.SearchIDtbx.Size = new System.Drawing.Size(100, 25);
            this.SearchIDtbx.TabIndex = 4;
            // 
            // searchIDbtn
            // 
            this.searchIDbtn.Location = new System.Drawing.Point(317, 235);
            this.searchIDbtn.Name = "searchIDbtn";
            this.searchIDbtn.Size = new System.Drawing.Size(75, 32);
            this.searchIDbtn.TabIndex = 5;
            this.searchIDbtn.Text = "搜索";
            this.searchIDbtn.UseVisualStyleBackColor = true;
            this.searchIDbtn.Click += new System.EventHandler(this.searchIDbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // SearchIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchIDbtn);
            this.Controls.Add(this.SearchIDtbx);
            this.Controls.Add(this.label2);
            this.Name = "SearchIDForm";
            this.Text = "SearchIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchIDtbx;
        private System.Windows.Forms.Button searchIDbtn;
        private System.Windows.Forms.Label label1;
    }
}