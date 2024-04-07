using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentForm
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtName.Text, txtSurname.Text, Convert.ToInt32(Console.ReadLine()));

        }


 private void Add_Load(object sender, EventArgs e)
        {

        }


    }
}
