2021-10-27  9:05am
- delete options => options.SignIn.RequireConfirmedAccount = true from  services.AddDefaultIdentity from Startup.cs page
- trying breakpoint and remove them.
-opening https://bootswatch.com/ to download bootstrap ->I've downloaded  Sandstone theme
-change bootsrap.css 
-I commented out   @*<link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />*@ in Views/shared/ _layout.cshtml

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




