using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 1
            //ExecutaAula1();

            // Aula 2
            //ExecutaAula2();

            // Aula 3
            //ExecutaAula3();

            // Aula 4
            //ExecutaAula4();

            // Aula 5
            //ExecutaAula5();

            // Aula 6
            //ExecutaAula6();

            // Aula 7
            //ExecutaAula7();

            // Aula 8
            //ExecutaAula8();

            // Aula 9 (Não vai compilar)
            //ExecutaAula9();
        }

        private static void ExecutaAula9()
        {
            //// Exemplo como seria antes
            //String cpf = "1234";

            //Cliente cliente = new ClienteDAO().BuscaPorCpf(cpf);

            //Fatura fatura = new Fatura(cliente, 5000);

            //Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            //cobranca.Emite();

            //ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            //contato.Dispara();

            //// Como ficaria depois

            //String cpf = "1234";

            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(tipo.Boleto, fatura);
        }

        private static void ExecutaAula8()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Lucas";
            cliente.Endereco = "Rua Verde";
            cliente.DataNascimento = DateTime.Now;

            String xml = new GeradorXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }

        private static void ExecutaAula7()
        {
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Rico", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }

        private static void ExecutaAula6()
        {
            IMensagem mensagem = new MensagemAdministrativa("Lucas");
            IEnviador enviador = new EnviaPorSMS();

            mensagem.Enviador = enviador;
            mensagem.Envia();
            Console.WriteLine();

            mensagem = new MensagemCliente("Lucas");
            mensagem.Enviador = enviador;
            mensagem.Envia();
            Console.WriteLine();

            enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }

        private static void ExecutaAula5()
        {
            // ((1 + 10) + (20 - 10))
            // + 1 100
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            ImpressoraVisitor impressora = new ImpressoraVisitor();
            PreFixaVisitor prefixa = new PreFixaVisitor();

            soma.Aceita(impressora);
            Console.WriteLine(" = " + soma.Avalia());

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            esquerda = new Soma(new Numero(1), new Numero(10));
            direita = new Divisao(new Numero(20), new Numero(10));
            IExpressao exp = new Multiplicacao(esquerda, direita);
            exp = new RaizQuadrada(exp);

            exp.Aceita(impressora);
            Console.WriteLine(" = " + exp.Avalia());
            Console.WriteLine("Pre-fixa:");
            exp.Aceita(prefixa);
            Console.WriteLine(" = " + exp.Avalia());
        }

        private static void ExecutaAula4()
        {
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            IExpressao mult = new Multiplicacao(esquerda, direita);
            Console.WriteLine(mult.Avalia());
            IExpressao div = new Divisao(esquerda, direita);
            Console.WriteLine(div.Avalia());
            IExpressao rq = new RaizQuadrada(div);
            Console.WriteLine(rq.Avalia());

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());
        }

        private static void ExecutaAula3()
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Lucas", TipoContrato.Novo);
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
        }

        private static void ExecutaAula2()
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("re"),
                notas.Pega("re"),

                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("mi"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };
            Piano piano = new Piano();
            piano.Toca(musica);
        }

        private static void ExecutaAula1()
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM TABELA";
        }
    }
}
