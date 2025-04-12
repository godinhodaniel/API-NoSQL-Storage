# Persistência em BD - NoSql

## POST, Primeiro usuário:
![415D57CF-1DDF-4780-83B4-DF2852E56519](https://github.com/user-attachments/assets/37ec4961-2fad-41cd-b228-d5106b7a1ba0)
## GET, Primeiro Usuário:
![3A17B2A6-8E7A-48AC-92EB-F42815BFAC91](https://github.com/user-attachments/assets/19003260-f03f-40ce-858c-047725c3332b)
## PUT, Primeiro Usuário:
![CEEDAB71-7ED2-4C81-A1F2-410603AFB476](https://github.com/user-attachments/assets/f4c6b989-32e5-4a12-bf00-3d627bb2aa21)
## DELETE, Primeiro Usuário:
![D79938D0-085C-4048-B820-83CB0FF8C3BC](https://github.com/user-attachments/assets/5187257b-4a49-4e33-b107-1fabddff6333)
## GET, após deletar usuário:
![6A761771-11A0-4DA1-9658-26A2D6C049A7](https://github.com/user-attachments/assets/7f5d2c86-ac43-4b80-a446-e83237a288ad)
## POST, Segundo usuário:
![3A66E05F-F2B4-4596-AFB5-E357DD9696C6](https://github.com/user-attachments/assets/20148dc5-6252-4574-878d-a192519e4ec6)
## GET, Segundo Usuário:
![B95D6A61-A681-4D0F-9C48-59ECB2036C0A](https://github.com/user-attachments/assets/807bb352-c78c-4cf3-a092-5e17f0a9c565)
## PUT, Segundo Usuário:
![1992E5C3-F914-4936-8F03-8755473B405D](https://github.com/user-attachments/assets/a2311064-6666-4f03-938e-b2c187f57896)
## DELETE, Segundo Usuário:
![F1867EAF-62B7-4F8F-9173-840E13E247A1](https://github.com/user-attachments/assets/256a7c72-7dd8-49fe-ba5c-b0ab9c1831ac)
Durante os testes realizados no Swagger, todos os métodos do CRUD funcionaram corretamente. As requisições `POST` retornaram status **201 Created**, indicando que os usuários foram cadastrados com sucesso. As requisições `GET` retornaram **200 OK**, mostrando os dados corretamente. Os métodos `PUT` também responderam com **200 OK**, confirmando a atualização dos dados. Por fim, as requisições `DELETE` retornaram **204 No Content**, e os dados foram removidos com sucesso, pois ao tentar buscar os mesmos IDs depois, a resposta foi **404 Not Found**.
