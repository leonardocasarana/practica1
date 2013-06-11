using System;
namespace Herencias
{
	class Hija: Padre
	{

		public void Herencia (){
			Hija herencia = new Hija ();
			herencia.frase = "Heredando Variable de la clase Padre";
			Console.WriteLine (herencia.frase);
			herencia.Metodo ();

		}
	}
}