# <p style="color:#0ec2b8" align="center">_BORD_</p>

<p align="center">
    <!-- Project Avatar -->
    <br>
    <!-- <a href="https://github.com/NataliyaZhuravleva">
        <img src="https://avatars.githubusercontent.com/u/26223609?s=400&u=eba3685b0fa16a0c66c8dec64c2cd7886929b509&v=4">
    </a>
    <!-- GitHub Link -->
   <p align="center">
        <a href="https://github.com/NataliyaZhuravleva" style="color: #0ec2b8;">Nataliya Zhuravleva</a>
    </p>
    <!-- LinkedIn -->
    <p align="center">
        <a href="mailto:natalindria@gmail.com">
            <img src="https://img.shields.io/badge/Email-00AAAB??style=social&logo=gmail&labelColor=00AAAB">
        </a>  
        <a href="https://www.linkedin.com/in/nataliya-zhuravleva/">
            <img src="https://img.shields.io/badge/LinkedIn-00AAAB??style=social&logo=linkedin&labelColor=00AAAB">
        </a>      
    </p>    
</p>
<p align="center">
  <small>Initiated January 22th, 2021</small>
</p>

<!-- ## <span style="color:#0ec2b8">Table of Contents</span>
* <a href="#about">About the project</a>
  * <a href="#description">Description</a>
  * <a href="#used">Technologies Used</a>
  * <a href="#bugs">Known Bugs</a>
* <a href="#install">Installation Requirements</a>
  * <a href="#required">Required Technologies</a>
  * <a href="#dotnet">.NET Installation</a>
    * <a href="#dotnetMac">Mac</a>
    * <a href="#dotnetWindows">Windows</a>
  * <a href="#mysql">MySQL Installation</a>
    * <a href="#mysqlMac">Mac</a>
    * <a href="#mysqlWindows">Windows</a>    
  * <a href="#postman">Postman Installation (optional)</a>
  * <a href="#packages">Packages To Install</a>
* <a href="#setup">Setup and Use</a>
  * <a href="#cloning">Cloning the project</a>
  * <a href="#download">Downloading the project</a>
  * <a href="#packages">App Settings</a>
  * <a href="#importDBEntity">Import Database Structure with Entity Framework Core</a>
  * <a href="#importDBWorkbench">Import Database Structure with MySQL Workbench</a>
  * <a href="#running">Running Program</a>
     * <a href="#runApp">Run Application</a>
     * <a href="#launchAPI">Launch the API</a>  
* <a href="#apiDoc">API Documentation</a>
  * <a href="#endPoints">End Points</a>
     * <a href="#request">HTTP Request Structure</a>
     * <a href="#query">Example Query</a>
     * <a href="#queryParam">Examples of queries with parameters for Get Requests</a>
     * <a href="#jsonResponse">Sample JSON Response</a>  
  * <a href="#swagger">How to use Swagger</a>

* <a href="#contact">Support and contact details</a>

* <a href="#license">License</a>



## <span style="color:#0ec2b8" id="about">About the Project</span>
### <span style="color:#0ec2b8" id="description">Description</span>

_The API that functions as a archive for the state and national parks to help visitors to be familiar with the type of park (national or state), wether pets allowed there or not, and if park has a store. This application is built utilizing C# ASP.NET Core, its ORM Entity, MySQL Database (and Workbench), RESTful principles and Swagger. The user is able to see the in-use version of the API when using Postman/Swagger._  

### <span style="color:#0ec2b8" id="used">Technologies Used</span>

* _C#_
* _.NET_
* _MySQL_
* _MySQL Workbench_
* _Postman_
* _Swagger_
* _VisualStudio Code_
* _Git_
* _GitHub_

### <span style="color:#0ec2b8" id="bugs">Known Bugs</span>

_Sometimes `random` gives an empty record (when query with at least two parameters). Works appropriately with `?random=true` only parameter._

## <span style="color:#0ec2b8" id="install">Installation Requirements</span>

### <span style="color:#0ec2b8" id="required">Required Technologies (see install instructions below)</span>
* _C# .NET Core Ver 2.2.0_
* _MySQL Ver 8.0.15 & MySQL Workbench_
* _Swagger Ver 13.10.1_
* _Modern Web Broswer_
* _Text Editor (e.g.VisualStudio Code)_

### <span style="color:#0ec2b8" id="dotnet">.NET Installation</span> 

#### <span style="color:#c4f4ef" id="dotnetMac">Mac</span> 

1. _Download this [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) . Clicking this link will prompt a `.pkg file` download from `Microsoft`._
2. _Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests._ 
3. _Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`. You should see something like this in response: `2.2.105. This means both .NET and C# are successfully installed`._

#### <span style="color:#c4f4ef" id = "dotnetWindows">Windows</span> 
Note on Windows Versions
These Windows instructions assume you're using Windows 10. If you currently run Windows 7 or Windows 8, you may have a free upgrade available.
If you are not running Windows 10 (and cannot or do not plan to upgrade), specific installation steps may differ. 
#### Installation Steps:
1. _Download either the the 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft._
2. _Open the file and follow the steps provided by the installer for your OS._
3. _Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `version numbers do not need to be the same: 2.2.105`_<br>
_This means .NET and C# are installed and your computer recognizes the dotnet command._

### <span style="color:#0ec2b8" id="mysql">MySQL Installation</span>
#### <span style="color:#c4f4ef" id="mysqlMac">Mac</span> 
1. _Download the MySQL Community Server `.dmg file` from the [MySQL Community Server page](https://dev.mysql.com/downloads/file/?id=484914). Click the `download` icon. Use the `No thanks, just start my download link.`_
2. _Follow along with the Installer until you reach the `Configuration` page. Once you've reached `Configuration`, select or set the following options (use default if not specified):_
    * _Use `Legacy Password Encryption`._
    * _Set password to `epicodus`._
    * _Click `Finish`._
    * _Open the terminal and enter the command echo `'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`. This will save this path in `.bash_profile`, which is where our terminal is configured._
    * _Type in source `~/.bash_profile` (or restart the terminal) in order to actually verify that MySQL was installed._
3. _Verify MySQL installation by opening terminal and entering the command `mysql -uroot -pepicodus`. You'll know it's working and connected if you gain access and see the MySQL command line. If it's not working, you'll likely get a `-bash: mysql: command not found error`._
4. _You can exit the mysql program by entering `exit`._
5. _Download the MySQL Workbench `.dmg file` from the [MySQL Workbench page](https://dev.mysql.com/downloads/file/?id=484391). Use the `No thanks, just start my download link`._
6. _Install `MySQL Workbench` to Applications folder._
7. _Open `MySQL Workbench` and select the `Local instance 3306 server`. You will need to enter the password `epicodus`. If it connects, you're all set._

#### <span style="color:#c4f4ef" id="mysqlWindows">Windows</span> 
1. _Download the `MySQL Web Installer` from the [MySQL Downloads page](https://dev.mysql.com/downloads/file/?id=484919). Use the `No thanks, just start my download link`._
2. _Follow along with the installer:
    * _Click `Yes` if prompted to update._
    * _Accept license terms._
    * _Choose `Custom setup` type._
    * _When prompted to `Select Products and Features`, choose the following:_
        * _MySQL Server 8.0.19 (This will be under `MySQL Servers > MySQL Server > MySQL Server 8.0`)_
        * _MySQL Workbench 8.0.19 (This will be under `Applications > MySQL Workbench > MySQL Workbench 8.0`)_
    * _Select `Next`, then `Execute`. Wait for download and installation. (This can take a few minutes.)_
    * _Advance through Configuration as follows:_
        * _High Availability set to `Standalone`._
        * _Defaults are OK under Type and Networking._
        * _`Authentication Method set` to Use Legacy Authentication Method._
        * _Set password to `epicodus`._
        * _Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options `Configure MySQL Server as a Windows Service` and `Start the MySQL Server at System Startup`. Under Run Windows Service as..., the `Standard System Account` should be selected._
    * _Complete Installation process._
3. _Add the MySQL environment variable to the System PATH. You must include MySQL in the System Environment Path Variable. This is its own multi-step process:_
    * _Open the Control Panel and visit System and `Security > System`. Select `Change Settings` and a pop-up window will display. Select the tab `Advanced` and select the `Environment Variables` button._
    * _Within the System Variables navigator window, select PATH..., click `Edit...`, and then `New`._
    * _Add the exact location of your MySQL installation, and click OK. (This location is likely `C:\Program Files\MySQL\MySQL Server 8.0\bin`, but may differ depending on your specific installation.)_
4. _Verify installation by opening Windows PowerShell and entering the command `mysql -uroot -pepicodus`. You'll know it's working and connected if you gain access and see MySQL's command line. You can exit the mysql program by entering exit._
5. _Open MySQL Workbench and select the `Local instance 3306 server` (it may have a different name). You will need to enter the password `epicodus`. If it connects, you're all set._

### <span style="color:#0ec2b8" id="postman">Postman Installation (optional)</span>
Download and install `Postman` from the [Postman page](https://www.postman.com/downloads/).

### <span style="color:#0ec2b8" id="packages">Packages To Install:</span>
_In the command line run the following commands to install packages:
1. _$ `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`_
2. _$ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`_
2. _$ `dotnet add package NSwag.AspNetCore --version 13.10.1`_

## <span style="color:#0ec2b8" id="setup">Setup and Use</span>
### <span style="color:#0ec2b8" id="cloning">Cloning the project</span>
1. _Navigate to my [ParksLookup.Solution repo](https://github.com/NataliyaZhuravleva/ParksLookup.Solution) at https://github.com/NataliyaZhuravleva/ParksLookup.Solution_ to view the project files and commits.
2. _Click on the green button labeled `Code`_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command `git clone https://github.com/NataliyaZhuravleva/ParksLookup.Solution`.
4. _Navigate to the folder `/ParksLookup/` to see coding._
6. _To use this application you will need to install .NET. Please, see instructions below._

### <span style="color:#0ec2b8" id="download">Downloading the project</span>
1. _Navigate to my [ParksLookup.Solution repo](https://github.com/NataliyaZhuravleva/ParksLookup.Solution) at https://github.com/NataliyaZhuravleva/ParksLookup.Solution_ to view the project files and commits.
2. _Click on the green button labeled `Code`_ to copy repository URL.
3. _Clone the repository to your local machine_ by opening your machine terminal and using the command `git clone https://github.com/NataliyaZhuravleva/ParksLookup.Solution`.

### <span style="color:#0ec2b8" id="appSettings">App Settings</span>
1. _Open in the `/ParksLookup/` directory the file named `appsettings.json`_
2. _Change the server, port, and user id as necessary. Replace `YourPassword` with relevant MySQL password (set at installation of MySQL)._
```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nataliya_zhuravleva_parkslookup;uid=root;pwd=YourPassword;"
  }
}
```

### <span style="color:#0ec2b8" id="importDBEntity">Import Database Structure with Entity Framework Core</span>
1. _Navigate to the `ParksLookup` directory in your terminal._
2. _Run the command `dotnet ef database update` which will use the mirgrations folder to create the MySQL Database using Entity Framework Core._
3. _(_OPTIONAL_) If you need to make adjustments to the database, use the command `dotnet ef migrations add <NameOfNewMigration>` and then run `dotnet ef database update` again to apply the changes._

### <span style="color:#0ec2b8" id="importDBWorkbench">Import Database Structure with MySQL Workbench</span>
1. _Open MySQL Workbench and enter your password._
2. _Go to the nav bar at the top, click on `Server > Data Import`._
3. _Use the the option `Import from Self-Contained File`._
4. _Set the Default Target Schema or create a new schema._
5. _Select all Schema Objects you wish to import._
6. _At the bottom, ensure the option Dump Structure and Data is selected._
7. _Click `Start Import`._

### <span style="color:#0ec2b8" id="running">Running Program</span> 
#### <span style="color:#c4f4ef" id="runApp">Run Application</span>

1. _Use `nataliya_zhuravleva_parkslookup.sql` file to access database_ 
2. _Navigate to the `/ParksLookup/` folder in the command line._
3.  _Run the following command: $ `dotnet restore`_
4. _Run the following command: $ `dotnet build`_
5. _Run the following command to execute this compiled code: $ `dotnet run`_

#### <span style="color:#c4f4ef" id="launchAPI">Launch the API</span>
1. _Navigate to `ParksLookup.Solution/ParksLookup` directory using the MacOS Terminal (e.g. cd Desktop/ParksLookup.Solution/ParksLookup)._
2. _Run the command `dotnet run` to have access to the API in Postman or browser._
3. _If you use browser, open the [Swagger UI](http://localhost:5000/swagger/index.html#/Parks) to view and test the different routes of this API!


## <span style="color:#0ec2b8" id="apiDoc">API Documentation</span>

### <span style="color:#0ec2b8" id="endPoints">End Points</span>
Explore the API endpoints in Postman.
Base URL: https://localhost:5000
#### <span style="color:#c4f4ef" id="request">HTTP Request Structure</span>
```
- GET /api/parks
- POST /api/parks
- GET /api/parks/{id}
- PUT /api/parks/{id}
- DELETE /api/parks/{id}
```
#### <span style="color:#c4f4ef" id="query">Example Query</span>

```
http://localhost:5000/api/Parks/2
```

#### <span style="color:#c4f4ef" id="queryParam">Examples of queries with parameters for Get Requests</span>

```
To get random park: http://localhost:5000/api/parks/?random=true
To search park by parkName http://localhost:5000/api/parks/?search=Lake Sammamish
To get state parks only: http://localhost:5000/api/parks/?parkType=State
To get parks where pets are allowed: http://localhost:5000/api/parks/?parkPetsAllowed=true
To get national parks where pets are allowed: http://localhost:5000/api/parks/?parkPetsAllowed=true&parkType=national
```

#### <span style="color:#c4f4ef" id="jsonResponse">Sample JSON Response</span>


```
{
    "parkId": 1,
    "parkName": "Mount Rainier",
    "parkType": "National",
    "parkAddress": "55210 238th Avenue East Ashford, WA 98304",
    "parkPetsAllowed": false,
    "parkStore": true
}
```

### <span style="color:#0ec2b8" id="swagger">How to use Swagger</span>
Here is an example how to use Swagger.
Open URL: http://localhost:5000/swagger/index.html#/Parks

1. Click `Parks`
2. Click type of request, e.g. `Get`
3. Click `Try it out`

[![Image from Gyazo](https://i.gyazo.com/93525b648068768b6c4933805d1ee374.gif)](https://gyazo.com/93525b648068768b6c4933805d1ee374)

4. Choose property name to make a query (e.g. `parkType`) and type nearby what you want to search (e.g.`State`)
5. Click `Execute`
6. Scroll Down and Enjoy of your response.

[![Image from Gyazo](https://i.gyazo.com/746d812e63799aefb380ac02190610e9.gif)](https://gyazo.com/746d812e63799aefb380ac02190610e9)
#### NOTICE: If you want to get random park, please, mark `random` field as `true`.


## <span style="color:#0ec2b8" id="contact">Support and contact details</span>

_If you have any questions, ideas or concerns, please, contact me at [natalindria@gmail.com](mailto:natalindria@gmail.com)_






## <span style="color:#0ec2b8" id="license">License</span> 

*This software is licensed under the [MIT](https://choosealicense.com/licenses/mit/) license*

Copyright (c) 2020 **_Nataliya Zhuravleva_**  -->
### Games POST or PUT 
```{
    "gameName": "Test",
    "gamePrice": 0.00,
    "minPlayers": {int},
    "maxPlayers": {int},
    "creators": {string},
    "minAge": {int},
    "playTimeMin": {int},
    "genres": [{"genreId":5}],
    "reviews": []
}
```