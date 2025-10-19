FROM node:20-alpine

WORKDIR /app

COPY package*.json ./
COPY server.js ./
COPY index.html ./

RUN npm install

EXPOSE 80

CMD ["node", "server.js"]