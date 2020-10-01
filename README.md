# school-apis

## Project for the management of platforms related to The Chain of Change 

### using SSO projects from: 
- https://github.com/brunohbrito/JPProject.IdentityServer4.AdminUI
- https://github.com/brunohbrito/JPProject.IdentityServer4.SSO
- https://github.com/brunohbrito/MongoDB-RepositoryUoWPatterns

## Todo

- Inser Moodle as 1 microservice - https://github.com/moodlehq/moodle-docker
- Integrate Moodle with SSO project - https://docs.moodle.org/dev/Authentication_plugins
- Deploy all microservices to the same pod on kubernetes: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/

## Project with Docker

### docker compose contains a deploy for a proxy with Nginx server - for the SSO multiple projects

## Nginx folder and docker compose

 - ### Nginx contains a folder with the configuration of sites - change it for the API's
 
 - ### docker compose maps the ports configured in the previous file to the respective containers
 
## SingleSignonUI folder 
- contains Angular project related to the management of the IdentityServer - equivalent to Jp.AdminUI from the JPProject (AdminUI)

- contains Angular project related to the management of the IdentityServer users - equivalent to Jp.UserManagement from the JPProject

##-------------------------------------------
## API's - NET Core 3.1 and NET Standard 2.1

### Shared folder - common .NET Standard Libraries to be used on the multiple projects

### APIGateway - proxy for the multiple REST paths for other API's (using Ocelot)

### SignleSignon folder - contains the projects related to single sign-on:

 - #### UserService - API for SSO user management - equivalent to Jp.Api.Management from the JPProject

 - #### SingleSignonPage - frontend for the Single Sign-On process - equivalent to Jp.Ui.SSO from the JPProject

