# dopNetPix

## 📌 Descrição

O `dopNetPix` é um projeto voltado à **simulação e integração de transações via PIX**, criado com a stack **.NET**. Ele fornece uma base sólida para testar, integrar e evoluir sistemas financeiros que lidam com pagamentos instantâneos — permitindo uma abordagem inicial simples e uma arquitetura extensível para crescimento futuro.

A ideia central é oferecer uma interface **mockada (fake)** de um serviço de integração PIX, ideal para:

- Times de desenvolvimento testarem fluxos sem dependência de ambientes reais;
- Simulações de cenários de pagamento, recebimento e notificação;
- Evolução para microserviços com mensageria e observabilidade.

---

## ✨ Funcionalidades

- ✅ Simulação de envio e recebimento de PIX (mock API)
- ✅ Geração de QR Code estático e dinâmico
- ✅ Webhooks de notificação de pagamento
- ✅ Modularização por camadas (API, Application, Domain, Infrastructure)
- 📈 Suporte a OpenTelemetry para futura observabilidade
- 🚀 Estrutura preparada para evoluir com microserviços

---

## 🛠️ Tecnologias

- [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api/)
- [MongoDB ou PostgreSQL](https://www.mongodb.com/) *(opcional para persistência simulada)*
- [Docker](https://www.docker.com/)
- [OpenTelemetry (.NET)](https://opentelemetry.io/docs/instrumentation/net/)
- [RabbitMQ ou Redis Pub/Sub (futuro)](https://www.rabbitmq.com/)
- [xUnit ou NUnit](https://xunit.net/) para testes automatizados

---

## 🗂️ Estrutura de Diretórios

```bash
dopNetPix/
│
├── src/
│   ├── API/                # Endpoints RESTful e documentação Swagger
│   ├── Application/        # Casos de uso e DTOs
│   ├── Domain/             # Entidades, interfaces e regras de negócio
│   ├── Infrastructure/     # Acesso a dados, serviços externos e mocks
│   └── Shared/             # Utilitários comuns e configurações globais
│
├── tests/                  # Testes unitários e de integração
├── docker-compose.yml      # Subida local com MongoDB/PostgreSQL
├── .github/workflows/      # CI/CD com GitHub Actions
└── README.md
```

---

## 🚧 Roadmap

* [x] Versão mínima funcional com simulação de PIX
* [ ] Implementar autenticação via API Key
* [ ] Adicionar suporte a mensagens assíncronas (ex: RabbitMQ)
* [ ] Criar arquitetura de microserviços com API Gateway
* [ ] Adicionar observabilidade com OpenTelemetry + Jaeger
* [ ] Desenvolver Painel de Monitoramento (Blazor ou React)

---

## 🤝 Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir *issues*, propor melhorias ou usar este projeto como base para seus estudos e integrações reais com o ecossistema do PIX.

---

## 📬 Contato

Se você trabalha com .NET moderno e deseja dominar arquitetura, C#, DevOps ou interoperabilidade, vamos conversar:

* 💼 [LinkedIn](https://www.linkedin.com/in/daniloopinheiro)
* ✍️ [Medium](https://medium.com/@daniloopinheiro)
* 💻 [Dev.to](https://dev.to/daniloopinheiro)
* 🌐 [shifters.dev](https://shifters.dev/daniloopinheiro)
* 📬 [contato@dopme.io](mailto:contato@dopme.io)

---

## 📜 Licença

MIT License © 2025 [dopme.io](https://dopme.io) — por [Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro/)

---

<p align="center"> Feito com ❤️ por <strong>Danilo O. Pinheiro</strong><br/> <a href="https://devsfree.com.br" target="_blank">DevsFree</a> • <a href="https://dopme.io" target="_blank">dopme.io</a> </p>
