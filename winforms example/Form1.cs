using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                listView1.Items.Add("text" + i.ToString());
            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>(); 
            foreach(var i in listView1.Items) 
            {
                list.Add(i.ToString());
            }
            Form2 f = new Form2(list);
            f.ShowDialog(); 
           
           
        }
    }
}
