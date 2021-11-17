start-> 2021-10-27  9:05am
---------------------------
- delete options => options.SignIn.RequireConfirmedAccount = true from  services.AddDefaultIdentity from Startup.cs page
- trying breakpoint and remove them.

-opening https://bootswatch.com/ to download bootstrap ->I've downloaded  Sandstone theme
-change bootsrap.css 

-I commented out   @*<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />*@ in Views/shared/ _layout.cshtml
---------------------------------------
finish ->  11:30pm   time Taken:2 hours 
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
---------------------------------------
finish ->  1:30pm   time Taken:2 hours 
//////////////////////////////////////////////////////////////////////////////////////////////////////
start -> 2021-11-03 9:37am
--------------------------
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
---------------------------------------
finish ->  1:30pm   time Taken:4 hours 
//////////////////////////////////////////////////////////////////////////////////
start 2021-11-08 12:39pm
---------------------------
-building the application and confirm there are no errors.

-Reviewing tha appsettings.json.

-Create the migrations (using code-first, where changes are “pushed” to the database), modify the database name and save.

-Using the NuGet Package Manager Console to add the migration (with a meaningful name).

-getting error from migration.

-Changing to the correct default project (.DataAccess) and run again.

-migration file name is 20211108175115_AddDefaultIdentituMigration
-----------------------------------
 finish 3:30pm   time Taken:3 hours 
///////////////////////////////////////////////////////////////////////////////
start 2021-11-13 12:00am 
------------------------
Review the AddDefaultIdentityMigration.cs file for the SQL-like syntax, statements, columns and primary key constraints, tables related the ASP.NET Identity.

Once the migration is complete, the database needs to be updated. In the PM console, update the database now.

Review the updated database in the SQL Server Object Explorer. Check for errors, run the application. push commits to GitHub.

Add a new table to the DB by creating a Category model and push it to the DB: Add a new class file to the .Models project and modify it.

add-migration AddCategoryToDb via the PM Console- , The new migration file will be empty because it hasn’t been added to the Application DB Context

Update this and note the added using statement, re-run the add-migration, but i get error that The name 'AddCategoryToDb' is used by an existing migration, so i deleted already existed and 
and add that migration again, review the changes to the AddCategoryToDb (resolve the duplication error that will occur).

Update the database, confirm the new Categories table via the SQL SOE and push commits to GitHub.
-------------------------------------
 finish 3:30pm   time Taken:3:30 hours 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

start 2021-11-14 1:00pm 
------------------------
- Start Part 2.2 - Repository 

-After creating the Category.cs and adding it to the ApplicationDbContext it’s time to implement the Repository, a generic way of accessing common functionality, in the .DataAccess project.

-Add a new folder name it Repository and add an IRepository folder inside it. Add a new item of type interface to the folder and name it IRepository.cs 

-Modify so it can be used on the Category class to do all the CRUD operations by adding using statements.

-Methods to use for CRUD: Get item from the DB, List of Categories, Add objects, Remove objects

-Implement the class that implements the repository, add Repository.cs class in Repository folder.

-Include the using statement, View the potential fixes and implement interface, Modify the code to create the constructors and dependency injection (DI).

-Create individual repos for category and all potential models to be added in the future, CategoryRepository.cs
and ICategoryRepository.cs.

-Modify CategoryRepository (note the using statements and the message for formal parameters – review in Repository.cs the method pointing to the ApplicationDBContext)

-Modify ICategoryRepository interface, Review and modify the error now in CategoryRepository.cs (implement the interface to update), Complete the remaining modifications.

-Build, fix any error and push commits to GitHub.

-Implement a stored procedure repository and map multiple repositories in a Unit of Work

-Add a new interface in the IRepository folder - ISP_Call.cs – that extends IDisposable, Include the methods shown and install the NuGet package for Dapper. Now implement this with a new class in the Repository folder.

-Add a new class (SP_Call.cs) in the Repository folder, select the appropriate using statement and implement the ISP_Call interface

-Add a connection to the database, note the additional using statements, Update the implementation of the ISP_Call interface, Now add the wrapper for Unit of Work.

-Add a new interface (IUnitOfWork) to the IRepository folder and update the code.

-Now implement this inside the UnitOfWork, Modify the code (make sure the public class implements the interface -  UnitOfWork : IUnitOfWork)

-To make it accessible by the project, register it Startup.cs in the ConfigureServices method, add using statement.

-try to build but i get error in startup page,
2111100948 - error - Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0311	The type 'JamilaBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, 
TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 'JamilaBooks.DataAccess.Repository.UnitOfWork' to 'JamilaBooks.DataAccess.Repository.IRepository.IUnitOfWork'.
JamilaBookStore	C:\Users\W0759725\Source\Repos\JamilaBookStore\JamilaBookStore\Startup.cs	39	Active

so i just comment out the statement that throw an error and i push commits to GitHub.

-------------------------------------
 finish 3:30pm   time Taken:2:30 hours 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
start 2021-11-15 1:15pm 
------------------------
-Start part -  2.3 Category CRUD

-Add a new MVC Controller - Empty inside Areas/Admin, Name it CategoryController.cs

-Modify the code to use the IUnitOfWork from the .DataAccess project and the IRepository folder by asdding using statement.

-Add a new folder in the Areas/View with the same name as the Controller.

-Add a new ‘Index’ view to the folder and modify with the generic HTML code from the Category Index View.txt file found in the Assignment 2 - Files folder 
-Save and run the application

-In _Layout.cshtml, move the ‘Category’ link to the Content Management drop-down. Review the changes to the navigation, Push to GitHub.

-Modify the Index.cshtml to add the icons in the Category section from Font Awesome and confirm.

-Delete it and add the JavaScript from the Assignment 2 files folder in to the wwwroot/js folder, note the ‘div’ is now in the return portion of the category.js file

-In Index.cshtml add the @section call to the category.js script and run the project.

-when i try to run the project and click on category i get this error:

-An unhandled exception occurred while processing the request.
InvalidOperationException: Unable to resolve service for type 'JamilaBooks.DataAccess.Repository.IRepository.IUnitOfWork'
while attempting to activate 'JamilaBookStore.Areas.Admin.Controllers.CategoryController'.
-------------------------------------
 finish 3:30pm   time Taken:2:15 hours 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

start->  2021-11-16 10:30am
------------------------

-Time to apply the code to activate the ‘Edit’ and ‘Delete’ buttons and ‘Create New Category’ using the Upsert action

-Add the IAction result to the controller and add a View, Copy and add the html from the Category Upsert View.txt

-Create a partial view for the EDIT | BACK. In the general Views > Shared folder, add the partial view for _CreateAndBackToListButton.cshtml and add the asp-action.
-Create another parital view for _EditAndBackToListButton and note the code addition of the @model razor statement

-Modify the Upsert.cshtml, Add the asp-action to the Index.cshtml page and run the application, Navigate to Category > Create New Category.

-Modify Upsert.cshtml so TITLE now uses the @title variable and refresh the application. Add the @section call to Scripts to validate input on the client-side and test.

-Now create an Upsert POST action method in the CategoryController.cs, Note the Save method is not available, now add the void Save() method to the IUnitOfWork interface.

-Remove the _db.SaveChanges() method in the CategoryRepository.cs and move the _unitOfWork.Save() method with the return RedirectToaction method.

-Check for errors and test whether the application can update and create a category. Add the API call for HTTPDelete in the CategoryController.cs

-Then implement the HTTPDelete with a delete method in category.js to add functionality to the application and call the API.

-Add the delete functionality in category.js with including the onclick event to the Delete function, Add the Delete(url) function code.

-I look over in power point again and verified my code, I get error in startup page i get it correct by modifying unitOfWork.cs page,
i add ': IUnitOfWork' this in public class defination. Now i can see category when i run my project.

-------------------------------------
 finish 1:30pm   time Taken:3 hours 
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////









