# Entity Framework

## install Dotnet:

        dotnet tool install --global dotnet-ef
## To Add Migrations:
        dotnet ef Migrations add 'Table Name' --project 'Project Name' --context 'DbContext class Name'

## EF Add Package:

        dotnet add package Microsoft.EntityFrameworkCore.Design
## Execute the below command to verify the EF Installation:

        dotnet ef

## Enter scaffold command 
        dotnet ef dbcontext scaffold "connectionstring" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models
## For Generating bd context only in the folder
        dotnet ef dbcontext scaffold --context-dir Models
## Create the controller also complete the steps in the middleware

## To restore require packages
        dotnet restore
