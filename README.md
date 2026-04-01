# SMITHY MANAGER

* Description
	* Manages a Mining/Smithy company using Windows forms
	* Utilizes timer function to add interest to the manager
	* Uses ADO.Net
	* Uses Package Microsoft.EntityFrameworkCore.SqlServer
	* Uses Package Microsoft.EntityFrameworkCore.Tools
* Language
	* English
	* Programming
		* C#
* Note
	* OOP
	* UI
	* No Tests
	* [Uses Database created by migrations](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)
* Type of Application
	* GUI
	* [Windows Forms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/)
* Author
	* Sam Swagger
	* Created for a class at [MSCS](https://www.southeastmn.edu/Index.aspx)


# Future Plans for this project

* Get the connection string to recognize the .mdf and .ldf files using a relative path (see note below).
* Add taxes to the users profits.
* Make the report page more comprehensive.


# Project Story


# Note
The connection string looks for files *%USERPROFILE%/SmithyManagerDB.mdf* and *%USERPROFILE%/SmithyManager_log.ldf* .  These database files are included under *Mining Company Manager/DB*.