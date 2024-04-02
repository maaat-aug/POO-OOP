using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativ1
{
    public class ContaBancaria
    {
        public double Saldo;
        public string NumeroConta = "046466";
        public string Titular = "Matheus Augusto";
        public void depositar()
        {
            Console.WriteLine("Digite o valor pra depositar: ");
            double depositar = double.Parse(Console.ReadLine());
            if (depositar < 0)
            {
                Console.Clear();
                Console.WriteLine("Valor invalido, não foi possivel concluir o processo.");
                Console.WriteLine("Seu saldo continua sendo: " + Saldo + ".");
                Console.WriteLine(" ");
            }
            else
            {
                Saldo = +depositar;
                Console.Clear();
                Console.WriteLine("Você depositou: " + depositar);
                Console.WriteLine("Seu saldo agora é: " + Saldo + ".");
                Console.WriteLine(" ");
            }

        }
        public void sacar()
        {
            Console.WriteLine("Digite o valor pra sacar: ");
            double sacar = double.Parse(Console.ReadLine());
            if (sacar > Saldo || sacar < 0)
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Seu saldo atual é: " + Saldo + ".");
                Console.WriteLine(" ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Voce sacou " + sacar);
                Saldo = Saldo - sacar;
                Console.WriteLine("Seu saldo agora é: " + Saldo + ".");
                Console.WriteLine(" ");
            }
        }

        public void obterSaldo()
        {
            Console.Clear();
            Console.WriteLine("Seu saldo é: " + Saldo);
            Console.WriteLine(" ");
        }

        public void obterNumeroConta()
        {
            Console.Clear();
            Console.WriteLine("O número da sua conta é: " + NumeroConta);
            Console.WriteLine(" ");
        }

        public void obterTitularConta()
        {
            Console.Clear();
            Console.WriteLine("O titular da sua conta é: " + Titular);
            Console.WriteLine(" ");
        }
    }
}
