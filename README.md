# MyHomeAssignment.AbraRepo


Usage:

a. start Loans.API
   endpoint is http://localhost:5070/api/Loan

b. start react app
   MyHomeAssignments\loans.ui.react.app>npm start
   opens  http://localhost:3000

Feaures:

Note: 

a. For now, anyone can access the API

b. using async, returning all details to client


Potponed: 

a. read prime and monthly intrest from config

c. add logging to BL 

d. repo reading from db or json files






Requirement

https://github.com/MalkaGit/MyHomeAssignment.AbraRepo.git

Home assignment:

Dear candidate, thank you for your time in taking this home assignment as part of your evaluation.
The purpose of this exam is to assess your coding and design abilities, emphasis on scalability and knowledge in OOD and OOP principles rather than a fully working API.
The assignment should take about 2-3 hours.

Instructions

Server Side:


In the following exercise you will build a simple web API system.
The purpose of the system is to offer each client a specific loan interests based on the following scenarios:
If the client is below the age of 20 the interest of the loan should be 2% + prime interest.
If the client is between 20-35, use the following division to calculate the loan:
5,000 nis and below 2% fixed
5,000 – 30,000 nis 1.5% + prime
Above 30,000 nis 1% + prime
If the client is above 35, use the following division:
15,000 nis and below 1.5% + prime
5,000 – 30,000 nis 3% + prime
Above 30,000 nis 1% fixed
The minimum loan period is 12 months, you are also required to add 0.15% for each extra month 
above the minimum period.

For example, a client at the age of 21 requests a loan of 4,500 nis for a period of 13 months.
His basic loan interest is 2% = 90 nis and for the extra month 1*0.15 % = 6.75 nis, so the total amount is 4,596.75 nis.

The system will contain at least one user for each scenario, and an endpoint that receives the client id, amount in nis and period in month. The output should be the total amount at the end of the period. If you like and have the time you can add the amount calculated divided by each calculation depending on the scenario. 


Client side:

Create a single page project using React\Angular (4+)\Vue.
The page will contain input fields for user id, loan amount, loan period and a button for loan suggestion.
Once the user clicked on the button, it will call the endpoint you developed on server side in the previous step and display the loan details in a popup or inside a styled div.
Field Validation is required.


Guidelines:
Please use proper design patterns where they are needed (Repository, Strategy, Factory)
You can use Json or xml as your data source (you will not be tested on this)
The project must be C# .net Web API preferably .net core latest.
Make sure you write clean and scalable code.
You don’t have to use async, but it is recommended.
Prime interest for this exercise is 1.5%
Make sure client-side code is clean and scalable.

Good luck!
