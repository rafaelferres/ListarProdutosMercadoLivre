# Lista de Produtos ML
Esse é um simples projeto que lista todos os produtos do mercado livre.

# Como Utilizar ?
É simples, basta incluir o seu ClientId na variavel ClientId, o seu ClientSecret na variavel ClientSecret  e o ID do Vendedor na variavel SellerID.

# Dll's Utilizadas 
- net-sdk (Dll do MercadoLivre) : https://github.com/mercadolibre/net-sdk
- RestSharp (Vem junto a Dll do MercadoLivre) : https://www.nuget.org/packages/RestSharp/106.3.0-alpha0018
- Newtonsoft.Json (Para manipular o JSON de retorno do MercadoLivre) : https://www.nuget.org/packages/newtonsoft.json/

# Como pegar o ClientID, ClientSecret e o ID do Vendedor
Para pegar o ClientID e a ClientSecret você deve criar uma aplicação no MercadoLivre (https://developers.mercadolivre.com.br/apps/), após isso o ID é o ClientID e a SecretKey é a ClientSecret.
Para pegar o ID do Vendedor acesse http://developers.mercadolibre.com/pt-br/produto-autenticacao-autorizacao/ e procure por "Tenha seu access_token!", após encontrar digite o ID de sua aplicação (ClientID), em "User ID" irá aparecer o ID de seu Vendedor.
