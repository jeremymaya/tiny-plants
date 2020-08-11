# tiny-plants

----

![Actions Status](https://github.com/jeremymaya/tiny-plants/workflows/CI/badge.svg)

## TINY PLANTS

Deployed Website: <http://tinyplants.herokuapp.com>

Authors: [Karina Chen](https://github.com/karina6188) and Kyungrae Kim

----

## Description

This is an eCommerce store [TINY PLANTS](https://github.com/jeremymaya/Code-401-eCommerce) deployed on Heroku using Docker. The web app is built with ASP.NET Core's MVC and Razor Pages which features a user login security system, a welcoming home page, a product page, and a product details page that allows the user to add items into cart for checkout. This web app is built to provide a satisfying shopping experience to our users.

----

## Features

----

## Deploy ASP.NET application to Heroku via Docker

1. Add ```Docker Support``` by following the steps in [Create a Multi-Container App with Docker Compose](https://docs.microsoft.com/en-us/visualstudio/mac/docker-multi-container?view=vsmac-2019)
2. Set up a continous deployment to Heroku from a GitHub repository by following the steps in [Deploying to Heroku from GitHub Actions](https://dev.to/heroku/deploying-to-heroku-from-github-actions-29ej).
    * Add a ```cd``` command to change the current directory to where Dockerfile is located before running Heroku CLI commands
    * Update the port in ```Dockerfile``` to ```$PORT``` by following the steps in [Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)
    * Do not forget to update the ```COPY```, ```RUN```, ```WORKDIR``` as shown in [Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)

----

## Credits

* [Microsoft - Create a Multi-Container App with Docker Compose](https://docs.microsoft.com/en-us/visualstudio/mac/docker-multi-container?view=vsmac-2019)
* [DEV - Deploying to Heroku from GitHub Actions](https://dev.to/heroku/deploying-to-heroku-from-github-actions-29ej)
* [codeburst.io - Deploy a Containerized ASP.NET Core App to Heroku using GitHub Actions](https://codeburst.io/deploy-a-containerized-asp-net-core-app-to-heroku-using-github-actions-9e54c72db943)
* [A Dev Talks - Deploy .Net Core 3.1 Web API to Heroku](https://adevtalks.com/programming/deployment/deploy-net-core-3-1-web-api-to-heroku/)
