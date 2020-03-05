[![CircleCI](https://circleci.com/gh/gm7/csharp-cli.svg?style=svg)](https://circleci.com/gh/gm7/csharp-cli) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=gm7_csharp-cli&metric=alert_status)](https://sonarcloud.io/dashboard?id=gm7_csharp-cli) [![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli?ref=badge_shield) [![Known Vulnerabilities](https://snyk.io/test/github/gm7/csharp-cli/badge.svg)](https://snyk.io/test/github/gm7/csharp-cli)

# C# cli test application

This is a simple C# Command Line Interface test application that is being used to test circleci pipelines

## Docker build
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli?ref=badge_shield)

Here is a simple build command (execute from the project root) to build the application and create the docker container:
```
docker build . -t csharp-cli:test
```

## Simple docker run
Here is a simple docker run to execute the app hosted in the container (built above):
```
docker run --rm -v "$PWD":/data csharp-cli:test /data/test36m.txt
```




## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fgm7%2Fcsharp-cli?ref=badge_large)