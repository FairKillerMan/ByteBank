using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContaCorrente();
            ContaCorrente contaDoBanco = new ContaCorrente();
            contaDoBanco.titular = "Thiago";
            contaDoBanco.agencia = 863;
            contaDoBanco.numero = 255212;
            contaDoBanco.saldo = 3500;


            Console.WriteLine(contaDoBanco.titular);
            Console.WriteLine("Agência: " + contaDoBanco.agencia);
            Console.WriteLine("Saldo: " + contaDoBanco.saldo);
            contaDoBanco.saldo += 250;
            Console.WriteLine("Saldo: " + contaDoBanco.saldo);

            Console.ReadLine();
        }
    }
}

/*
Descrição: Controle de contas-correntes, que para o gerenciamento de um banco é algo recorrente e natural.

número da agência; número da conta*; titular*; saldo*;
pacote de serviços; juros; cheque especial; entre outros.
*/
