using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp1
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();
		

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
		
		public void preOrden(){
			foreach(var hijo in this.getHijos())
				hijo.preOrden();
			
			Console.Write("["+this.getDatoRaiz()+"]");
				
		}
		
		public int cantHojas(){
			int hojas=9;
			if(this.esHoja()==true){
				hojas++;
			}

			foreach(var hijo in this.getHijos())
				hijo.cantHojas();
				
			
			return hojas;
		}
	
		//public int altura() {
			//return 0;
		//}
		
		
		//public int nivel(T dato) {
			//return 0;
		//}
	
	}
}
