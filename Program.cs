
System.Console.WriteLine("Entre com os dados");

System.Console.Write("Numero: ");
int numero = int.Parse(Console.ReadLine());

System.Console.Write("Titular: ");
string titular = Console.ReadLine();

System.Console.Write("Saldo inicial: ");
double saldoi = double.Parse(Console.ReadLine());

System.Console.Write("Limite: ");
double limite = double.Parse(Console.ReadLine());
Conta conta = new Conta(numero, titular, saldoi, limite);

System.Console.WriteLine("Você deseja SACAR (s) ou DEPOSITAR (d)?");
char escolha = char.Parse(Console.ReadLine());

if (escolha == 's')
{
    System.Console.Write("Valor do saque: ");
    double saque = double.Parse(Console.ReadLine());

try {
    conta.Saque(saque);
    System.Console.Write(conta.ToString());
}
catch (DomainException e) {
    System.Console.WriteLine("Erro! " + e.Message);
}
} 
else if (escolha == 'd')
{
    System.Console.Write("Valor do depósito: ");
    double deposito = double.Parse(Console.ReadLine());

try {
    conta.Deposito(deposito);
    System.Console.Write(conta.ToString());
    }
    catch (DomainException d) {
        System.Console.WriteLine("Erro! " + d.Message);
    }  
}
else
{
    System.Console.WriteLine("Dígito errado!");
}

