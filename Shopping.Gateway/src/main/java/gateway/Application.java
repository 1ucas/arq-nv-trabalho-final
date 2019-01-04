package gateway;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.cloud.client.circuitbreaker.EnableCircuitBreaker;
import org.springframework.cloud.gateway.route.RouteLocator;
import org.springframework.cloud.gateway.route.builder.RouteLocatorBuilder;
import org.springframework.context.annotation.Bean;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import models.BaseErrorResponse;
import reactor.core.publisher.Mono;

@EnableCircuitBreaker
@SpringBootApplication
@RestController
public class Application {

    public static void main(String[] args) {
        SpringApplication.run(Application.class, args);
    }
    
    @Bean
    public RouteLocator myRoutes(RouteLocatorBuilder builder) {
        return builder.routes()
            .route(p -> p
            	.path("/identity/**")
                .filters(f -> f.stripPrefix(1))
                .uri("http://localhost:9091"))
            .route(p -> p
                	.path("/catalog/**")
                    .filters(f -> f.stripPrefix(1))
                    .uri("http://localhost:9092"))
            .route(p -> p
                	.path("/ordering/**")
                    .filters(f -> f.stripPrefix(1))
                    .uri("http://localhost:9093"))
            .route(p -> p
                	.path("/basket/**")
                    .filters(f -> f.stripPrefix(1))
                    .uri("http://localhost:9094"))
            .build();
    }
    
    @RequestMapping("/")
    public Mono<String> home() {
        return Mono.just("<body>\r\n" + 
        		"    <h1>Spring Cloud Gateway</h1>\r\n" + 
        		"	<h2>Exemplo de uso do Spring Gateway para o Trabalho do curso de Arquitetura de Nuvens - Puc Minas 2019</h2>\r\n" + 
        		"	<h4>Integrantes:</h4>\r\n" + 
        		"	<ul>\r\n" + 
        		"        <li>Lucas Maciel</li>\r\n" + 
        		"	</ul>\r\n "
        		+ "</body>");
    }
}
