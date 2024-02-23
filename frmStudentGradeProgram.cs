using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grade1, grade2, grade3, grade4, grade5, average;
            grade1 = Convert.ToDouble(grade1Input.Text);
            grade2 = Convert.ToDouble(grade2Input.Text);
            grade3 = Convert.ToDouble(grade3Input.Text);
            grade4 = Convert.ToDouble(grade4Input.Text);
            grade5 = Convert.ToDouble(grade5Input.Text);

            average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            passOrFail.Text = average >= 75.00 ? "The student passed." : "The student failed.";
            showAvg.Text = "The general average of " + textBox1.Text + " is " + average + ".";
        }
    }
}
