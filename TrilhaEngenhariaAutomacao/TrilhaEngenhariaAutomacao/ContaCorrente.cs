using System;
using System.Collections.Generic;
using System.Linq;

public class ContaCorrente
{
    public string nomeDonoConta { get; set; }
    public double valorContaCorrente { get; set; }
    public double Deposito(double deposito)
    {
        return valorContaCorrente + deposito;
    }
    public double Saque(double saque)
    {
        return valorContaCorrente - saque;
    }

}
