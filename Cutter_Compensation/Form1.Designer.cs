namespace Cutter_Compensation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vector_A_X = new System.Windows.Forms.TextBox();
            this.Vector_A_Y = new System.Windows.Forms.TextBox();
            this.Vector_B_Y = new System.Windows.Forms.TextBox();
            this.Vector_B_X = new System.Windows.Forms.TextBox();
            this.Cal_Cross = new System.Windows.Forms.Button();
            this.Cross_Y = new System.Windows.Forms.TextBox();
            this.Cross_X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 355);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(415, 114);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(95, 308);
            this.test_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(162, 39);
            this.test_btn.TabIndex = 1;
            this.test_btn.Text = "计算角度";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "向量A：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "向量B：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // Vector_A_X
            // 
            this.Vector_A_X.Location = new System.Drawing.Point(125, 89);
            this.Vector_A_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vector_A_X.Name = "Vector_A_X";
            this.Vector_A_X.Size = new System.Drawing.Size(102, 28);
            this.Vector_A_X.TabIndex = 6;
            this.Vector_A_X.TextChanged += new System.EventHandler(this.Vector_A_X_TextChanged);
            // 
            // Vector_A_Y
            // 
            this.Vector_A_Y.Location = new System.Drawing.Point(307, 89);
            this.Vector_A_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vector_A_Y.Name = "Vector_A_Y";
            this.Vector_A_Y.Size = new System.Drawing.Size(102, 28);
            this.Vector_A_Y.TabIndex = 7;
            this.Vector_A_Y.TextChanged += new System.EventHandler(this.Vector_A_Y_TextChanged);
            // 
            // Vector_B_Y
            // 
            this.Vector_B_Y.Location = new System.Drawing.Point(307, 146);
            this.Vector_B_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vector_B_Y.Name = "Vector_B_Y";
            this.Vector_B_Y.Size = new System.Drawing.Size(102, 28);
            this.Vector_B_Y.TabIndex = 9;
            this.Vector_B_Y.TextChanged += new System.EventHandler(this.Vector_B_Y_TextChanged);
            // 
            // Vector_B_X
            // 
            this.Vector_B_X.Location = new System.Drawing.Point(125, 146);
            this.Vector_B_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vector_B_X.Name = "Vector_B_X";
            this.Vector_B_X.Size = new System.Drawing.Size(102, 28);
            this.Vector_B_X.TabIndex = 8;
            this.Vector_B_X.TextChanged += new System.EventHandler(this.Vector_B_X_TextChanged);
            // 
            // Cal_Cross
            // 
            this.Cal_Cross.Location = new System.Drawing.Point(277, 308);
            this.Cal_Cross.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cal_Cross.Name = "Cal_Cross";
            this.Cal_Cross.Size = new System.Drawing.Size(162, 39);
            this.Cal_Cross.TabIndex = 10;
            this.Cal_Cross.Text = "计算等距线交点";
            this.Cal_Cross.UseVisualStyleBackColor = true;
            this.Cal_Cross.Click += new System.EventHandler(this.Cal_Cross_Click);
            // 
            // Cross_Y
            // 
            this.Cross_Y.Location = new System.Drawing.Point(307, 201);
            this.Cross_Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cross_Y.Name = "Cross_Y";
            this.Cross_Y.Size = new System.Drawing.Size(102, 28);
            this.Cross_Y.TabIndex = 13;
            this.Cross_Y.TextChanged += new System.EventHandler(this.Cross_Y_TextChanged);
            // 
            // Cross_X
            // 
            this.Cross_X.Location = new System.Drawing.Point(125, 201);
            this.Cross_X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cross_X.Name = "Cross_X";
            this.Cross_X.Size = new System.Drawing.Size(102, 28);
            this.Cross_X.TabIndex = 12;
            this.Cross_X.TextChanged += new System.EventHandler(this.Cross_X_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "交点：";
            // 
            // Distance
            // 
            this.Distance.Location = new System.Drawing.Point(125, 257);
            this.Distance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(102, 28);
            this.Distance.TabIndex = 15;
            this.Distance.TextChanged += new System.EventHandler(this.Distance_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "距离：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 505);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cross_Y);
            this.Controls.Add(this.Cross_X);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cal_Cross);
            this.Controls.Add(this.Vector_B_Y);
            this.Controls.Add(this.Vector_B_X);
            this.Controls.Add(this.Vector_A_Y);
            this.Controls.Add(this.Vector_A_X);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Vector_A_X;
        private System.Windows.Forms.TextBox Vector_A_Y;
        private System.Windows.Forms.TextBox Vector_B_Y;
        private System.Windows.Forms.TextBox Vector_B_X;
        private System.Windows.Forms.Button Cal_Cross;
        private System.Windows.Forms.TextBox Cross_Y;
        private System.Windows.Forms.TextBox Cross_X;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Distance;
        private System.Windows.Forms.Label label6;
    }
}

