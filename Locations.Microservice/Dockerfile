# select image
FROM maven:3.5-jdk-8

# copy your source tree
COPY ./ ./

# build for release
RUN mvn package

EXPOSE 9092

# set the startup command to run your binary
CMD ["java", "-jar", "./target/gs-rest-service-0.1.0.jar"]