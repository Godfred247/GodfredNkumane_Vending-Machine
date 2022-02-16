# GodfredNkumane_Vending-Machine

I created a simple console app using C#.

Purpose:
The vending machine will allow the user to choose and buy any snack that is available on the machine. If there's change, they will be notified of how much change it would be. Please note that the prices are in cents (c).

Program: 
From the app, the user will be asked to deposit coins into the machine. The only coins allowed are 1c, 2c, 5c, 10c, 20c and 50c. I have a constant cost of 125c (1.25 British pound) (This can be automated by designing a few sets of screens and have an admin who can manage this). The list of available snacks will be displayed to the user and the user will be required to make a selection. When the user is being prompt to make a selection, what's needed is for user to type the keyword, if not, it will display an error to select on what's available on the machine. Once the user selects whats available, a message thanking the user will display. If there's change, they will be alerted of how much the change is.

The program is made up of two classes,namely program.cs and VendingMachine.cs. The vending machine class has quite a number of methods used to calculate, display and cater the users selection. 

The use of input a keyword when selecting a snack: 
The reason behind using a keyword is that I wanted to use a switch statement so that I can run through all the available snacks on the machine and display a text specifically to that selected snack.

Valid coins:
The machine only accepts 1c, 2c, 5c, 10c, 20c and 50c.
