2021-10-27  9:05am
- delete options => options.SignIn.RequireConfirmedAccount = true from  services.AddDefaultIdentity from Startup.cs page
- trying breakpoint and remove them.

-opening https://bootswatch.com/ to download bootstrap ->I've downloaded  Sandstone theme
-change bootsrap.css 

-I commented out   @*<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />*@ in Views/shared/ _layout.cshtml

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
2021-11-01 11:27am
- Change the nav class from navbar-light to navbar dark and bg-white to bg-primary in _Layout.cshtml.

-in Line 23 and line 26 in _Layout.cshtml - remove text-dark

- in _LoginPrtial.cshtml remove text-dak from line 13-9-20-23.

-in _layout.cshtml I added (text-white-50 bg-primary) classes to the footer.

-I added to the _Layout.cshtml page the additional stylesheets and scripts from the CSS_JS.txt file that provided in blackboard.

- Views/shared/_Layout.cshtml, I added a dropdown to the nav bar the change the dropdown to content managment.

-I Added three (3) new projects (.NET Core class library) to the application:
																			JamilaBooks.DataAccess
																			JamilaBooks.Models
																			JamilaBooks.Utility

- I coppied Data folder and paste it to .DataAccess Project.

- I Install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages.

- I deleted the migration folder from data.

- I Install NuGet package:Identity.EntityFrameworkCore.

-I Modified the namespace to reflect the project

-I Deleted default Class1.cs file in all projects

-tring to Build the project and got 3 errors.

-Moving Models in to JamilaBooks.Models and deleting original.

-I Modified  Views > Shared >  Error.cshtml

-Project - Add - Project Reference - .DataAccess and .Models

-I Renamed Models folder to ViewModels

-IChanged the ErrorViewModels.cs namespace .Models.ViewModels

-Building Project again.

-Modifying Startup.cs service ‘AddContext’ with the using statement

-Runing the application and review errors.

-Remove the using statement

-Correctinj any default reference to ErrorViewModel to the new .Models.ViewModels.ErrorViewModels

-When all errors are resolved run the application and review the browser presentation.
//////////////////////////////////////////////////////////////////////////////////////////////////////
2021-11-03 9:37am
-In the Utility project, I create a static details class called SD.cs

-I Modified the properties of the class

-I Added project reference to the main project

- In the DataAccess project add project references t o Models and Utility

-I Added a ‘Customers’ area to Areas

-I Changed the routes in Startup.cs like the one outlined in the ScaffoldingReadMe.txt

- Moving the HomeController.cs to the Area > Customer > Controller folder and delete Data and Models.

-Editing the HomeController.cs to explicitly define that the controller is in the Customer Area

-Moving Views > Home and modify the HomeController namespace

-Copying _ViewImport and _ViewStart to Customer Area

-Modifying the _ViewStart.cshtml to reflect the new path.

-Add a new Admin area in Areas

-Add the proper view files and delete the Data and Models folder

-Delete the Controllers folder

-Update the GitHub repo

- got an error in startup file and did solve it .

//////////////////////////////////////////////////////////////////////////////////
2021-11-08 12:39pm
-building the application and confirm there are no errors.

-Reviewing tha appsettings.json.

-Create the migrations (using code-first, where changes are “pushed” to the database), modify the database name and save.

-Using the NuGet Package Manager Console to add the migration (with a meaningful name).

-getting error from migration.

-Changing to the correct default project (.DataAccess) and run again.

-migration file name is 20211108175115_AddDefaultIdentituMigration












