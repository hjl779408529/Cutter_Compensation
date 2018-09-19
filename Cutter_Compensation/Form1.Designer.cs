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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 229);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(297, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(34, 179);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(102, 27);
            this.test_btn.TabIndex = 1;
            this.test_btn.Text = "计算角度";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "向量A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "向量B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // Vector_A_X
            // 
            this.Vector_A_X.Location = new System.Drawing.Point(89, 74);
            this.Vector_A_X.Name = "Vector_A_X";
            this.Vector_A_X.Size = new System.Drawing.Size(91, 25);
            this.Vector_A_X.TabIndex = 6;
            this.Vector_A_X.TextChanged += new System.EventHandler(this.Vector_A_X_TextChanged);
            // 
            // Vector_A_Y
            // 
            this.Vector_A_Y.Location = new System.Drawing.Point(198, 74);
            this.Vector_A_Y.Name = "Vector_A_Y";
            this.Vector_A_Y.Size = new System.Drawing.Size(91, 25);
            this.Vector_A_Y.TabIndex = 7;
            this.Vector_A_Y.TextChanged += new System.EventHandler(this.Vector_A_Y_TextChanged);
            // 
            // Vector_B_Y
            // 
            this.Vector_B_Y.Location = new System.Drawing.Point(198, 122);
            this.Vector_B_Y.Name = "Vector_B_Y";
            this.Vector_B_Y.Size = new System.Drawing.Size(91, 25);
            this.Vector_B_Y.TabIndex = 9;
            this.Vector_B_Y.TextChanged += new System.EventHandler(this.Vector_B_Y_TextChanged);
            // 
            // Vector_B_X
            // 
            this.Vector_B_X.Location = new System.Drawing.Point(89, 122);
            this.Vector_B_X.Name = "Vector_B_X";
            this.Vector_B_X.Size = new System.Drawing.Size(91, 25);
            this.Vector_B_X.TabIndex = 8;
            this.Vector_B_X.TextChanged += new System.EventHandler(this.Vector_B_X_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 358);
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
    }
}

