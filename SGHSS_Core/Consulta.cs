using System;

namespace SGHSS_Core
{
    public class Consulta
    {
        public DateTime DataConsulta { get; set; }
        public string NomePaciente { get; set; }
        public string Especialidade { get; set; }

        public Consulta(DateTime dataConsulta, string nomePaciente, string especialidade)
        {
            DataConsulta = dataConsulta;
            NomePaciente = nomePaciente;
            Especialidade = especialidade;
        }

        // Simula o agendamento (RF002)
        public bool Agendar()
        {
            // Regra de Negócio: Não pode agendar consulta no passado
            if (DataConsulta < DateTime.Now)
            {
                throw new ArgumentException("Erro: A data da consulta deve ser futura.");
            }

            // Regra de Negócio: Nome do paciente é obrigatório
            if (string.IsNullOrWhiteSpace(NomePaciente))
            {
                throw new ArgumentException("Erro: Paciente não identificado.");
            }

            // Se passou, "salva" no banco
            return true;
        }
    }
}