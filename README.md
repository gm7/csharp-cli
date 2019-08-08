# C# cli test application

This is a simple C# Command Line Interface test application that is being used to test circleci pipelines

## Docker build
Here is a simple build command to build the application and create the docker container:
```
docker build . -t:csharp-cli:test
```

## Simple docker run
Here is a simple docker run to execute the app hosted in the container (built above):
```
docker run -v ./:/data csharp-cli:test /data/test36m.txt
```


