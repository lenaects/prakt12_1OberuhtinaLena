using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.SetEat(1),stud.SetRost(1)));           
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.SetEat(6),stud.SetRost(6)));
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.SetEat(13),stud.SetRost(13)));
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.SetEat(-5),stud.SetRost(-5)));
        }
    }
}
