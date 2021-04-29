using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolGeneral<int> arbol1 = new ArbolGeneral<int>(1);
			
			ArbolGeneral<int> arbol2 = new ArbolGeneral<int>(2);
			ArbolGeneral<int> arbol3 = new ArbolGeneral<int>(3);
			ArbolGeneral<int> arbol4 = new ArbolGeneral<int>(4);
			
			ArbolGeneral<int> arbol5 = new ArbolGeneral<int>(5);
			ArbolGeneral<int> arbol6 = new ArbolGeneral<int>(6);
			ArbolGeneral<int> arbol7 = new ArbolGeneral<int>(7);
		
			ArbolGeneral<int> arbol8 = new ArbolGeneral<int>(8);
			ArbolGeneral<int> arbol9 = new ArbolGeneral<int>(9);
			ArbolGeneral<int> arbol10 = new ArbolGeneral<int>(10);
			
			ArbolGeneral<int> arbol11 = new ArbolGeneral<int>(11);
			ArbolGeneral<int> arbol12 = new ArbolGeneral<int>(12);
			ArbolGeneral<int> arbol13 = new ArbolGeneral<int>(13);
			
			arbol1.agregarHijo(arbol2);
			arbol1.agregarHijo(arbol3);
			arbol1.agregarHijo(arbol4);
			
			arbol2.agregarHijo(arbol5);
			arbol2.agregarHijo(arbol6);
			arbol2.agregarHijo(arbol7);
			
			arbol3.agregarHijo(arbol8);
			arbol3.agregarHijo(arbol9);
			arbol3.agregarHijo(arbol10);
			
			arbol4.agregarHijo(arbol11);
			arbol4.agregarHijo(arbol12);
			arbol4.agregarHijo(arbol13);
		
			arbol1.preOrden();
			Console.WriteLine("\n"+arbol1.cantHojas());
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}