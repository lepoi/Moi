using System;
using Gtk;

namespace Moi {
	public class Node {

		public int Id;
		public string Nombre;
		public double Latitud, Longitud;

		public Node(int id, string nombre, double lat, double lon) {
			Id = id;
			Nombre = nombre;
			Latitud = lat;
			Longitud = lon;		}
	}
}