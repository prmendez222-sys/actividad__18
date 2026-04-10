Empleado e = new Empleado();

e.Salario = 3000;

if (e.Salario == 0)
{
    Console.WriteLine("salario no valido");
}
else
{
    Console.WriteLine(e.Salario);
}
class Empleado
{
    private double salario;

    public double Salario
    {
        get
        {
            if (salario >= 3500) return salario;
            else return 0;
        }
        set { salario = value; }
    }

}