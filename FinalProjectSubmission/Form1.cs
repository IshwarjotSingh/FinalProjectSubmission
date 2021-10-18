using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FinalProjectSubmission
{
    public partial class Form1 : Form
    {
        public static string dir = @".\downloads\";
        public static FileStream fs = null;
        public static bool validText = false;

        

        public Form1()
        {
            InitializeComponent();
        } private void Form1_Load(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e){}

      


        private void btn_IS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_IS_Validate_Click(object sender, EventArgs e)
        {
            Regex Name = new Regex(@"^[a-zA-Z]{1,45}\s[a-zA-Z]{1,45}$");
            if (!Name.IsMatch(button2.Text))
            {
                MessageBox.Show("Enter the Valid Name having \n first name and last name \n " +
                    "(minimum length of 12 letters)\n " +
                    "separated by a space");
            }
            else
            {
                MessageBox.Show("Approved. Valid Entry");
            }

            Regex session = new Regex(@"(Summer)||(Winter)||(Fall)");
            if (!session.IsMatch(comboBox1.Text))
            {
                MessageBox.Show("Only select a valid option for the session");
            }
            else
            {
                MessageBox.Show("Approved. the session is valid");
            }

            Regex year = new Regex(@"^20[1-2][0-9]$");
            if (!year.IsMatch(comboBox2.Text))
            {
                MessageBox.Show("enter a valid year");
            }
            else
            {
                MessageBox.Show("Appproved Year is valid");
            }

            Regex course = new Regex(@"(420-CT2-AS)|(420-CT3-AS)|(420-CT4-AS)");
            if (!course.IsMatch(txt_Is_Course.Text))
            {
                MessageBox.Show
                    ("Choose from the option :: \n 420-CT2-AS, 420-CT3-AS or 420-CT4-AS");
            }
            else
            {
                MessageBox.Show("Appproved the couse name is valid");
            }

            double number1 = Convert.ToDouble(txt_Is_MidExm.Text);
            double number2 = Convert.ToDouble(txt_Is_Proj.Text);
            double number3 = Convert.ToDouble(txt_Is_FInal.Text);

            double Total = number1 + number2 + number3;

            double Pnumber1 = 0.3 * number1;
            double Pnumber2 = 0.3 * number2;
            double Pnumber3 = 0.4 * number1;

            double Percentage = Pnumber1 + Pnumber2 + Pnumber3;

            txt_Is_Total.Text = Convert.ToString(Total);
            txt_Is_GradeM.Text = Convert.ToString(Pnumber1);
            txt_Is_GradeProj.Text = Convert.ToString(Pnumber2);
            txt_Is_Fin.Text = Convert.ToString(Pnumber3);
        }

        private void txt_Is_Tot_Click(object sender, EventArgs e)
        {

        }
    }

}

