using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGHSS_Core;
using System;

namespace SGHSS_Testes
{
    [TestClass]
    public class ConsultaTests
    {
        // CT004: Agendamento com Sucesso
        [TestMethod]
        public void CT004_AgendarConsulta_DataFutura_DeveRetornarSucesso()
        {
            // Arrange: Data de amanhã
            var dataFutura = DateTime.Now.AddDays(1);
            var consulta = new Consulta(dataFutura, "Maria Souza", "Cardiologia");

            // Act
            var resultado = consulta.Agendar();

            // Assert
            Assert.IsTrue(resultado, "A consulta deveria ser agendada com sucesso.");
        }

        // CT005: Tentar Agendar no Passado (Falha)
        [TestMethod]
        public void CT005_AgendarConsulta_DataPassada_DeveLancarErro()
        {
            // Arrange: Data de ontem
            var dataPassada = DateTime.Now.AddDays(-1);
            var consulta = new Consulta(dataPassada, "Maria Souza", "Dermato");

            // Act & Assert
            try
            {
                consulta.Agendar();
                Assert.Fail("O sistema permitiu agendar no passado!");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Erro: A data da consulta deve ser futura.", ex.Message);
            }
        }
    }
}