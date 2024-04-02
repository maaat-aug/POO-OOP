using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ1
{
    public class Caixa
    {
        ContaBancaria contabancaria = new ContaBancaria();
        int n = 1;

        public void caixa()
        {
            while (n == 1)
            {
                Console.WriteLine("Escolha uma opção:\n1-Sacar\n2-Depositar\n3-Ver Saldo\n4-Ver Titular\n5-Ver Número da Conta\n0-Sair do banco");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        contabancaria.sacar();
                        break;
                    case 2:
                        contabancaria.depositar();
                        break;
                    case 3:
                        contabancaria.obterSaldo();
                        break;
                    case 4:
                        contabancaria.obterTitularConta();
                        break;
                    case 5:
                        contabancaria.obterNumeroConta();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Volte sempre!");
                        n = 0;
                        break;


                }
            }

        }
    }
}
