# The Phone Book

A phone book application where CRUD operations can be performed on each record.

## Technologies and Tools
* MVC Web API
* MVC Web application
* .Net 4.7.2
* SQL Server Management Studio v18.2
* Postman

## Getting started
## Installation
* Download and install Visual Studio (2017 or 2019) or Visual Studio Code.
* Download and install SQL Server Management Studio v18.2.
* In SSMS, open a new query window and execute the script found in the project folder (CreateDB.txt) to create a new database.
* In SSMS, open a new query window and execute the script found in the project folder (Createtbl) to create a new table.
* In Visual Studio, open the project folder or double click on the file named Contacts.API.sln. Both projects, Contacts.API and Contacts.MVC should be set to “set as Startup Project”.

## Running the application
* Build the solution in Visual Studio.
* Run the Application in Visual Studio.

## Contacts.MVC
When running the application, a user will be presented with a web application where one can create a new contact, search for a contact by name, edit the details of a selected contact and delete a contact.

## Step 1 - Create
Click on “Create New” to add a new contact. Once the details have been entered, a contact/s will be displayed in a table on the home page of the web application. On creation, the entry is stored in a database as well.

## Step 2 - Retrieve
To search for a contact, enter the name of a contact that is displayed in the table of the web application from the home page. Once the text box is populated with a name, click on “Search”. The record will be displayed.

## Step 3 - Update
To edit a contact, select a contact from the home page of the web application and click on “Edit”. From here, a contacts details can be edited.

## Step 4 - Delete
To delete a contact, click on “Delete” for a specific contact from the home page of the web application. The record will be deleted from the database as well.

There are notifications for each CRUD operation that gets performed, using Alertify.js.

## Contacts.API
To test the API endpoints, a user can navigate to the URLs listed below”. 

Contacts
* GET api/Contacts	
* GET api/Contacts/{id}	
* PUT api/Contacts/{id}	
* POST api/Contacts	
* DELETE api/Contacts/{id}

SearchContacts
* GET api/SearchContacts	
* GET api/SearchContacts/{id}	
* PUT api/SearchContacts/{id}	
* POST api/SearchContacts	
* DELETE api/SearchContacts/{id}


Tests were conducted using Postman.
A Json file named "Contacts Application.postman_collection" details this test cases that were performed.
