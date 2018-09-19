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
        //测试按钮
        private void test_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText ( string.Format("向量夹角: {0}", test.AngleBetweenPoints(new Vector(2,0),new Vector(2,2))) + "\r\n");
                
        }
    }
}
