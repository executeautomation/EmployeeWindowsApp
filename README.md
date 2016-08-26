# EmployeeWindowsApp
ExecuteAutomtion Windows application with WCF PFService

# ExecuteAutomation Employee Windows App
This application is used while working with advanced coded UI frameworks course

#Advanced framework development with Coded UI Test 2015
https://www.udemy.com/framework-development-with-cuit

#Pre-requisite
Before running your application from visual studio 2015/2013, you need to first create the EmployeeDb in SQL server database server via
management studio.
The script is available under https://github.com/executeautomation/EmployeeWindowsApp/tree/master/DatabaseScript

#How to Compile application ?
All you have to do is 

1. Clone the repo or download it
2. Open the project in Visual studio 2013/2015
3. Just build the project and run, the application will launch and ready for automation

#Advanced Topic
##What will happen while building project
The project will try to connect your default database server, since the connection string in App.config is given as this
```xml
  <connectionStrings>
    <add name="EmployeeModel" connectionString="data source=.;initial catalog=EmployeeDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
      providerName="System.Data.SqlClient" />
    <add name="EmployeeWindowsApp.Properties.Settings.EmployeeDBConnectionString" connectionString="Data Source=.;Initial Catalog=EmployeeDB;Integrated Security=True"
      providerName="System.Data.SqlClient" />
  </connectionStrings>
```

####More articles
For more articles visit http://www.executeautomation.com
