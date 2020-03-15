# base image
FROM node:12.7-alpine as builder

# install and cache app dependencies
COPY ["SingleSignon/Frontend/IdentityAdminUI/package.json", "./"]
COPY ["SingleSignon/Frontend/IdentityAdminUI/package-lock.json", "./"]

## Storing node modules on a separate layer will prevent unnecessary npm installs at each build

RUN npm ci && mkdir /app && mv ./node_modules ./app/

WORKDIR /app

# add app
COPY ["SingleSignon/Frontend/IdentityAdminUI/", "/app"]

# rebuild node
RUN npm rebuild node-sass
# generate build
RUN npm run ng build -- --configuration=docker

##################
### production ###
##################

# rebuild node
# RUN cat SingleSignon/environments/environment.prod.ts
# RUN npm rebuild node-sass
# generate build
#RUN npm run ng build -- --configuration=production

# base image
FROM nginx:alpine

## Remove default nginx website
RUN rm -rf /usr/share/nginx/html/*

# copy artifact build from the 'build environment'
COPY --from=builder /app/nginx/nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=builder /app/dist /usr/share/nginx/html

# expose port 80
EXPOSE 80/tcp

# run nginx
CMD ["nginx", "-g", "daemon off;"]
