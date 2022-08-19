# Sifon.UK runs in Kubernetes (HTTPS + CloudFlare)

## Create namespace:
kubectl --kubeconfig=vke.yaml apply -f namespace.yaml

## Create alias:
alias sif='kubectl --kubeconfig=vke.yaml -n sifon'

## Create deployment:
sif apply -f deployment.yaml

### run code within pod to test it
sif exec sifon-67dccdddd-vknpg -it /bin/sh
apt-get update; apt-get install curl -y
apt-get install iputils-ping -y
curl http://localhost

## Service
sif apply -f service.yaml

## Create Ingress with HTTPS
sif apply -f ingress-https.yaml


# On update
1. `sif delete deployment martin`
2. `sif apply -f deployment.yaml`

There is no need to touch service and ingress, they will pick changes automatically
