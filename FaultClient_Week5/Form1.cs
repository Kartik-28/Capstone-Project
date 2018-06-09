using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaultClient_Week5
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = client.Div(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
            

        }
    }
}
