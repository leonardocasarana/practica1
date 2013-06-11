using System;

namespace Herencias
{
	class Padre
	{
		public string frase;

		public void Metodo (){
			Console.WriteLine ("Heredando Metodo de la clase Padre");
		}
		public static void Main (string[] args)
		{
			Hija hija = new Hija ();
			hija.Herencia ();
		}
	}
}
