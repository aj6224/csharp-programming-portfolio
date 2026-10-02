using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author: Aaron Judd
//Due Date: 11/07/2024
//Program Number: 3
//Class Section: 01
//Description: The following code will be used for a catering company to calculate the total price for a business if they decide to use catering services. A discount is applicable for the contract years based on how long the contract is with the company. Nested loops and arrays are used to calculate


namespace Program3
{
    public partial class Program3 : Form
    {
        
        //Array for catering
        string[] cateringCompanies = { "Hill Catering Co.", "Food in a Flash", "Sally’s Sandwiches", "Perry’s Pierogis" };//Catering names
        double[] discountRates = { 0.30, 0.20, 0.12, 0.05 }; //Catering values

        //Array for businesses
        string[] businesses = { "John’s Books", "Office Supplies", "J.B. Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear" };//Business names
        double[] contractPrices = { 500, 489, 412, 350, 325, 279 }; //Business values
        
        // Array for contract years
        int[] contractYearsThresholds = { 1, 4, 7, 10 }; // Year ranges
        double[] additionalDiscounts = { 0, 30, 40, 50 }; // Discounts according to year
        public Program3()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Catering company combo box
            catCB.Items.AddRange(cateringCompanies);

            //  Business name combo box
            buszCB.Items.AddRange(businesses);

        }
        private void calcBtn_Click(object sender, EventArgs e)
        {
            // Check if user selected a catering company
            if (catCB.SelectedIndex < 0)//Selections greater than 0
            {
                MessageBox.Show("Please select a catering company.");//MB show error if box not selected
                return;//return to form
            }

            // Check if user selected a business
            if (buszCB.SelectedIndex < 0)//Selection greater than 0
            {
                MessageBox.Show("Please select a business name from the list");//MB show error if box not selected
                return;//return to form
            }

            // Contract year value verified
            if (!int.TryParse(conTB.Text, out int contractYears) || contractYears <= 0)
            {
                MessageBox.Show("Please provide valid contract years");//MB show
                return;//return to form
            }

            // Get selected index for caterer and business
            int catererIndex = catCB.SelectedIndex;
            int businessIndex = buszCB.SelectedIndex;

            // Get base price and discount rate
            double basePrice = contractPrices[businessIndex];
            double discountRate = discountRates[catererIndex];

            // Calculate the initial discount based on the selected caterer
            double discountAmount = basePrice * discountRate;
            double discountedPrice = basePrice - discountAmount;

            // Calculate additional discount based on contract years
            double additionalDiscount = 0;
            for (int i = 0; i < contractYearsThresholds.Length; i++)//logic function, post increment
            {
                if (contractYears <= contractYearsThresholds[i])//Nested loop
                {
                    additionalDiscount = additionalDiscounts[i];
                    break;
                }
            }
            //Check if contract years exceed contractYear
            if (contractYears > contractYearsThresholds[contractYearsThresholds.Length - 1])
            {
                //Discount applied based on range above
                //Additional discount
                additionalDiscount = additionalDiscounts[(int)additionalDiscounts[contractYearsThresholds.Length - 1]];
            }

            // Calculate final price after applying additional discount
            double finalPrice = discountedPrice - additionalDiscount;

            // Display result
            fnLbl.Text = $"Final Price: ${finalPrice:F2}";
        }
    }
}
