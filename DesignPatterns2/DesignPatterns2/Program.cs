using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
