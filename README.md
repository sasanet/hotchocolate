# Installazione rapida del tool CLI
1. scaricare il binario dalle release di github
```
wget zipreleaseURL (TODO)
```
2. estrarre la cartella publish da qualche parte
3. spostare la cartella estratta in /opt/ e rinominarla
```
sudo mv publish /opt/strawberryshake-cli
```
4. aprire il file environment
```
sudo nano /etc/environment
```
5. aggiungere "/opt/strawberryshake-cli" nella variabile d'ambiente PATH.
6. lanciare con il comando 
```
dotnet-graphql [...args]
```

# Compilare
Per compilare, lanciare lo script di compilazione
```
./build.sh
```

# Generare

1. Usare il binario fornito, vedere sezione "Installare il tool CLI rapidamente" (o compilarlo da sé facendo il publish di hotchocolate/src/StrawberryShake/Tooling)


2. Lanciare il generatore
```
 ./dotnet-graphql init  http://localhost:8091/graphql -n PfClient -p /home/alessandro/Scrivania/pf-strawberry/Demo --headers 'Authorization= Bearer Keuqla5rpZoZRAOOYPkvB0OYCLXR8ZlD5bbUbm' 
```

3. Proseguire come da

https://chillicream.com/docs/strawberryshake/get-started/console


