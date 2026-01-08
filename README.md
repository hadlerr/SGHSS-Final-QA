# 🏥 SGHSS - Sistema de Gestão Hospitalar (Módulo QA)

Este repositório contém a implementação prática e a suíte de testes do **Projeto Multidisciplinar de Análise e Desenvolvimento de Sistemas**.

O foco deste desenvolvimento foi a aplicação de conceitos de **Qualidade de Software (QA)**, **Engenharia de Requisitos** e **Segurança (LGPD)**, utilizando testes unitários automatizados para validar regras de negócio críticas.

---

## 🚀 Funcionalidades Implementadas

O projeto simula o *Back-End* das seguintes funcionalidades principais:

1.  **Cadastro de Pacientes (RF001):**
    * Validação de campos obrigatórios.
    * ✅ **Validação de CPF:** Algoritmo que impede o cadastro de CPFs com formato inválido ou numeração incorreta.
2.  **Agendamento de Consultas (RF002):**
    * Registro de consulta com data, paciente e especialidade.
    * ✅ **Bloqueio Retroativo:** Regra de negócio que impede o agendamento de consultas em datas passadas.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET)
* **Framework de Testes:** MSTest
* **IDE:** Visual Studio 2022
* **Controle de Versão:** Git & GitHub

---

## 🧪 Estratégia de Testes (QA)

Foram desenvolvidos testes unitários para garantir a robustez do sistema antes da entrega (abordagem *Shift-Left Testing*).

### Cenários Cobertos:

| ID | Cenário | Resultado Esperado | Status |
|---|---|---|---|
| **CT001** | Cadastro com dados válidos | Sucesso (True) | ✅ Aprovado |
| **CT002** | Cadastro com CPF inválido | Exceção `ArgumentException` | ✅ Aprovado |
| **CT004** | Agendamento em data futura | Sucesso (True) | ✅ Aprovado |
| **CT005** | Agendamento em data passada | Erro de validação | ✅ Aprovado |

---

## ⚙️ Como Executar o Projeto

Para validar os testes em sua máquina local:

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/hadlerr/SGHSS-Final-QA.git](https://github.com/hadlerr/SGHSS-Final-QA.git)

   Abra o projeto: Navegue até a pasta e abra o arquivo SGHSS_Core.sln no Visual Studio.

Execute os Testes:

Vá no menu Teste > Executar Todos os Testes.

Ou pressione Ctrl + R, A.

Verifique o Gerenciador de Testes para ver os resultados "Verdes".

📄 Contexto Acadêmico
Curso: Análise e Desenvolvimento de Sistemas

Disciplina: Projeto Integrador Multidisciplinar

Ênfase: Qualidade de Software e Testes

Ano: 2025/2026

Desenvolvido com foco em Clean Code e boas práticas de QA.