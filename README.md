## Sifon.UK website

A lightweight website:
- serves content from Markdown files (*.md)
- built with .NET 6.0 (ASP.NET)
- for Linux runtime in Docker
- runs on Kubernetes

### Firstly, push image into Docker Hub

```
docker login
docker tag sifon martinmiles/sifonuk
docker push martinmiles/sifonuk
```

Alternatively, just use 'Publish' option of Visual Studio 2022 that deploys built image directly to docker hub.

It will ask for login and password and then do the rest of work automatically. Upon completion, verify image actually got updated.


### Next follow instructions from Kubernetes folder



