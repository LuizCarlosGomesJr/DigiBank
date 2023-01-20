using DigiBank.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiBank.Contratos
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        double ConsultaSaldo();
        string GetCodigoDoBanco();
        string GetNumeroDaAgencia();
        string GetNumeroDaConta();
        List<Extrato> Extrato();
    }
}
