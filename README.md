# Important
This Project is CRUD MVC with Web Api Client implement and OPENAPI specification respected with Suswashbuckle nuget package.

# About
I created this project to participate in a selection for an important Italian Publishing House that is recruiting developers to create an internal development group.

# Setup
To use this solution, you will need knowledge of .cs, .cshtml, and AlertifyJS and Swagger UI.

Follow this links for the documentation and API:
https://alertifyjs.com/confirm.html 
https://swagger.io/tools/swagger-ui/ 

# References
For this Solution you need to: 
set your http://localhost:xxxxx as your system required in GlobalVariables.cs
        (You’ll find it with right click on MVCApplicationTest/Properties/Web)
follow the instructions to let Swagger run easely
        (When you’ll run the Solution you have to add “/Swagger”at the 
        Url”http://localhost:xxxxx” in your Browser)

# Run the Solution
To run this Solution, follow these steps:
Download or Clone this Solution
Open your MSSMS and create a DB named “CRUDDB”
Open the folder that you have downloaded and execute the Query to create a  new table
Build the Solution
Run the Solution

# Use it
At the Index page the app will show you the list of Users (at first empty), if you want to add User you have to click on plus, on the upper right corner. This will send you to the page “AddOrEdit”, fill in the fields and Submit.
Now you can see your first User added in the page List and, if you want, you can Edit or Delete this.
If you want to Edit Users you will have to click the ‘pencil’ button at the right of the record and go to the page “AddOrEdit”.
If you want to Delete Users you just click the ‘trash’ button at the right of the record. This will open a confirm dialog window that will ask you to take a decision.

# Compatibility
This Solution has only been tested using ASP.Net Framework 4.6.1 using Visual Studio 2017 and the DB using MSSMS.

# Known Issues
Sometimes Visual Studio has problems with the dependencies through different versions of the Framework. In that case I recommend installing the latest and most stable version of the Framework using NuGet.

# License
You are free to use this code in any solution you desire, but a brief mentioning would be nice.


