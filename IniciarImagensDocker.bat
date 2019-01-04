REM ***************
REM ***************
REM Iniciando MicroServi�o Identity
REM ***************
REM ***************
cd ."\Identity.Microservice\Identity.Microservice"
dir
docker build -t identity-ms-image .
REM ***************
REM ***************
REM Iniciando MicroServi�o Catalog
REM ***************
REM ***************
cd ..
cd ..
cd ."\Catalog.Microservice\Catalog.Microservice"
dir
docker build -t catalog-ms-image .
REM ***************
REM ***************
REM Iniciando MicroServi�o Ordering
REM ***************
REM ***************
cd ..
cd ..
cd ."\Ordering.Microservice\Ordering.Microservice"
dir
docker build -t ordering-ms-image .
REM ***************
REM ***************
REM Iniciando MicroServi�o Basket
REM ***************
REM ***************
cd ..
cd ..
cd ."\Basket.Microservice\Basket.Microservice"
dir
docker build -t basket-ms-image .
REM ***************
REM ***************
REM Iniciando Shopping Gateway
REM ***************
REM ***************
cd ..
cd ..
cd ."\Shopping.Gateway"
dir
docker build -t shopping-gateway-image .
REM ***************
REM ***************
REM Iniciando MicroServi�o Marketing
REM ***************
REM ***************
cd ..
cd ."\Marketing.Microservice"
dir
docker build -t marketing-ms-image .
REM ***************
REM ***************
REM Iniciando MicroServi�o Location
REM ***************
REM ***************
cd ..
cd ."\Locations.Microservice"
dir
docker build -t locations-ms-image .
REM ***************
REM ***************
REM Iniciando Marketing Gateway
REM ***************
REM ***************
cd ..
cd ."\Marketing.Gateway"
dir
docker build -t marketing-gateway-image .
PAUSE