# ⚡ Apagão Cidadão

Sistema em C# para **registro e monitoramento de falhas e alertas relacionados a quedas de energia**, com foco em fornecer uma interface simples via console para operadores de campo ou analistas ambientais.

---

## 🛠️ Funcionalidades

- 📌 **Registrar Falha de Energia** com descrição, tipo, local e data.
- 🚨 **Gerar Alerta Crítico** com nível de criticidade.
- 📋 **Listar todos os eventos registrados**.
- 🔎 **Validações de dados** (ex: campos obrigatórios, datas no futuro).
- 🧾 **Logs** com mensagens e erros em tempo real.

---

## 📁 Estrutura do Projeto

```
apagao-cidadao-api-csharp/
│
├── Models/                # Modelos de dados dos eventos
│   ├── EventoBase.cs
│   ├── EventoRegistro.cs
│   ├── EventoAlerta.cs
│   └── EventoValidacao.cs
│
├── Interface/
│   └── IEventoRepository.cs  # Interface do repositório
│
├── Repository/
│   └── EventoRepository.cs   # Implementação em memória
│
├── Services/
│   └── EventoService.cs      # Camada de negócio
│
├── Utils/
│   ├── Logger.cs             # Utilitário de log e erros
│   └── Menu.cs               # Interface de console
│
├── Program.cs                # Ponto de entrada da aplicação
└── apagao-cidadao-api-csharp.csproj  # Arquivo de projeto .NET
```

---

## 🚀 Como Executar

> Requisitos: [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

```bash
git clone https://github.com/apagao-cidadao-corp/apagao-cidadao-api-csharp.git
cd apagao-cidadao-api-csharp
dotnet run
```

---

## 💻 Telas do Console

```plaintext
=== Apagão Cidadão ===
1. Registrar Falha de Energia
2. Gerar Alerta Crítico
3. Listar Eventos
0. Sair
```

---

## 🧠 Lógica de Domínio

- **EventoBase.cs** é uma classe abstrata com os atributos comuns.
- **EventoRegistro.cs** e **EventoAlerta.cs** herdam de `EventoBase`.
- O **EventoValidacao.cs** garante integridade dos dados antes do registro.

---

## 📝 Exemplo de Uso

Registrar uma falha:

```
Local: Zona Norte
Descrição: Queda de energia após tempestade
Tipo de falha: Curto-circuito
Data: 2025-05-30
```

---

## 📄 Licença

Projeto acadêmico desenvolvido para a FIAP - Global Solution 2025.