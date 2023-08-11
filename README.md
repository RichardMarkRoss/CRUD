#CRUD
This guide will walk you through setting up and running the CRUD API. Please follow these steps for a seamless experience:

##Prerequisites
Make sure you have Visual Studio 2022 installed on your device.
Ensure that Microsoft SQL Server (mssql) is set up and running on your machine.

##Getting Started
Open Visual Studio 2022.
Click on "Tools" in the top menu, then select "NuGet Package Manager" > "NuGet Package Console."

In the Package Console, execute the following commands:
Add-Migration Init
Update-Database

These commands will prepare the database for the CRUD API.

##Continuing with the React Project
Now, let's integrate the CRUD API with your React project. Follow these steps:

Ensure you have your React project ready to go.
In your React project, navigate to the action.js file.
Locate the URL where you're making API calls. It should look like: https://localhost:7204/api/Products.
Make sure the port 7204 is correctly specified in the URL. This is crucial for connecting to the API correctly.
By following these steps, you should now have the CRUD API set up and integrated into your React project. If you encounter any issues, feel free to refer back to this guide or seek further assistance.

Happy coding! 