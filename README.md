# ToDo:
This might be a cool small exercise to refresh your knowledge of working with razor-pages.
Anyway, this software-design kind of smells, so after finishing the modules, do the following:

-> Add 3 layer-architecture (4 layers / domain-centric architecture might be a bit of an overkill, because this app has just some CRUD operations) 

-> Add containerization and container-orchestration using docker-compose

-> Use a sql-server inside of a docker-container instead of an in-memory db

-> Clean up namespaces and everything that needs to be cleaned up (also rename the projects "tasker" is only the ui-layer, find some good names)

-> You might also want to upgrade the target-framework to .NET 5 and use some of the new language features

# Task Tracking App

### Master Branch

The master branch provides a starting point for the user.  This branch should build and run, and you should be greated with a 404 page in the browser.
There are HTML comments in the main layout file to guide the user for a couple of the steps so they don't have to read through all of the markup to find exact spots.
There are some basic styles applied in site.css so that the required elements will look decent as they work.
This app assumes Visual Studio 2017 with .NET Core 2.2 and higher.

### Solution Branch
The solution branch includes the completed application.  When you run the application it should provide the following features:

- Create tasks in a database
- See validation errors for invalid data
- View the task data in a table on the home page  
- Navigate between the home and create pages
