Producto p = new Producto();

p.Precio = 10;
Console.WriteLine(p.Precio);
class Producto
{
	private double precio;

	public  double Precio
	{
		get 
		{
			if (precio > 0) return precio;
			else return 0;
		}
		set { precio = value; }
	}

}