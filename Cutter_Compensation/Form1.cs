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
        Vector Org_Point = new Vector(0,0);
        decimal Equildistant = 2; 
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
            Cross_X.Text = Org_Point.X.ToString();
            Cross_Y.Text = Org_Point.Y.ToString();
            Distance.Text = Equildistant.ToString();
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
        //计算等距线交点
        private void Cal_Cross_Click(object sender, EventArgs e)
        {
            Vector Cross_Point = test.Cal_Cross_Point(A,B,Org_Point,Equildistant);
            richTextBox1.AppendText(string.Format("向量夹角: {0}", test.AngleBetweenVector(A, B)) + "\r\n");
            richTextBox1.AppendText(string.Format("原坐标({0},{1}),等距线变换后坐标({2},{3})", Org_Point.X,Org_Point.Y,Cross_Point.X,Cross_Point.Y) + "\r\n");
        }

        private void Cross_X_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Cross_X.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                Org_Point = new Vector(tmp ,Org_Point.Y);
            });
        }

        private void Cross_Y_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Cross_Y.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                Org_Point = new Vector(Org_Point.X, tmp);
            });
        }

        private void Distance_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((EventHandler)delegate
            {
                if (!decimal.TryParse(Distance.Text, out decimal tmp))
                {
                    MessageBox.Show("请正确输入数字");
                    return;
                }
                Equildistant = tmp;
            });
        }

        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
