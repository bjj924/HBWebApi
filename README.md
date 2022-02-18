<h1 align="center">Welcome to readme for the HBWebApi👋</h1>

<p align="center"> Disclaimer : This is an web api application in .net core build for a technical exercise.</p>

## Structure
The Web Api is divided into five parts:

```
HBWebApi - The start project
HBWebApi.Domain (Business)
HBWebApi.Entities (Models) 
HBWebApi.Repository (EF methods) 
HBWebApi.Domain.Test (Test for the Business layer)
```
 **There has been a problem with the naming of the csproj of the HBWebApi.Domain and HBWebApi.Entities, in the solution of the proyect in visual studio they look OK, but in the folders, we can see that are references as Business and Entities**
 
## Points to resolve
 
 ### First Problem:
 
 *You are given two arbitrarily large numbers, stored one digit at a time in an array.
The first must be added to the second, and the second must be reversed before addition.
The goal is to calculate the sum of those two sets of values.*

**IMPORTANT NOTE:**

- The input can be any length (i.e: it can be 20+ digits long).
- num1 and num2 can be different lengths.
```
Sample Inputs:
          num1 = 123456 
          num2 = 123456
```

```
Sample Output: Result: 777777
```
*Please include a demonstration of appropriate unit tests for this functionality.*

 ### Second Problem: 
 *You have three different tables*
```
A Customer Table with FirstName, LastName, Age, Occupation, MartialStatus, PersonID
An Orders Table with OrderID, PersonID, DateCreated, MethodofPurchase
An Orders Details table with OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin
```
*Please return a result of the customers who ordered product ID = 1112222333 and return FirstName and LastName as full name, age, orderid, datecreated, MethodOfPurchase as Purchase Method, ProductNumber and ProductOrigin*

## About the Application

- The aplication, when is started from visual studio, it's already will go to the **Swagger** that is configured. With this is not neccesary use Postman or the need to download it.
- 
![image](https://user-images.githubusercontent.com/29278519/154650810-883ef5d2-dbdc-4698-84ff-f4f56a3346ab.png)

**Once in the Swagger, you can see two endpoints. Each one to resolve one of the problems:**
 1. **GetArraySum**: Recieves an object with two values string, in this case the endpoint recieves it from query, as is showing in the next image. 
  ![image](https://user-images.githubusercontent.com/29278519/154651282-2c329303-5e4a-4a3a-b1be-9c1b43b00b33.png)
  <h5 align="center">The logic for this will be in the HBWebApi.Domain --> ArrayLogic --> CalculateArray.cs</h5>
  
 2. **GetCustomerByProduct**: As the same to the previus one, this endpoint recieves the productId from query, and the search it in the DataBase and return a object with the values (there is a sample of the object in the image with the values that will be returning).
 ![image](https://user-images.githubusercontent.com/29278519/154652235-a1539035-82c2-4061-9ac0-af6410fccb4f.png)
<h5 align="center">The query that retrieves from the database will be in the HBWebApi.Repository --> CustomerRepository --> CustomerRepository.cs</h5>

## DataBase
To use the Databa first is neccesary to create it. <br />
Inside the project in **HBWebApi.Repository --> DataBaseScripts --> HBExerciseQuery.sql** we can find the query to create the database, the tables and fill the tables (there is too the query that is use in the project to retrive the custumer but in sql format and is commented in the file, to run it just uncommented it after the tables where filled and run it)
<br />

![image align="center"](https://user-images.githubusercontent.com/29278519/154654233-4051db29-160b-4874-85da-1a8c60ed0020.png)
<br />

***In case that there whas neccesary to change the database name, please change the name in the appsettings.json in the line of the DefaultConnection, the file is in the HBWebApi start project.***

***Regards and good luck!***
