# Trabalho Final da Disciplina de Arquitetura de Nuvens

Exemplo de aplicação distribuída em microserviços. Essa aplicação contém 6 APIs separadas em contêineres.

Para se comunicarem com clientes externos essas APIs passam por dois Gateways Externos.

Para melhor entendimento, segue exemplo abaixo:

### 
![alt text](https://github.com/1ucas/arq-nv-trabalho-final/blob/master/exemplo.png)

## Funcionamento Geral das APIs

O objetivo global do trabalho era exercitar de forma prática a conteinerização e orquestração das APIs sem focar na parte funcional de cada uma delas.

Com isso um mente, foram disponibilizadas duas rotas de testes em cada uma delas. O detalhamento dessas rotas segue abaixo:

### API de Identity
(Swagger Disponível)

** Rota:
/api/login [POST] -> Realiza o Login e Busca um Token de Utilização
/api/users [GET] -> Passa o Token e Recupera todas informações do Usuário