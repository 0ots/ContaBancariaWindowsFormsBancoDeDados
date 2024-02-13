using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaWindowsForms
{
    internal class Titular
    {
        // Atributos
        private string _nome;
        private string _senha;
        private string _email;
        private string _telefone;
        private string _cpf;
        private double _saldo;
        // Propriedades automatizadas para obter e definir valores dos atributos
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = value;
            }
        }
        public string Cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        // Construtor da classe
        public Titular(string nome, string senha, string email, string telefone, string cpf)
        {
            Nome = nome;
            Senha = senha;
            Email = email;
            Telefone = telefone;
            _cpf = cpf;
            Saldo = 0.00;
        }
        // Método para retornar a string de inserção do titular
        public string InserirTitular()
        {
            return $"INSERT INTO titular(nome, senha, email, telefone, cpf, saldo) VALUES('{Nome}', '{Senha}','{Email}', '{Telefone}', '{Cpf}', '{Saldo}')";
        }
        // Método para retornar a string atualização dos dados do titular
        public string AlterarDadosTitular()
        {
            return $"UPDATE titular SET nome = '{Nome}', email = '{Email}', telefone = '{Telefone}'";
        }
        // Método para retornar a string de atualização de senha do titular
        public string AlterarSenhaTitular()
        {
            return $"UPDATE titular SET senha = '{Senha}'";
        }
        // Método para retornar a string de deleção do titular
        public string DeletarTitular()
        {
            return $"DELETE FROM usuario where id = ''";
        }
        // Método para retornar a string de consulta do saldo do titular
        public string RetornarSaldoTitular()
        {
            return "SELECT saldo FROM titular where id = ''";
        }
        // Método para retornar a string de consulta dos dados de um titular específico a partir de seu id
        public string RetornarDadosTitularEspecifico()
        {
            return "SELECT nome, email, telefone, saldo FROM usuario where id = ''";
        }
        // Método para retornar a string de consulta dos dados de todos os titulares
        public string RetornarDadosTodosTitulares()
        {
            return $"SELECT nome, email, telefone, saldo FROM usuario";
        }
        // Méotodo para retornar a string de consulta do saldo de um titular específico a partir de seu id
        public string RetornarSaldoFuncionario()
        {
            return $"SELECT valor FROM titular where id = ''";
        }
        // Método para realizar um depósito recebendo um valor como parâmetro
        public string RealizarDeposito(double valor)
        {
            Saldo += valor;
            return $"UPDATE titular SET saldo = '{valor}' where id = ''";
        }
        // Método para realizar um saque recebendo um valor como parâmetro
        public string RealizarSaque(double valor)
        {
            Saldo -= valor;
            return $"UPDATE titular SET saldo = '{valor}' where id = ''";
        }
    }
}