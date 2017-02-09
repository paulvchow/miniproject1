using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyPlanets_PaulVChow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your weight in lbs in the space provided." + "\n" + "Then click on a planet to calculate your weight on that planet.");

            //A Popup that explains how to use the program

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            setButtonVisibility();



            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please only enter numbers.");
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                
                //Forces user to only use numbers to stop any potential crashes or errors and a pop up occurs if they try to otherwise

            }
            }

            private void setButtonVisibility()
        {
            if (textBox1.Text != String.Empty)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
            }

            //Only enables the buttons once a weight has been entered to stop a potential crash

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double firstTextBoxNumber;
            double jupiter;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            jupiter = 2.64;

            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight

            answer = firstTextBoxNumber * jupiter;
            DialogResult dialog = MessageBox.Show("Your weight on Jupiter is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Jupiter", MessageBoxButtons.YesNo );

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double mars;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            mars = 0.38;

            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight

            answer = firstTextBoxNumber * mars;
            DialogResult dialog = MessageBox.Show("Your weight on Mars is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Mars", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double mercury;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            mercury = 0.37;

            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight

            answer = firstTextBoxNumber * mercury;
            DialogResult dialog = MessageBox.Show("Your weight on Mercury is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Mercury", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double neptune;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            neptune = 1.12;
            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight


            answer = firstTextBoxNumber * neptune;
            DialogResult dialog = MessageBox.Show("Your weight on Neptune is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Neptune", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double pluto;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            pluto = 0.04;
            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight


            answer = firstTextBoxNumber * pluto;
            DialogResult dialog = MessageBox.Show("Your weight on Pluto is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Pluto", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double saturn;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            saturn = 1.15;
            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight


            answer = firstTextBoxNumber * saturn;
            DialogResult dialog = MessageBox.Show("Your weight on Saturn is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Saturn", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double uranus;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            uranus = 1.15;
            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight


            answer = firstTextBoxNumber * uranus;
            DialogResult dialog = MessageBox.Show("Your weight on Uranus is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Uranus", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double venus;
            double answer;
            firstTextBoxNumber = double.Parse(textBox1.Text);
            venus = 0.88;
            //Collects what you put in the textbox and multiplies it using the factor of each planet
            //to get new weight


            answer = firstTextBoxNumber * venus;
            DialogResult dialog = MessageBox.Show("Your weight on Venus is:" + "\n" + (answer.ToString("#.#")) + "lbs" + "\n" + "\n" + "Would you like to calculate another planet?", "Venus", MessageBoxButtons.YesNo);

            //this will open up a popup providing the answer to one decimal point (ToString "#.#"), and asks if they would like to continue calculating

            if (dialog == DialogResult.No) //If they select no, it will close the program
            {
                Application.Exit();
            }
        }
    }
}
