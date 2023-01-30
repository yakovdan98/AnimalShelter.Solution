# Animal Shelter

#### Daniel Yakovlev

An application to show animals at a shelter

## Technologies Used

* C#
* .Net 6
* ASP.Net EF Core 6
* SQL
* LINQ

### Objectives 

The goal for this project was to create a fully functional CRUD MVC web api that utilizes a MySQL database. EF Core was used for communication with the database.

## Setup/Installation Requirements

#### To run this project, you will need:
* .NET 6.0
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* .NET Core CLI
```
dotnet tool install --global dotnet-ef --version 6.0.0
```

1. Clone this repo to your workspace.

2. Navigate to the `ShelterApi` directory.

3. Create a file named `appsettings.json` with the following code. Be sure to update the Default Connection to your MySQL credentials.
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=shelter_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

4. Install dependencies within the `ShelterApi` directory
```
$ dotnet restore
````
5. update the database
```
$ dotnet ef database update
````
6. Build and run the program 
 ```
 $ dotnet run
 ```
## API Documentation v1
### Endpoints for GET
| Endpoints                    | Required | Returns                                    |
| ---------------------------------|------ | ------------------------------------------ |
| api/v1/animals                        | Required| All animals                             |
| api/v1/animals/1                       | Id Required | An animal with id = 1                     |
### Endpoints for POST
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/animals                       | { "name": "Lucky", "type": "Dog", "Age": 3 } |
### Endpoints for PUT
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/animals/1                       | { "animalId": 1, "name": "Lucy", "type": "Cat", "Age": 5 } |
### Endpoints for DELETE
| Endpoints                     | Result                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v1/animals/1                    | Deletes an animal with id = 1      |
## API Documentation v2
### Note: added querying contains all default endpoints
### Endpoints for GET
| Endpoints                    | Required | Returns                                    |
| ---------------------------------|------ | ------------------------------------------ |
| api/v2/animals                        | Required| All animals                             |
| api/v2/animals?name=lucky                        | Required| All with lucky name              |
| api/v2/animals?type=cat                        | Required| All with cat type             |
| api/v2/animals?age=3                        | Required| All with age of 3             |
| api/v2/animals/1                       | Id Required | An animal with id = 1                     |
### Endpoints for POST
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v2/animals                       | { "name": "Lucky", "type": "Dog", "Age": 3 } |
### Endpoints for PUT
| Endpoints                               | Request Body Example                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v2/animals/1                       | { "animalId": 1, "name": "Lucy", "type": "Cat", "Age": 5 } |
### Endpoints for DELETE
| Endpoints                     | Result                                     |
| --------------------------------------- | ------------------------------------------ |
| api/v2/animals/1                    | Deletes an animal with id = 1      |
## Known Bugs

* No known bugs.


## License

**MIT License**

Copyright (c) 2023 Daniel Yakovlev

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.