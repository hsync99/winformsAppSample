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
    public partial class Form2 : Form
    {
     
        public Form2(List<string> items)
        {
            InitializeComponent();
            foreach (string item in items) { 
                listView1.Items.Add(item);
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
