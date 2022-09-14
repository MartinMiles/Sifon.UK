# Sifon.UK runs in Kubernetes (HTTPS + CloudFlare)

## Create namespace:
`kubectl --kubeconfig=vke.yaml apply -f namespace.yaml`

## Create alias:
`alias sif='kubectl --kubeconfig=vke.yaml -n sifon'`

## Persistent volume

`sif apply -f pv.yml`

`sif apply -f pvc.yml`

PV specifies external folder (on a node in my case). PVC refers PV by storageClassName parameter (manual in our case), deplyment refers PVC by claimName parameter. Deploment has mountPath parameter that specifies folder within a container to mount external folder into.

## Create deployment:
`sif apply -f deployment.yaml`

### run code within pod to test it
```
sif exec sifon-9cb8b689b-nnbfg -it /bin/sh
apt-get update; apt-get install curl -y
apt-get install iputils-ping -y
curl https://localhost
```

## Service
`sif apply -f service.yaml`

## Create Ingress with HTTPS
`sif apply -f ingress-https.yaml`


# On container (codebase) update
1. `sif delete deployment sifon`
2. `sif apply -f deployment.yaml`

# On content update
1. login to the node
2. navigate into `/mnt/data/sifon`
3. delete whole content
4. download updated content, ie. `wget URL/file.zip`
5. `unzip file.zip`


There is no need to touch service and ingress in either case, they will pick changes automatically


