using System;
using System.Security.Policy;
using System.Windows.Forms;
//Author: Aaron Judd
//Program Number: 02
//Class Section: 01
//Due Date: 10/17/2024
//Description: The following form was developed to calculate the points awarded to a user of a code website based on the exercise difficulty
// and whether or not the exercise was an actual interview question... Enjoy :)

namespace PROGRAM_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e) //Double click executed
        {
            //Variables defined
            string userName; //Username stored but not used
            
            //integers
            int exerciseNumber; //exercise numer stored as int
            int timeSpent; //timespent is duration of exercise entered

            //doubles (constant) variables
            double basePoints = 0; // Base points for difficulty level
            double timePenalty = 5; // Penalty for each minute spent
            double adjustedPoints = 0; // Final points after adjustments

            //check if username is empty
            if (string.IsNullOrEmpty(UserTxtBox.Text))//Null = empty
            {
                MessageBox.Show("Please enter your username.");//Message box for no username entered
                return;//return to form
            }

            //Validating the exercise number in valid range
            if (!int.TryParse(ExerciseTxtBox.Text, out exerciseNumber) || exerciseNumber < 1 || exerciseNumber > 1000)//range between 1 and 1000
            {
                MessageBox.Show("Please enter a valid Exercise Number between 1 and 1000.");//Message box for invalid exercise number
                return;//return to form
            }

            //Validating the exercise difficulty is selected
            if (DifficultycomboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an exercise difficulty.");//Message box for no exercise difficulty selected
                return;//return to form
            }

            // Validate Time Spent on Exercise
            if (!int.TryParse(TimeTxtBox.Text, out timeSpent))//! for not, minutes not entered
            {
                MessageBox.Show("Please enter a valid time spent in minutes.");//Message box for no valid minutes entered
                return;//return to form
            }

            //Check if either Yes or No radio button is selected
            if (!(yesRBtn.Checked || noRBtn.Checked))
            {
                MessageBox.Show("Please indicate if the exercise was an actual interview question.");//Message box for no yes or no box checked
                return;//return to form
            }

            // Determine base points based on selected difficulty
            if (DifficultycomboBox.SelectedIndex == 0) // Easy difficulty selected
            {
                //points displayed down here instead of with variables because only one outcome/calculation required
                basePoints = 100;//100 points for easy
            }
            else if (DifficultycomboBox.SelectedIndex == 1) // Medium difficulty selected
            {
                basePoints = 200;//200 points for medium
            }
            else if (DifficultycomboBox.SelectedIndex == 2) // Hard selected
            {
                basePoints = 300;//300 points selected for hard
            }
            else if (DifficultycomboBox.SelectedIndex == 3) // Very Hard selected
            {
                basePoints = 400;//400 points for very hard
            }
            else//if no difficulty level selected
            {
                MessageBox.Show("Please select a valid difficulty level.");//Message box show
                return;//return to form
            }

            //Time penalty (5 points per minute)
            adjustedPoints = basePoints - (timeSpent * timePenalty);//Formula to subtract the points deducted

            //10% bonus if the exercise was an actual interview question
            if (yesRBtn.Checked)//if yes checked
            {
                adjustedPoints *= 1.1; // 10% bonus in decimal form, .1 times number
            }

            // Display the calculated points in the output label
            outputLbl.Text = $"Total Points: {adjustedPoints}";//String interpolation from adjusted points
        }
    }
}
