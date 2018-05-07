# Swagger Training with ASP.Net Core and Docker

This sample app was based on this Pluralsight course:

[Play by play: Understaning API functionality through Swagger](https://app.pluralsight.com/library/courses/play-by-play-api-functionality-swagger/table-of-contents)

In addition, I'd like to containerize it to mix experiments. Here it is.

The next steps are:

* Publish it on an Azure Container Registry
* Use it on an Azure Container Service, using Kubernetes

## Swashbuckle to "Swaggerize" the Web API
https://github.com/domaindrivendev/Swashbuckle.AspNetCore

## Addressing the problem with the Swagger UI, described on the video
https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/483

Basically, we just need to add that NuGet Reference and access Swagger UI through http://localhost:port/swagger (remove /ui)

## References for Dockerizing the App
https://docs.microsoft.com/en-us/dotnet/core/docker/building-net-docker-images