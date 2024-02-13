# HubSpot

HubSpot Coding Challenge - "The goal of this exercise is to see how you approach coding. It's a simple exercise to download data from a restful endpoint and transform the data into a CSV file." 

This project is part of a coding challenge designed to evaluate coding skills through a practical task: downloading data from a RESTful endpoint and transforming it into a CSV file. 
The project is a work in progress but fulfills the essential requirements for the coding challenge. Currently, there is no user interface, and the application is intended to be executed using the test project

After you Clone the Repository - Create a Static Class named Hidden in the Connection Folder, Add one private static property _hubSpotApiKey {get; set;} = "Your-API-Token";

Add One Static Method GetHubSpotApiKey() That returns the _hubSpotApiKey; 

When this is Completed, Clean and Rebuid to ensure there are no errors. 

The HubSpotApiService.Tests Class has all of the Tests for Querying the HubSpot API. 

There is also a Test which writes the results to CSV using a Helper Class that I created. 

This application is buit using Three-Tier ARchitecture with the Repository Design Pattern. 

The goal was to make the functionality reusable across different User Interfaces, as well as flexibile in terms of adding new user requirements. 

There are many things that still need to be implemented: More Test Methods for the HubSpotApiService, Logging - Serilog, Mapper Test Class, CsvExportHelper Test Class, More Exception Handling, Adding a User Interface. 

## Project Structure

### Business
The `Business` project contains the business logic of the application. It includes the following components:
- **ApiService:**
- **HubSpotApiService:**
- **HubSpotContactListApiResponse:**
- **HubSpotApiResponseMapper:**
- **HubSpot.Business.Tests:**
- **Config:**
- **Connection:**
- **Helpers:**
- **Models**
  
### Test Projects
The `Tests` Folder Contains all the Test Projects for the Application.
- **HubSpot.Business.Tests:**


### Global Project
The `Global` project serves as a central place for common files used across the application. It includes the following components:
- **Constants:**
- **Exceptions:**

## Technologies Used
- **.NET 8:** The project is built using the .NET 8 framework, which provides the latest features and improvements for developing robust applications.
- **MS Test:** The unit tests are written using the MS Test framework, which is a testing framework included with the .NET platform.
- **CsvHelper:** A library for reading and writing CSV files. Extremely fast, flexible, and easy to use. Supports reading and writing of custom class objects
