using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProdutoLimpeza
{
    public class Avaliador
    {
        static void Main(String[] args)
        {
            UnitTest1 teste = new UnitTest1();
            var sim = teste.VerificarDadosPedido();

            if (sim)
            {
                Console.WriteLine("OK {0}", sim);
            }else
                Console.WriteLine("false {0}", sim);


            Console.ReadKey();
        }

    }
}
