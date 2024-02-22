using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            Cpf = cpf;
            Saldo = 0.00;
        }
        // Contrutor vazio para apenas criar um objeto e utilizar os métodos
        public Titular()
        {

        }
        // Método para retornar a string de inserção do titular
        public string InserirTitular()
        {
            return $"INSERT INTO titular(nome, senha, email, telefone, cpf, saldo) VALUES('{Nome}', '{Senha}','{Email}', '{Telefone}', '{Cpf}', '{Saldo.ToString("F2", CultureInfo.InvariantCulture)}')";
        }
        // Método para atualizar dados

        // Método para retornar a string de deleção do titular
        public string DeletarTitular(int userID)
        {
            return $"DELETE FROM usuario where id = '{userID}'";
        }
        // Método para retornar a string de consulta do saldo do titular
        public string RetornarSaldoTitular(int userID)
        {
            return $"SELECT saldo FROM titular where id = '{userID}'";
        }
        // Método para retornar a string de consulta dos dados de um titular específico a partir de seu id
        public string RetornarDadosTitularEspecifico(int userID)
        {
            return $"SELECT nome, email, telefone, saldo FROM usuario where id = '{userID}'";
        }
        // Método para retornar a string de consulta dos dados de todos os titulares
        public string RetornarDadosTodosTitulares()
        {
            return $"SELECT nome, email, telefone, saldo FROM usuario";
        }
        // Método para realizar um depósito recebendo um valor como parâmetro
        public string RealizarDeposito(double valor, int userID)
        {
            return $"UPDATE titular SET saldo = '{valor}' WHERE id = '{userID}'";
        }
        // Método para realizar um saque recebendo um valor como parâmetro
        public string RealizarSaque(double valor, int userID)
        {
            return $"UPDATE titular SET saldo = '{valor}' WHERE id = '{userID}'";
        }


        public string ObterNome(int userID)
        {
            return $"SELECT nome from titular where id = {userID}";
        }
        public string ObterSenha(int userID)
        {
            return $"SELECT senha from titular where id = {userID}";
        }
        public string ObterEmail(int userID)
        {
            return $"SELECT email from titular where id = {userID}";
        }
        public string ObterTelefone(int userID)
        {
            return $"SELECT telefone from titular where id = {userID}";
        }
        public string AlterarDados(string nome, string senha, string email, string telefone, int userID)
        {
            return $"UPDATE titular SET nome = '{nome}', senha = '{senha}', email = '{email}', telefone = '{telefone}' WHERE id = '{userID}'";
        }
    }
}