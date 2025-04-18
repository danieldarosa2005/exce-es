class Account {
    public int Numero { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public double LimiteDeSaque { get; set; }
    public Account(){

    }
    public Account(int numero, string titular, double saldo, double limitedesaque) {
         Numero = numero;
         Titular = titular;
         Saldo = saldo;
         LimiteDeSaque = limitedesaque;
    }
    public void Deposito(double quantia) {
        Saldo = Saldo + quantia;
    }
    public void Saque (double quantia) {
        if (quantia > Saldo)
        {
            throw new DomainException("Não há saldo na conta");
        }
        if (quantia > LimiteDeSaque)
        {
            throw new DomainException("Limite não disponível");
        }
        Saldo = Saldo - quantia;
    }
    public override string ToString()
    {
        return "Novo saldo: " +
        Saldo.ToString();
    }
}