using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
