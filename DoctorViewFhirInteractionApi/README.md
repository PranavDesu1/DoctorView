# DoctorViewFhirInteractionApi - ASP.NET Core 2.0 Server

This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/DoctorViewFhirInteractionApi
docker build -t doctorviewfhirinteractionapi .
docker run -p 5000:5000 doctorviewfhirinteractionapi
```
