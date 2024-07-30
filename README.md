
# Weather Information Service

This project is a SOAP-based web service that provides weather information for a specific city. The project is developed using ASP.NET Core 6.0 and integrated with an MS SQL Server database.

## Project Overview

This project provides a SOAP web service to fetch weather information. It includes the following features:

- **Weather Database**: The `Weather` table stores city names, temperatures, and weather conditions.
- **SOAP Web Service**: Access weather information by city via the `WeatherService.svc` endpoint.

## Technologies

- **ASP.NET Core 6.0**: Used for developing the web service.
- **SOAP**: Used as the web service protocol.
- **MS SQL Server**: Used for database management.

## Setup

Follow these steps to run the project locally:

1. **Clone the Project:**

   ```bash
   git clone https://github.com/harxite/WeatherServiceSOAP.git
   cd WeatherService
   ```

2. **Install Necessary Packages:**

   Open the project in Visual Studio and install the required NuGet packages.

3. **Configure Database Settings:**

   Open the `appsettings.json` file and update the database connection string to match your database settings:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "data source=YOUR_SERVER_NAME;initial catalog=WeatherDB;integrated security=True;MultipleActiveResultSets=True"
   }
   ```

4. **Create Database Schemas:**

   Use the following SQL commands to create the necessary table and insert initial data:

   ```sql
   CREATE TABLE Weather (
       Id INT PRIMARY KEY IDENTITY(1,1),
       City NVARCHAR(50),
       Temperature DECIMAL(5,2),
       Condition NVARCHAR(50)
   );

   INSERT INTO Weather (City, Temperature, Condition) VALUES ('Istanbul', 29.5, 'Sunny');
   INSERT INTO Weather (City, Temperature, Condition) VALUES ('Ankara', 24.3, 'Cloudy');
   INSERT INTO Weather (City, Temperature, Condition) VALUES ('Izmir', 27.8, 'Sunny');
   ```

5. **Run the Application:**

   Start the project in Visual Studio and test the SOAP web service at `https://localhost:7015/WeatherService.svc`.

## API Usage

The web service exposes the `GetWeather` method. This method accepts a SOAP request in the following XML format:

```xml
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:temp="http://tempuri.org/">
   <soapenv:Header/>
   <soapenv:Body>
      <temp:GetWeather>
         <temp:city>Istanbul</temp:city>
      </temp:GetWeather>
   </soapenv:Body>
</soapenv:Envelope>
```

It returns weather information for the specified city.
