
# **SinqiaBank API - Teste para Processo Seletivo**

Bem-vindo ao **SinqiaBank API**, um projeto desenvolvido para avaliação técnica no processo seletivo da Sinqia. Este projeto implementa uma **API RESTful** em **ASP.NET Core**, utilizando padrões de design como **Observer Pattern** e **Injeção de Dependência**, e inclui testes automatizados com **xUnit e Moq**.

---

## **Índice**

- [Objetivo](#objetivo)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Padrões de Design Implementados](#padrões-de-design-implementados)
- [Funcionalidades](#funcionalidades)
- [Setup do Projeto](#setup-do-projeto)
- [Endpoints da API](#endpoints-da-api)
- [Testes Automatizados](#testes-automatizados)
- [Instruções de Execução](#instruções-de-execução)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Contato](#contato)

---

## **Objetivo**

Este projeto foi desenvolvido como parte de um **processo seletivo** para avaliar habilidades em:
- **Desenvolvimento Backend** com C# e ASP.NET Core.
- **Padrões de Design** (como Observer Pattern).
- **Testes Automatizados** com xUnit e Moq.
- **Boas Práticas de Programação** e organização de código.

---

## **Tecnologias Utilizadas**

- **ASP.NET Core 6+** – Framework para desenvolvimento da API.
- **xUnit** – Framework para testes unitários.
- **Moq** – Biblioteca para criar mocks de dependências nos testes.
- **Swagger** – Documentação interativa da API.
- **Visual Studio** – Ambiente de desenvolvimento.

---

## **Padrões de Design Implementados**

- **Validation**: Implementado um validador básico de usuário.
- **Dependency Injection**: Garantindo modularidade e testabilidade.
- **Factory Method**: Implementado para criar diferentes tipos de produtos..
- **Observer Pattern**: Utilizado para notificar observadores sobre eventos, como a criação de pedidos.
- **Singleton**: Implementado para garantir uma única instância global para o notificador de eventos (EventNotifier).
- **Test Coverage**: Criados testes unitários com xUnit.

---

## **Funcionalidades**

- **Usuário**:
  - Criação de usuário e notificação de eventos.
- **Pedido (Order)**:
  - Criação de pedido e notificação do evento.
- **Produto (Product)**:
  - Gestão de produtos.

---

## **Setup do Projeto**

### **Pré-requisitos**
- **.NET 6+ SDK** instalado: [Download .NET SDK](https://dotnet.microsoft.com/download)
- **Visual Studio 2022** ou superior.
- **Postman** (opcional) para testar os endpoints.

### **Passo a Passo para Clonar e Executar o Projeto**

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/seu-usuario/sinqia-bank-api.git
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd sinqia-bank-api
   ```

3. **Restaure as dependências**:
   ```bash
   dotnet restore
   ```

4. **Compile o projeto**:
   ```bash
   dotnet build
   ```

5. **Execute o projeto**:
   ```bash
   dotnet run --project SinqiaBank
   ```

---

## **Endpoints da API**

Acesse a documentação completa da API via **Swagger**:

- **Swagger UI**: [http://localhost:5000/swagger](http://localhost:5000/swagger)

### **Exemplos de Endpoints**

- **POST /api/user/create**  
  Cria um novo usuário e envia uma notificação.  
  **Exemplo de corpo da requisição**:
  ```json
  {
    "customerName": "Pedro",
    "productName": "Produto X"
  }
  ```

- **POST /api/order/create**  
  Cria um novo pedido e envia uma notificação.

---

## **Testes Automatizados**

O projeto inclui **testes automatizados** com **xUnit** e **Moq** para validar o comportamento dos controllers e serviços.

### **Executando os Testes**

1. **Navegue até o diretório de testes**:
   ```bash
   cd SinqiaBank.Tests
   ```

2. **Execute os testes**:
   ```bash
   dotnet test
   ```

3. **Exemplo de Saída Esperada**:
   ```
   Passed!  -  All tests: 2, Passed: 2, Failed: 0
   ```

---

## **Instruções de Execução**

- A API é exposta localmente em: `http://localhost:5000`
- Para verificar a documentação dos endpoints, acesse o **Swagger**.
- Utilize **Postman** ou **Swagger UI** para realizar testes e interagir com a API.

---

## **Estrutura do Projeto**

```
/src
├── /Application
│   └── /Interfaces           # Interfaces para serviços
├── /Controllers              # Controllers da API
├── /Core
│   ├── /Entities             # Entidades do projeto (ex.: Order)
│   └── /Observers            # Implementação do Observer Pattern
├── /Infrastructure           # Implementações de serviços e notificador
└── Program.cs                # Configuração principal da aplicação
/tests
└── SinqiaBank.Tests           # Projeto de testes unitários com xUnit
```

---

## **Contato**

- **Autor**: Pedro M L Nascimento  
- **E-mail**: darosepedro@gmail.com  
- **LinkedIn**: https://www.linkedin.com/in/pedro-nascimento-dotnet/ (https://www.linkedin.com/in/pedro-nascimento-dotnet/)

---

Com este projeto, buscamos demonstrar habilidades práticas e capacidade de implementar boas práticas no desenvolvimento de software. Se houver dúvidas ou sugestões, entre em contato!
