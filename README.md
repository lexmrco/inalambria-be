# Proyecto Backend Prueba técnica Inalambria
## Endpoints
###
##### Identificar si la api se está ejecutando
* Url: {url}/ping
* Método: GET
* Response: pong

### Obtener un token de autenticación:
* Url: {url}/Auth
* Método: POST
* Body:
  * JSON Data:
   * UserName: admin
   * Password: Rino?015
* Response: token

#### Mostrar el usuario autenticado
* Url: {url}/Auth/EchoUser
* Método: GET
* Header: 
  * Authorization
   * Type: Bearer Token
   * Token: Token generado por la api
* Response: Nombre del usuario


### Ventas
* Url: {url}/sales
* Método: GET
* Header: 
  * Authorization
   * Type: Bearer Token
   * Token: Token generado por la api
* Response: Lista de facturas con número, fecha, cliente, dirección, teléfono


### Mostrar el detalle de una venta
* Url: {url}/sales/[orderid]
* Método: GET
* Header: 
  * Authorization
   * Type: Bearer Token
   * Token: Token generado por la api
* Response: Detalle de la factura de venta, lista de items de la factura

## Autor

* **Alexander Moreno** _Desarrollo, documentación_
