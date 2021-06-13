# Pierre's Flavor Town Portal

#### A Brief Description.
_An MVC 'many-to-many'/Authentication with Identity example project._ 

### By Giancarlo Vigneri
---
## Technologies Used

>* _VS Code_
>* _Html_
>* _CSS_
>* _C#_
>* _.NET 5 SDK_
>* _ASP.NET_
>* _Entity Framework_
>* _Bootstrap_
>* _Identity_

---
## Description 
The program will allow someone to create an account for Pierre's Flavor Town (geez I hope that's copyrighted). The user can then access the rest of the site which allows said user to create 'Treats' (ex. donuts, maple bars, crullers, etc.), and 'Flavors' (sweet, savory, bitter, nasty). The user can then associate each object with as many of the other type as they see fit.

---

## Installation Requirements/Setup

### Requirements:

- [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
- [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or [GitBash](https://gitforwindows.org/) to run and interact with the console app.

### Further Setup:

> To setup the MySQL database:
>* Carefully follow [these steps from LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) to install both __MySQL Server 8.0.19__ and __MySQL Workbench__.
>* Ensure the MySQL server is running by opening Terminal or Windows Powershell and entering the command `mysql -uroot -pepicodus`
>* If you set up MySQL Server with a different username and/or password, the command will be `mysql -u[YourUsername] -p[YourPassword]` (omit the square brackets'[ ]')

#### Importing `giancarlo_vigneri.sql` _(the included database .sql file)_:
> (note: these instructions are only applicable after one has cloned the git repository: "https://github.com/Bobloblawlobslawbomb/FlavorTown.Solution-silver" -- see 'Running the Program' instructions below)
> 1) Open __MySQL Workbench__.
> 2) In the Navigator > Administration window, select Data Import/Restore.
> 3) In Import Options select Import from Self-Contained File.
> 4) Navigate to `giancarlo_vigneri.sql`.
> 5) Under Default Schema to be Imported To, select the New button.
> 6) Enter the name of the database.
>    - In this case: `flavor_town`.
> 7) Click Ok.
> 8) Click Start Import.
> 9) Reopen the Navigator > Schemas tab. Right click and select Refresh All. _Our new test database will appear._

### Running the Program:
> 1) Clone the repository: "https://github.com/Bobloblawlobslawbomb/FlavorTown.Solution-silver"
> 2) Navigate to the 'FlavorTown.Solution/' directory on your computer
> 3) Open with your favorite text editor (Visual Studio Code, is a pretty sweet one)
> 4) To run the web app:
>   - Navigate to `FlavorTown.Solution/FlavorTown` in your command line
>   - Run the command `touch appsettings.json`
    - open the newly created "appsettings.json" file
    - add the following code to the .json file:
>   ```
>   {
>       "ConnectionStrings": {
>       "DefaultConnection": "Server=localhost;Port=3306;database=>> factory;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
>       }
>    }
>    ```
   >*_NOTE: make sure that [YOUR USERNAME] and [YOUR PASSWORD] match the database username and password of your local MySQL server (omit the square brackets. Also note: port 3306 is the default)_
> - Run the command `dotnet restore` to restore the dependencies that are listed in `FlavorTown.csproj`
>  - Run the command `dotnet build` to build the project and its dependencies into a set of binaries.
> - Finally, run the command `dotnet run` to run the project!
> - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app.

## Known Bugs

* _none...Yet_

#### Background Image
> Photo by: [Braden Collum](https://images.unsplash.com/photo-1620095198790-2f663d67677d?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80)
> Via: [Unsplash](https://unsplash.com/)
---

## License [GPL] (https://choosealicense.com/licenses/gpl-3.0/)
_if you do run into any issues or have questions, ideas, or concerns; I would greatly encourage you to send feedback or make a contribution to the code_

---

## Contact Information
_Contact Giancarlo Vigneri at: bobloblaw.vigneri@gmail.com_ 

(A person walks into a bar and asks for helicopter flavored chips. The bartender says, "Sorry. We only have plain.")