# select image
FROM maven:3.5-jdk-8

# copy your source tree
COPY ./ ./

# build for release
RUN mvn package

EXPOSE 9095

# set the startup command to run your binary
CMD ["java", "-jar", "./target/shopping-gateway-0.1.0.jar"]