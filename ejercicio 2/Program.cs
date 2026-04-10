Estudiante e = new Estudiante();
e.Edad = 30;

Console.WriteLine(e.Edad);
class Estudiante
{
	private int edad;

	public int Edad
	{
		get 
		{ 
		    if(edad>=0 && edad<=100) return edad;
			else return 0;
		}
		set { edad = value; }
	}

}