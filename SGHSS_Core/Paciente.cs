using System;
using System.Collections.Generic;

namespace SGHSS_Core
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        // Construtor
        public Paciente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        // Método que simula o cadastro e validação
        public bool Cadastrar()
        {
            // Validação simples: Nome não pode ser vazio
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new ArgumentException("O nome do paciente é obrigatório.");
            }

            // Validação simples: CPF deve ter 11 dígitos (Simulação do CT002)
            // Remove pontos e traços para contar apenas números
            var cpfLimpo = Cpf.Replace(".", "").Replace("-", "");

            if (cpfLimpo.Length != 11)
            {
                throw new ArgumentException("CPF Inválido: Deve conter 11 dígitos.");
            }

            // Se passou por tudo, retorna verdadeiro (Sucesso - CT001)
            return true;
        }
    }
}