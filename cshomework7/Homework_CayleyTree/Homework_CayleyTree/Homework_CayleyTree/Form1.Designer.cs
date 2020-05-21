namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leftRatio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rightRatio = new System.Windows.Forms.ComboBox();
            this.leftDegree = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rightDegree = new System.Windows.Forms.HScrollBar();
            this.deepth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorSelect = new System.Windows.Forms.ComboBox();
            this.rightAngleShow = new System.Windows.Forms.Label();
            this.leftAngleShow = new System.Windows.Forms.Label();
            this.errorAlarm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "DrawTree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.drawTree);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 385);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "主干长度：";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(648, 28);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 25);
            this.length.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "递归深度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "左分支比例：";
            // 
            // leftRatio
            // 
            this.leftRatio.FormattingEnabled = true;
            this.leftRatio.Location = new System.Drawing.Point(648, 133);
            this.leftRatio.Name = "leftRatio";
            this.leftRatio.Size = new System.Drawing.Size(100, 23);
            this.leftRatio.TabIndex = 7;
            this.leftRatio.SelectedIndexChanged += new System.EventHandler(this.leftRatio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "右分支比例：";
            // 
            // rightRatio
            // 
            this.rightRatio.FormattingEnabled = true;
            this.rightRatio.Location = new System.Drawing.Point(648, 186);
            this.rightRatio.Name = "rightRatio";
            this.rightRatio.Size = new System.Drawing.Size(100, 23);
            this.rightRatio.TabIndex = 8;
            // 
            // leftDegree
            // 
            this.leftDegree.Location = new System.Drawing.Point(645, 236);
            this.leftDegree.Name = "leftDegree";
            this.leftDegree.Size = new System.Drawing.Size(117, 21);
            this.leftDegree.TabIndex = 9;
            this.leftDegree.ValueChanged += new System.EventHandler(this.leftAngle_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "左分支角度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "右分支角度：";
            // 
            // rightDegree
            // 
            this.rightDegree.Location = new System.Drawing.Point(645, 287);
            this.rightDegree.Name = "rightDegree";
            this.rightDegree.Size = new System.Drawing.Size(117, 21);
            this.rightDegree.TabIndex = 9;
            this.rightDegree.ValueChanged += new System.EventHandler(this.rightAngle_ValueChanged);
            // 
            // deepth
            // 
            this.deepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deepth.FormattingEnabled = true;
            this.deepth.Location = new System.Drawing.Point(648, 81);
            this.deepth.Name = "deepth";
            this.deepth.Size = new System.Drawing.Size(100, 23);
            this.deepth.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "颜色：";
            // 
            // ColorSelect
            // 
            this.ColorSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSelect.FormattingEnabled = true;
            this.ColorSelect.Location = new System.Drawing.Point(648, 349);
            this.ColorSelect.Name = "ColorSelect";
            this.ColorSelect.Size = new System.Drawing.Size(100, 23);
            this.ColorSelect.TabIndex = 14;
            // 
            // rightAngleShow
            // 
            this.rightAngleShow.AutoSize = true;
            this.rightAngleShow.Location = new System.Drawing.Point(765, 293);
            this.rightAngleShow.Name = "rightAngleShow";
            this.rightAngleShow.Size = new System.Drawing.Size(30, 15);
            this.rightAngleShow.TabIndex = 15;
            this.rightAngleShow.Text = "0°";
            // 
            // leftAngleShow
            // 
            this.leftAngleShow.AutoSize = true;
            this.leftAngleShow.Location = new System.Drawing.Point(765, 242);
            this.leftAngleShow.Name = "leftAngleShow";
            this.leftAngleShow.Size = new System.Drawing.Size(30, 15);
            this.leftAngleShow.TabIndex = 16;
            this.leftAngleShow.Text = "0°";
            // 
            // errorAlarm
            // 
            this.errorAlarm.AutoSize = true;
            this.errorAlarm.ForeColor = System.Drawing.Color.Red;
            this.errorAlarm.Location = new System.Drawing.Point(535, 375);
            this.errorAlarm.Name = "errorAlarm";
            this.errorAlarm.Size = new System.Drawing.Size(31, 15);
            this.errorAlarm.TabIndex = 17;
            this.errorAlarm.Text = "   ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(754, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "<100";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 21;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.errorAlarm);
            this.Controls.Add(this.leftAngleShow);
            this.Controls.Add(this.rightAngleShow);
            this.Controls.Add(this.ColorSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deepth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightDegree);
            this.Controls.Add(this.leftDegree);
            this.Controls.Add(this.rightRatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftRatio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.length);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox leftRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox rightRatio;
        private System.Windows.Forms.HScrollBar leftDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar rightDegree;
        private System.Windows.Forms.ComboBox deepth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ColorSelect;
        private System.Windows.Forms.Label rightAngleShow;
        private System.Windows.Forms.Label leftAngleShow;
        private System.Windows.Forms.Label errorAlarm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}

