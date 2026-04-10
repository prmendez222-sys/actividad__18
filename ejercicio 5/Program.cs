Usuario u = new Usuario();

u.Contrasena = "abc";
Console.WriteLine(u.Contrasena);
class Usuario
{
    private string contrasena;

	public String Contrasena
	{
		get 
		{
			if (contrasena.Length >= 8) return "*********";
			else return "Contrasena insegura";
		}
		set { contrasena = value; }
	}

}