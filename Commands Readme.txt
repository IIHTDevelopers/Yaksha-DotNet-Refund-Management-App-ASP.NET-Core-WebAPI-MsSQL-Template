"For details, please check out attached pdf"

BackEnd-Commands

* On command prompt, cd into your project folder (cd <Your-Project-folder>).

* To connect SQL  server from terminal:
(RefundManagementApp /sqlcmd -S localhost -U sa -P pass@word1)
	-To create database from terminal - 
	1> Create Database RefundManagementAppDb
	2> Go

*	Steps to Apply Migration(Code first approach):
	- Press Ctrl+C to get back to command prompt
	- Run following command to apply migration-
             (RefundManagementAppDb /dotnet-ef database update)


* To check whether migrations are applied from terminal:
(RefundManagementAppDb /sqlcmd -S localhost -U sa -P pass@word1)

	1> Use RefundManagementAppDb
	2> Go
	1> Select * From __EFMigrationsHistory
	2> Go

* To build your project use command:
	(RefundManagementApp /dotnet build)

* To launch your application, Run the following command to run the application:
	(RefundManagementApp /dotnet run)


* To test web-based applications on a browser, use the internal browser in the workspace. Click on the second last option on the left panel of IDE, you can find Browser Preview, where you can launch the application.
	Note: The application will not run in the local browser

* To run the test cases in CMD, Run the following command to test the application:
	(RefundManagement.Tests/dotnet test --logger "console;verbosity=detailed")
	(You can run this command multiple times to identify the test case status,and refactor code  to make maximum test cases passed before final submission)    
         
* Steps to push changes to GitHub:
	- Go to "View" -> "Git Changes" from the top menu bar of Visual Studio.

	- In the "Changes" window on the right side of Visual Studio, you'll see the modified files.

	- Enter any commit message in the "Message" box at the top of the window, and click on “Commit All” button.

	- After committing your changes, Click the "Push" button (Up Arrow Button) to push your committed changes to the GitHub repository.

