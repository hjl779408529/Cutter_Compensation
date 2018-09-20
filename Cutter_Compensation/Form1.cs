using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cutter_Compensation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cutter test = new Cutter();
        Vector A = new Vector(1,2);
        Vector B = new Vector(-1,-2);
        //测试按钮
        private void test_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText ( string.Format("向量夹角: {0}", (double)test.AngleBetweenVector(A,B)) + "\r\n");
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vector_A_X.Text = A.X.ToString();
            Vector_A_Y.Text = A.Y.ToString();
            Vector_B_X.Text = B.X.ToString();
            Vector_B_Y.Text = B.Y.ToString();
        }

        private void Vector_A_X_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Vector_A_X.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                A = new Vector(tmp, A.Y);
            });
        }

        private void Vector_A_Y_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Vector_A_Y.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                A = new Vector(A.X, tmp);
            });
        }

        private void Vector_B_X_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Vector_B_X.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                B = new Vector(tmp, B.Y);
            });
        }

        private void Vector_B_Y_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Vector_B_Y.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                B = new Vector(B.X, tmp);
            });
        }
    }
}
