class Conta {
    public int Numero { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public double LimiteDeSaque { get; set; }
    public Conta(){

    }
    public Conta(int numero, string titular, double saldo, double limitedesaque) {
         Numero = numero;
         Titular = titular;
         Saldo = saldo;
         LimiteDeSaque = limitedesaque;
    }
    public void Deposito(double quantia) {
        if (quantia <= 0)
        {
            throw new DomainException("A quantia deve ser maior que zero");
        }
        Saldo = Saldo + quantia;
    }
    public void Saque (double quantia) {
        if (quantia > LimiteDeSaque)
        {
            throw new DomainException("Limite não disponível");
        }
        if (quantia > Saldo)
        {
            throw new DomainException("Não há saldo na conta");
        }
        Saldo = Saldo - quantia;
    }
    public override string ToString()
    {
        return "Novo saldo: " +
        Saldo.ToString("F2");
    }
}