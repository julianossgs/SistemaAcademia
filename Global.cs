using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Global
    {
        public static string versao = "1.0";
        public static bool logado = false;
        public static int nivel = 0;
        public static string userName;
        public static string senha;
        public static string cargo;
        public static string usuario;
       
        //variáveis do cadastro de turmas
        public static string idturma;
        public static string descricaoTurma;
        public static string nomeProfessor;
        public static string horario;
        public static int maxAlunos;
        public static string status;

        //variáveis do cadastro de alunos
        public static string idAluno;
        public static string nomeAluno;
        public static string telefoneAluno;
        public static string statusAluno;
        public static string emailAluno;
        public static string turmaAluno;
        public static byte[] imagemAluno;

        //variáveis do cadastro de forneçedores
        public static string idFornec;
        public static string nomeFornecedor;
        public static string enderecoFornecedor;
        public static string telFornecedor;
        public static string emailFornecedor;
        public static string contatoFornecedor;
        public static string cnpjFornecedor;

        //variáveis do cadastro de produtos
        public static string chamadaProdutos;
        public static string idproduto;
        public static string nomeProduto;
        public static string unidProduto;
        public static string estoqueProduto;
        public static decimal precoCustoProduto;
        public static decimal precoVendaProduto;
        public static string dataCompraProduto;

        //Variáveis do cadastro de planos
        public static string idplano;
        public static string nomePlano;
        public static string valorPlano;
        public static string vencimentoPlano;
        public static string descricaoPlano;

        //Variáveis do cadastro de saidas
        public static string idsaida;
        public static DateTime dataSaida;
        public static string tipoSaida;
        public static string descricaoSaida;
        public static decimal valorSaida;

        //Variáveis do cadastro de entradas
        public static string identrada;
        public static DateTime dataEntrada;
        public static string tipoEntrada;
        public static string descricaoEntrada;
        public static decimal valorEntrada;

        //Variáveis do cadastro de contas a pagar
        public static string idcontaspagar;
        public static decimal valorContasPagar;
        public static DateTime dataContasPagar;
        public static string tipoContasPagar;
        public static string descricaoContasPagar;
    }
}
