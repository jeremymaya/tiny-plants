# tiny-plants

----

## Deploy ASP.NET application to Heroku via Docker

1. Add ```Docker Support``` by following the steps in [Create a Multi-Container App with Docker Compose](https://docs.microsoft.com/en-us/visualstudio/mac/docker-multi-container?view=vsmac-2019)
2. Set up a continous deployment to Heroku from a GitHub repository by following the steps in [Deploying to Heroku from GitHub Actions](https://dev.to/heroku/deploying-to-heroku-from-github-actions-29ej).
    * Add a ```cd``` command to changes the directory to where Dockerfile is located before running Heroku CLI commands
    * Update the port in ```Dockerfile``` to ```$PORT``` by following the steps in [Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)
    * Do not forget to update the ```COPY```, ```RUN```, ```WORKDIR``` as shown in [Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)

----

## Credits

* [Microsoft - Create a Multi-Container App with Docker Compose](https://docs.microsoft.com/en-us/visualstudio/mac/docker-multi-container?view=vsmac-2019)
* [DEV - Deploying to Heroku from GitHub Actions](https://dev.to/heroku/deploying-to-heroku-from-github-actions-29ej)
* [codeburst.io - Deploy a Containerized ASP.NET Core App to Heroku using GitHub Actions](https://codeburst.io/deploy-a-containerized-asp-net-core-app-to-heroku-using-github-actions-9e54c72db943)
* [A Dev Talks - Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)
