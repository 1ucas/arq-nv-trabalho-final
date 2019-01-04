REM Iniciando MicroServiço Identity
cd ."\Identity.Microservice\Identity.Microservice"
docker run -d -p 9091:9091 --name identity-ms-container identity-ms-image
REM Iniciando MicroServiço Catalog
cd ..
cd ..
cd ."\Catalog.Microservice\Catalog.Microservice"
docker run -d -p 9092:9092 --name catalog-ms-container catalog-ms-image
cd ..
cd ..
cd ."\Ordering.Microservice\Ordering.Microservice"
docker run -d -p 9093:9093 --name ordering-ms-container ordering-ms-image
REM Iniciando MicroServiço Basket
cd ..
cd ..
cd ."\Basket.Microservice\Basket.Microservice"
docker run -d -p 9094:9094 --name basket-ms-container basket-ms-image
REM Iniciando Shopping Gateway
cd ..
cd ..
cd ."\Shopping.Gateway"
docker run -d -p 9095:9095 --name shopping-gateway-container shopping-gateway-image
REM Iniciando MicroServiço Marketing
cd ..
cd ."\Marketing.Microservice"
docker run -d -p 9096:9096 --name marketing-ms-container marketing-ms-image
REM Iniciando MicroServiço Location
cd ..
cd ."\Locations.Microservice"
docker run -d -p 9097:9097 --name locations-ms-container locations-ms-image
REM Iniciando Marketing Gateway
cd ..
cd ."\Marketing.Gateway"
docker run -d -p 9098:9098 --name marketing-gateway-container marketing-gateway-image
PAUSE