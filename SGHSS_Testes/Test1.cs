using Microsoft.VisualStudio.TestTools.UnitTesting;
// ATENÇÃO: Se o nome do seu projeto principal não for SGHSS_Core,
// altere a linha abaixo para: using NomeDoSeuProjeto;
using SGHSS_Core;
using System;

namespace SGHSS_Testes
{
    [TestClass]
    public class PacienteTests
    {
        // CT001: Cadastro de Paciente com Sucesso
        [TestMethod]
        public void CT001_CadastrarPaciente_ComDadosValidos_DeveRetornarSucesso()
        {
            // Arrange (Preparação)
            var paciente = new Paciente("João da Silva", "123.456.789-00", new DateTime(1990, 1, 1));

            // Act (Ação)
            var resultado = paciente.Cadastrar();

            // Assert (Verificação)
            Assert.IsTrue(resultado, "O paciente deveria ser cadastrado com sucesso.");
        }

        // CT002: Validação de CPF Inválido
        [TestMethod]
        public void CT002_CadastrarPaciente_ComCpfInvalido_DeveLancarErro()
        {
            // Arrange
            var paciente = new Paciente("Teste Erro", "000", DateTime.Now);

            // Act & Assert (Ação e Verificação juntas para Exceção)
            try
            {
                paciente.Cadastrar();
                Assert.Fail("O teste falhou: O sistema aceitou um CPF inválido!");
            }
            catch (ArgumentException ex)
            {
                // Verifica se a mensagem de erro é a que definimos na classe Paciente
                Assert.AreEqual("CPF Inválido: Deve conter 11 dígitos.", ex.Message);
            }
        }
    }
}