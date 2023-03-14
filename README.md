
# Eau Claire's Salon

---
#### By Ambi Hidalgo
###### ambio.pk@gmail.com
---

####  Hair Slon
Utilizing MySql Eau Claire's is a stylist/client organizer demonstrating one-to-many database relationships. Through MVC, ASP .Net Core and Entity Framework core the webapge is able to provide Eau Claire with the organization she needs. Clients can be added to stylists, but clients may only have one stylist.
## Technologies Used
* C#
* EFC
* Pomelo
* MySql
* Razor
* .NET SDK
* ASPNET Core MVC


## Setup/Installation Requirements
Note: In order for this application to work you will need to create called appsettings.JSON in the root directory as well as a Properties/launchSettings.Json.
* Clone this repository (https://github.com/ambibma/HairSalon)
* using terminal to navigate to the program file (OrderTracker.Solution)
     ```bash
    $ cd HairSalon
    ```
* Once in the Program directory
  ```bash
    $ dotnet restore
    ```
* Create appsettings.json
    ```bash
    $ touch appseetings.json
    ```
* Paste the following code and enter your mysql username and password
    ```JSON
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=ambi_hidalgo;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
     }
    }
    ```
* Once that is finished...
   ```bash
   $ mkdir properties
   $ touch properties/launchSettings.JSON
   ```
* Paste the following code...
    ```JSON
    {
        "profiles": {
        "development": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:5001;http://localhost:5000",
        "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
         }
        },
        "production": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:5001;http://localhost:5000",
        "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Production"
                }
            }
        }
    }
    ```
* Then the program is ready for a build and run!
    
    ```bash
    $ dotnet build
    ```

     ```bash
    $ dotnet watch run
    ```
* This Will open the application in your web browser! Now you are ready to run your own salon!

## Known Bugs

* None at the moment
send bug concerns to ambio.pk@gmail.com

## License


Copyright (c) Ambi Hidalgo 2023