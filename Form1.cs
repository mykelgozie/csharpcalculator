using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorreal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double ans;
        public double num;
        public int count;


        public void OffCalculator()
        {
            button1.Show();
            button20.Hide();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;




        }
        public void OnCalculator()
        {

            button1.Hide();
            button20.Show();
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button18_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            textBox1.ForeColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnCalculator();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OffCalculator();
        }

        public void compute()
        {


            switch (count)
            {

                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:

                    double rad = num * (Math.PI / 180);

                    ans = Math.Cos(rad);


                    textBox1.Text = ans.ToString();

                    break;

                case 6:

                    double sinRad = num * (Math.PI/180);

                    ans = Math.Sin(sinRad);

                    textBox1.Text = ans.ToString();

                    break;


                case 7:

                    double tanRad = num * (Math.PI / 180);

                    ans = Math.Tan(tanRad);

                    textBox1.Text = ans.ToString();

                    break;
                case 8:

                    double power = double.Parse(textBox1.Text);

                    ans = Math.Pow(num, power);

                    textBox1.Text = ans.ToString();

                    break;


                default:
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " +";
            count = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " -";
            count = 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " *";
            count = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " /";
            count = 4;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int textLen = textBox1.TextLength-1;
            string text = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < textLen; i++)
            {
                textBox1.Text = textBox1.Text + text[i];


            }

           

          
        }

        private void button21_Click(object sender, EventArgs e)
        {
           double num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text =  "Cos() " + num.ToString();
            count = 5;
        }

        private void button23_Click(object sender, EventArgs e)
        {

            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = "Sin() " + num.ToString();
            count = 6;

        }

        private void button22_Click(object sender, EventArgs e)
        {

            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = "Tan() " + num.ToString();
            count = 7;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = num.ToString() + " ^";
            count = 8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
