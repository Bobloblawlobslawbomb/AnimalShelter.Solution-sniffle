# Animal Shelter API

#### A Brief Description.
_A custom API that could be the basis for an Animal Shelter._ 

### By Giancarlo Vigneri
---
## Technologies Used

>* _VS Code_
>* _C#_
>* _.NET 5 SDK_
>* _ASP.NET_
>* _Entity Framework_
>* _Swagger_

---
## Description 
An API for a theoretical animal shelter database. Which allows the user to enter different animals. The animal objects presently have these properties; Name, Category, Intelligence, Temperment, Friendliness, and Ailment. The also has versioning and Swagger implementation. 

---

## Installation Requirements/Setup

### Requirements:

- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
- [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or [GitBash](https://gitforwindows.org/) to run and interact with the app.

### Further Setup:

> To setup the MySQL database:
>* Carefully follow [these steps from LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to install both __MySQL Server 8.0.19__ and __MySQL Workbench__.
>* Ensure the MySQL server is running by opening Terminal or Windows Powershell and entering the command `mysql -uroot -pepicodus`
>* If you set up MySQL Server with a different username and/or password, the command will be `mysql -u[YourUsername] -p[YourPassword]` (omit the square brackets'[ ]')

#### Importing `giancarlo_vigneri.sql` _(the included database .sql file)_:
> (note: these instructions are only applicable after one has cloned the git repository: "https://github.com/Bobloblawlobslawbomb/AnimalShelter.Solution-sniffle" -- see 'Running the Program' instructions below)
> 1) Open __MySQL Workbench__.
> 2) In the Navigator > Administration window, select Data Import/Restore.
> 3) In Import Options select Import from Self-Contained File.
> 4) Navigate to `giancarlo_vigneri.sql`.
> 5) Under Default Schema to be Imported To, select the New button.
> 6) Enter the name of the database.
>    - In this case: `animal_shelter`.
> 7) Click Ok.
> 8) Click Start Import.
> 9) Reopen the Navigator > Schemas tab. Right click and select Refresh All. _Our new test database will appear._

### Running the Program:
> 1) Clone the repository: "https://github.com/Bobloblawlobslawbomb/AnimalShelter.Solution-sniffle"
> 2) Navigate to the 'AnimalShlter.Solution/' directory on your computer
> 3) Open with your favorite text editor (Visual Studio Code, is a pretty sweet one)
> 4) To run the web app:
>   - Navigate to `FlavorTown.Solution/FlavorTown` in your command line
>   - Run the command `touch appsettings.json`
    - open the newly created "appsettings.json" file
    - add the following code to the .json file:
>   ```
> {
>   "Logging": {
>     "LogLevel": {
>        "Default": "Warning",
>        "System": "Information",
>        "Microsoft": "Information",
>        "Microsoft.Hosting.Lifetime": "Information"
>      }
>    },
> "AllowedHosts": "*",
> "ConnectionStrings": {
> "DefaultConnection": "Server=localhost;Port=3306;database=>> factory;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
>     }
> }
>    ```
   >*_NOTE: make sure that [YOUR USERNAME] and [YOUR PASSWORD] match the database username and password of your local MySQL server (omit the square brackets. Also note: port 3306 is the default)_
> - Run the command `dotnet restore` to restore the dependencies that are listed in `AnimalShelter.csproj`
>  - Run the command `dotnet build` to build the project and its dependencies into a set of binaries.
> - Run the command `dotnet run` to run the project!
> - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the app.

### Using Swagger to explore the program and it's endpoints:
> Once the program is running (via `dotnet run` or `dotnet watch run`) input the following into your browser: `http://localhost:5000/swagger` the programs endpoints will be easily accessible:
> - GET `/api/Animals` -- gets every instance of Animal or searches via properties
> - POST `/api/Animals` -- add an Animals information to the database
> - GET `/api/Animals/{id}` -- gets an Animal via AnimalId
> - PUT `/api/Animals/{id}` -- allows a user to update an Animals properties
> - DELETE `/api/Animals/{id}` -- deletes an Animal by AnimalId

---

## Known Bugs

* _none...Yet_

---

## License [GPL] (https://choosealicense.com/licenses/gpl-3.0/)
_if you do run into any issues or have questions, ideas, or concerns; I would greatly encourage you to send feedback or make a contribution to the code_

---

## Contact Information
_Contact Giancarlo Vigneri at: bobloblaw.vigneri@gmail.com_ 

(If you don't like tacos, I'm nacho type.)