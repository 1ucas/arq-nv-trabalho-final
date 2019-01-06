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

### API de Catálogo
(Swagger Disponível)

** Rota:
/api/books/{id} [GET] -> Busca um livro pelo Id
/api/books [GET] -> Realiza uma busca global dos livros com a possibilidade de filtrar por autor

### API de Ordering
(Swagger Disponível)

** Rota:
/api/ordering [POST] -> Cria uma nova ordem de compra
/api/ordering/{id} [GET] -> Busca uma ordem pelo Id

### API de Carrinho (Basket)
(Swagger Disponível)

** Rota:
/api/basket [DELETE] -> Remove todos os carrinhos expirados. A propriedade de carrinho expirado deve ser gerenciada conforme necessidade do gerente do sistema
/api/basket/{userId} [GET] -> Busca um carrinho através do Id do usuário relacionado

### API de Marketing

** Rota:
/api/privacidade [GET] -> Obtém os termos de privacidade de usuário do sistema
/api/termos [GET] -> Obtém os termos de uso do sistema

### API de Localização (Locations)

** Rota:
/api/location [POST] -> Adiciona uma nova localização
/api/location/{userId} [GET] -> Busca as localizações registradas de um usuários

### Gateway de Compras (Shopping)

Tem o objetivo de expor para o frontend os serviços relacionados ao Login e produtos (busca e compra).

** Serviços agregados:
- Identity
- Catalog
- Ordering
- Basket

### Gateway de Marketing

Tem o objetivo de expor os serviços de ações promocionais, termos de uso e informações estratégicas para o marketing, como a localização de cada usuário.

** Serviços agregados:
- Marketing
- Locations