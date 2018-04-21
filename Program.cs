using System;

namespace Listas
{

	class ListaEnlazada
	{
		private class Nodo
		{
			public int dato;
			public Nodo sig;

			public Nodo(int e)
			{
				dato = e;
			}
		}
		Nodo pri;
		public ListaEnlazada()
		{
			pri = null;
		}

		public void InsertaIni(int e)
		{
			Nodo ini = new Nodo(e);
			if (pri != null)
				ini.sig = pri.sig;
			pri = ini;
		}

		public void InertaFinal(int e)
		{
			if (pri != null)
			{
				Nodo aux = pri;
				while (aux.sig != null)
				{
					aux = aux.sig;
				}
				aux.sig = new Nodo(e);
				aux.sig.sig = null;
			}
			else
				InsertaIni(e);
		}

		public void VerLista()
		{
			if (pri != null)
			{
				Nodo aux = pri;
				Console.WriteLine();
				while (aux.sig != null)
				{
					aux = aux.sig;
					Console.WriteLine(aux.dato);
				}
			}
		}
	}


	class MainClass
	{
		static void Main()
		{
			ListaEnlazada lista = new ListaEnlazada();
			while (true)
			{
				switch (int.Parse(Console.ReadLine()))
				{
					case 1:
						lista.InsertaIni(int.Parse(Console.ReadLine()));
						break;
					case 2:
						lista.InertaFinal(int.Parse(Console.ReadLine()));
						break;
				    case 3:
						lista.VerLista();
						break;
				}
			}
		}
	}
}