# InfoTrack.Api


It is an api used as a test to infotrack

## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) and [Framework](https://dotnet.microsoft.com/download/) installed on your computer. From your command line:

Note: you can consulting the endpoint in [swagger](https://{BaseURL}/swagger/index.html)

## Download
```bash
# Clone this repository
$ git clone https://github.com/edaluz007/InfoTrackApi.git

# Go into the repository
$ cd InfoTrack.Api

# Install dependencies
$ nuget restore InfoTrack.Api.sln

# Enter the folder
$ cd InfoTrack.Api

# Run the app Dev Enviroment
$ dotnet run --launch-profile "InfoTrack.Api"
```

## Struct BACKEND
* InfoTrack.Api
    - Controllers
    - Injection Dependency
    - General settings
    
* InfoTrack.Application
    - Constants
    - Ennumerables
    - Exception class
    - Wrappers
    
* InfoTrack.Domain
    - Entities
    - Repositories Interfaces

* InfoTrack.Infrastructure
    - DbContext
    - Repositories Implementations

* InfoTrack.Test


## Struct BACKEND


* SRC
    - Axios
        - Axios Settings
    - Components
        - Forms Components
        - Grids Components
    - Routes
        - Menu items routes
    - Services
        - Axios services connect to Backend
    - Views
        - HTML Views


## License
infotrack


