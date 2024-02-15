# HubSpot
## HubSpot Coding Challenge 

This project is part of a coding challenge designed to evaluate coding skills through a practical task: downloading data from a RESTful endpoint and transforming it into a CSV file. 

The project is a work in progress but fulfills the essential requirements for the coding challenge. 

Currently, there is no user interface, and the application is intended to be executed using the test project

## Setup
Clone the Repository: After cloning the repository, proceed with the following setup steps.

- In the Business Project Create a Folder Named Connection.
  
- In the Connection folder, create a static class named Hidden.

- Add one private static property _hubSpotApiKey with the initializer set to "Your-API-Token";

- Implement a static method GetHubSpotApiKey that returns the _hubSpotApiKey.

- Clean and rebuild the project to ensure there are no errors.

## Testing
The HubSpotApiServiceTests Class Currently has all of the Tests for Querying the HubSpot API. 

There is also a test that writes the results to a CSV file using a helper class developed for this purpose.

The Results are Exported to a TestOutput Folder inside the TestProject.Business

In the TestBase Class update the _outputDirectory property by replacing "ADD YOUR FILE PATH HERE" - With your Repository Location.

## Architecture
This application is built using a Three-Tier Architecture with the Repository Design Pattern, aimed at making the functionality reusable across different user interfaces and flexible for adding new user requirements.

## Future Enhancements 
- Implement more test methods for HubSpotApiService.
- Integrate logging (e.g., Serilog).
- Develop a Mapper Test Class and CsvExportHelper Test Class.
- Enhance exception handling.
- Add a user interface.
- Continue to Develop this README

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
