using System.Globalization;

namespace PrimeiroProjeto
{
    class ContaBancaria
    {
        public int Numero { get; private set; }

        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public static double Taxa = 5.00;

        public ContaBancaria (int numero, string titular, double depositoInicial)
        {
            Deposito(depositoInicial);
        }

        public ContaBancaria (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + Taxa;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
