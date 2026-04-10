
CuentaBancaria c = new CuentaBancaria();

c.Saldo = 0;

if (c.Saldo > 0) Console.WriteLine(c.Saldo);
else Console.WriteLine("Saldo no disponible");
class CuentaBancaria
{
	private double saldo;

	public double Saldo
	{
		get 
		{
			if (saldo > 0) return saldo;
			else return 0;
		}
		set { if (value > 0) saldo = value; }
	}
}