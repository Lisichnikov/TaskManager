using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Create_Task create_Task = new Create_Task();
            create_Task.ShowDialog();
        }
    }
}
