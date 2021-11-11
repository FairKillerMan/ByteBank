using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();


            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedor c#";
            gabriela.cpf = "434.562.878-20";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5364736;

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
/*
Descrição: Controle de contas-correntes, que para o gerenciamento de um banco é algo recorrente e natural.

número da agência; número da conta*; titular*; saldo*;
pacote de serviços; juros; cheque especial; entre outros.
*/
