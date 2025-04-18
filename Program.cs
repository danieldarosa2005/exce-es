
System.Console.WriteLine("Entre com os dados");

System.Console.Write("Numero: ");
int numero = int.Parse(Console.ReadLine());

System.Console.Write("Titular: ");
string titular = Console.ReadLine();

System.Console.Write("Saldo inicial: ");
double saldoi = double.Parse(Console.ReadLine());

System.Console.Write("Limite: ");
double limite = double.Parse(Console.ReadLine());
Account account = new Account(numero, titular, saldoi, limite);

System.Console.Write("VALOR DO SAQUE: ");
double saque = double.Parse(Console.ReadLine());

try{
    account.Saque(saque);
    System.Console.Write(account.ToString());
}
catch (DomainException e) {
    System.Console.WriteLine("Erro! " + e.Message);
}
