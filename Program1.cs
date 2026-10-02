using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
//Author: Aaron Judd
//Program number: 1
//Due date: 09/26/2024
//Course Section: 01
//Description: This console application will be used by Smith's Auto Repair to calculate a quote. The body shop takes into account parts, labor cost, labors wage (staff assigned), and also has a senior discount that will apply if the customer is aged 65 or older. I chose to create a console application, enjoy!! :)

namespace Program1
{
    internal class Program
    {
        //Here, I defined the constants for the calculation that are the consultation fee, labor charge per hour, and the senior discount if applicable.
        const double Consultation_Fee = 100.00;
        const double Labor_Charge_Per_Hour = 75.00;
        const double Senior_Discount = 0.10; //Senior discount is 10% if the user is aged 65 or older

        static void Main(string[] args)
        {
            //Intro message displayed to show customer the place they are trying to get a quote for
            Console.WriteLine("Welcome to Smith's Auto Repair!\n");
            Console.WriteLine("******************************\n");

            //Prompt for user to enter name, stringing name to store
            Console.Write("Enter your name: ");
            string clientName = Console.ReadLine();

            //Prompt for user to enter make and model of car for store's knowledge, string to store car model
            Console.Write("Enter make and model of car (e.g. Toyota Camry): ");
            string carModel = Console.ReadLine();

            //Prompt for user to enter work hours required, int so data can be stored and used in formula calculation
            Console.Write("Enter the work hours required for job: ");
            int laborHours = int.Parse(Console.ReadLine());

            //Prompt for user/shop to enter the cost of parts for the job, double for integer form to be used to store precise number
            Console.Write("Enter the cost of parts for job: ");
            double partsCost = double.Parse(Console.ReadLine());
            
            //Prompt for user/shop to enter the number of staff assigned, integer so data can be stored and used in formula calculation
            Console.Write("Enter number of staff assigned to job: ");
            int staffAssigned = int.Parse(Console.ReadLine());

            //Prompt for user to enter if they are senior citizen or not, integer so data can be stored and used in the if calculation to give them discounted rate
            Console.Write("Are you a senior citizen aged 65 years or older? (0 for No; 1 for Yes): ");
            int isSeniorCitizen = int.Parse(Console.ReadLine());

            //Formula for the total cost of the job
            double totalCost = Consultation_Fee + (Labor_Charge_Per_Hour * laborHours * staffAssigned) + partsCost;

            //If statement used to calculate the senior discount to be mutliplied by the total cost
            if (isSeniorCitizen == 1)
            {
                totalCost -= (totalCost * Senior_Discount);//Formula for the senior discount
            }
            
            //Line displays the total cost in 2 decimal form and cost will be displayed underneath senior citizen line
            Console.WriteLine($"Total Cost: ${totalCost:F2}");
            Console.WriteLine("******************************\n");


        }
    }
}
