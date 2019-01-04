docker stop @(docker ps -aq)
docker rm @(docker ps -aq)
REM docker rmi @(docker images -aq)
PAUSE