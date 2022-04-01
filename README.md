# dotnet-worker-example

A simple .NET worker that fetches the weather every 10 seconds.

This project serves as a sandbox / demo on how to architect a worker project in .NET.

## Building and running

The project uses [WeatherApi](https://www.weatherapi.com/) so you will need to first create a 
free API key there and insert it in a ```secrets.json``` file at the root of the project.

Like that :
```json
{
  "WeatherApi.com": {
    "ApiKey": "YOUR_API_KEY_HERE"
  }
}
```

Enjoy!
