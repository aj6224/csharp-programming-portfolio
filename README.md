# csharp-programming-portfolio
Object-oriented C# applications, data structures, file I/O operations, and logic routines.

Program1.cs:
Purpose: This assignment explores the use of variables and simple arithmetic.

Create an interactive Windows Console application (Chapter 2) or Windows Forms application (Chapter 3) designed for estimating costs for an auto body shop. The following steps outline the process:



You have been hired by Smiths Auto Repairs to create a price quote calculator. The program will prompt users to enter information about their car repair needs and will output a quote for the total cost of the job. The following information will need to be collected:

Name of client (String)
Type of car (i.e. Ford Focus) (String)
Work hours (hours) (int)
Parts Cost (double)
Staff assigned (int)
Senior Citizen? (0 or 1) (int)
All work at Smiths requires a fixed $100 consultation fee. The labor charge is $75 per hour per staff member assigned to the job. The cost of parts is added to the total cost. Senior citizens receive a discount on all services performed at Smiths.

Program2.cs:
Congratulations, you just landed a job at Code Quest, a startup company that provides coding practice problems that help users prepare for interviews. The website awards points to users upon completing programming exercises to allow them to assess their performance. For your first task, you have been asked to create a Windows Forms App that will allow users to track the number of points they earned from a given exercise.

The following information will need to be collected from the user:

Username: Take username as a string
Exercise Number: Take exercise ID number as int. Verify that the exercise number is between 1 and 1000 (inclusive).
Exercise Difficulty: Difficulty of exercise completed. Use a combo box to store the different exercise difficulties (see below). Regarding the combo box control, here are some hints for you: Using a combo box will allow us to know the user has selected a valid exercise difficulty, if some value in the box is selected. Combo boxes can be found in the common controls section. To check for a selection, we check that the .SelectedIndex property is 0 or above (like arrays, index here starts at zero). An example is: if (difficultyComboBox.SelectedIndex >= 0). We can retrieve the user’s selected text through the .Text property. The Items property controls what is in the box and is most easily set from the form designer (since it will be static for this program).
Exercise Duration: Time spent on exercise in minutes. Store as an int.
Actual Interview Question: Use radio buttons to determine if the exercise has appeared in actual interviews. Put radio button controls in a Groupbox container.
Regarding the radio button controls: Radio buttons can be found in the toolbox in common controls or by searching. Radio button objects have a .Checked property that might be useful in assessing whether or not a radio button has been checked. Put the radio buttons in a Groupbox, which can be found in the containers section of the toolbox.
Use MessageBox.Show() to indicate that if any of the Textboxes, Combo boxes, Radio buttons are left blank or the value entered in the Textbox for Exercise Number is out of range and to prompt the user to fill them out.
The following are the exercise difficulties along with their point values:
Exercise Difficulty

Easy
100 Points

Medium
200 Points

Hard
300 Points

Very Hard
400 Points

For each minute the user spends on an exercise, there is a 5-point penalty to their score. If the exercise has appeared in actual interviews, there is a 10% bonus. Use a button to calculate the total score and then display the score using an output label. 

Program3.cs:
Commercial Catering Contract Calculator (Windows Forms)

Overview & Business Scenario
Engineered a C# Windows Forms desktop application designed to calculate finalized pricing for enterprise catering contracts. The application processes multi-tiered discounting logic using parallel arrays, dynamic combo box selections, range-matching search algorithms, and input validation routines.

Core Technical Concepts Demonstrated

Parallel Array Processing: Structured synchronized data lookup across separate arrays to manage catering discount rates and baseline business contract pricing.

Range-Matching Algorithms: Developed C# for loop logic to evaluate variable contract lengths (in years) against custom tiered discount brackets.

GUI Component Management: Built an interactive Windows Forms interface utilizing ComboBox controls (SelectedIndex property evaluation) and dynamic message prompts.

Input Validation & Exception Prevention: Implemented int.TryParse logic to ensure numeric integrity for contract duration entries while preventing runtime errors.

Data Structures & Lookup Mapping

Catering Discount Tiers (Parallel Arrays):

Hill Catering Co.: 30% Discount

Food in a Flash: 20% Discount

Sally’s Sandwiches: 12% Discount

Perry’s Pierogis: 5% Discount

Business Baseline Pricing (Parallel Arrays):

John’s Books: $500

Office Supplies: $489

J.B. Car Parts: $412

Gevalia Coffee: $350

Ceylon Tea: $325

My Footwear: $279

Contract Duration Incentives (Range-Matching):

0 to 1 Years: $0 Additional Savings

2 to 4 Years: $30 Additional Savings

5 to 7 Years: $40 Additional Savings

8+ Years: $50 Additional Savings
