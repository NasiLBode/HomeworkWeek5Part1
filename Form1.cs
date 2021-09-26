/* File Name: HomeworkWeek5Part1
 * Programmer: Nasi Bode
 * Problem Statement: Write a program (GUI) that calculates a person's BMI and prints a message
 * telling them whether or not they are below, within, or above (blue, green, yellow, respectively)
 * Use this formual: BMI = weight * 720 / height ^ 2
 * Healthy range: 15 - 25
 * Overall Plan: 
 * 1. Create GUI
 * 2. Create button for user to click
 * 3. Create text box for user input (one for height, one for weight)
 * 4. Label the text boxes
 * 5. Convert string user input to int
 * 6. Calculate BMI using formula
 * 7. Create multi if else statement to output the result
 * 8. If user is in healthy range display output in green to empty string
 * 9. If user is below healthy range display output in blue to empty string
 * 10.If user is above healthy range display output in red to empty string
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkWeek5Part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight = int.Parse(weightInput.Text);
            int height = int.Parse(heightInput.Text);
            int BMI = (weight * 720) / (height * height);

            if (BMI >= 15 && BMI <=25) //if user is in between 15 and 25
            {
                resultOutput.Text = "Your BMI of " + BMI.ToString() + " is within a healthy range";
                resultOutput.ForeColor = Color.Green;
                resultOutput.TextAlign = ContentAlignment.BottomCenter;
            }
            else if (BMI < 15) //if user is below 15
            {
                resultOutput.Text = "Your BMI of " + BMI.ToString() + " is BELOW a healthy range";
                resultOutput.ForeColor = Color.Blue;
                resultOutput.TextAlign = ContentAlignment.BottomCenter;
            }
            else //if user is above the healthy range
            {
                resultOutput.Text = "Your BMI of " + BMI.ToString() + " is ABOVE a healhty range";
                resultOutput.ForeColor = Color.Yellow;
                resultOutput.TextAlign = ContentAlignment.BottomCenter;
            }

        }
    }
}
