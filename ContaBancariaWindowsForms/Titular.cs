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
        // Construtor
        public Titular(string nome, string email, string telefone, string cpf)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            _cpf = cpf;
            Saldo = 0.00;
        }
        // Método para realizar cadastrar um titular no banco de dados
        public string InserirTitular()
        {
            return $"INSERT INTO titular(nome, email, telefone, cpf, saldo) VALUES('{Nome}', '{Email}', '{Telefone}', '{_cpf}', '{Saldo}')";
        }
        // Método para alterar dados do titular
        public string AlterarTitular()
        {
            return $"UPDATE titular SET nome = '{Nome}', email = '{Email}', telefone = '{Telefone}'";
        }
        // Método para deletar um funcionário específico
        public string DeletarTitular()
        {
            return $"DELETE FROM usuario where id = ''";
        }
        // Método para retornar todos os dados de um titulare específico
        public string RetornarDadosFuncionario()
        {
            return "SELECT nome, email, telefone, saldo FROM usuario where id = ''";
        }
        //  Método para retornar todos os dados de todos os titulares
        public string RetornarDadosFuncionarios()
        {
            return $"SELECT nome, email, telefone, saldo FROM usuario";
        }
        //
        public string RetornarSaldoFuncionario()
        {
            return $"SELECT valor FROM titular where id = ''";
        }
        // Método para realizar um depósito recebendo um valor como parâmetro
        public void RealizarDeposito(double valor)
        {
            Saldo += valor;
        }
        // Método para realizar um saque recebendo um valor como parâmetro
        public void RealizarSaque(double valor)
        {
            Saldo -= valor;
        }
    }
}