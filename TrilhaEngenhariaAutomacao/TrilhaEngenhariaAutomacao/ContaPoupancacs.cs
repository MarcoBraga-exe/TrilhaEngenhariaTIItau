using System;
using System.Collections.Generic;
using System.Linq;

public class ContaPoupanca
{
    public string nomeDonoContaPoupanca { get; set; }
    public double valorContaPoupanca { get; set; }
    public double Deposito(double deposito)
    {
        return valorContaPoupanca + deposito;
    }
    public double Saque(double saque)
    {
        return valorContaPoupanca - saque;
    }

}
