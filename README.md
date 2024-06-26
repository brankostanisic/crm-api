# Requierements for running the API:

##  Docker Desktop
   After running Docker Desktop the following line should be executed inside the terminal to set up the MS SQL Server database:
      ```
      docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Password@123" -p 1433:1433 --name crm --hostname crm -d mcr.microsoft.com/mssql/server:2022-latest
      ```
##  .NET 8
   If you're running the application using Visual Studio you can use the package manager console to create the database running the following line:
      ```Update-Databse```
      
   Otherwise you can run the dotnet ef tool through the terminal while located in the application directory:
      ```dotnet ef database update```.
      
   If necessary first install it using:
      ```dotnet tool install --global dotnet-ef --version 8.*```
      
