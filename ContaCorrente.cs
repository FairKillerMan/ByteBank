using ByteBank;
public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
 
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            destino.Depositar(valor);
            return true;
        }
    }
}


