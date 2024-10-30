I have used SQL server as the database:
1. Please extract the project files to a folder where the application will have access to run. On my machine my project file is at C:\Projects\GadgetCompany
 
2. Please open the solution in Visual studio
3. Please open the appsettings.json file and add your sql server name instead of localhost in below connection string:

"DefaultConnection": "data source=localhost;initial catalog=Gadget;Trusted_Connection=True;TrustServerCertificate=True"

4. Please Go to Tools Menu and select Package Manager Console. Please type the below commands into package manager console, one at a time.

- Type: add-migration "CreateDB"
- Type: update-database

This should create the database Gadget on your local SQL server and put some dummy data in the tables.

You should be able to run the application now. Please let me know if there are any problems and I can help in any way.

PLEASE REVIEW DOCUMENTS IN THE 'DOCUMENTS - PLEASE READ' FOLDER FOR MY NOTES ON THE ASSIGNMENT.