using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using Gtk;
using MySql.Data;
using MySql.Data.MySqlClient;
using Moi;
using System.Windows.Forms;

public partial class MainWindow : Gtk.Window {

	string ConnectionString, query, query2;
	MySqlConnection Dbcon, Dbcon2;
	MySqlCommand Dbcmd, Dbcmd2;
	IDataReader reader,reader2;
	Graph graph;
	List<Node> nodes;
	Dictionary<Node, int> edges;
	double lat, lon;
	Node aux;

	public MainWindow() : base(Gtk.WindowType.Toplevel) {
		
		ConnectionString =
			"Server=localhost;" +
			"Database=Grafo;" +
			"User ID=poi;" +
			"Password=poi;" +
			"Pooling=false";

		Dbcon = new MySqlConnection(ConnectionString);
		Dbcon2 = new MySqlConnection(ConnectionString);

		Update();

		Build();
	}
	protected Node SearchNodeById(List<Node> list, int id) {
		foreach (Node node in list)
			if (node.Id == id)
				return node;
		return null;
	}
	protected void Update() {
		Dbcon.Open();
		Dbcmd = Dbcon.CreateCommand();
		query = "SELECT * FROM Nodo;";
		Dbcmd.CommandText = query;
		reader = Dbcmd.ExecuteReader();
		graph = new Graph();
		nodes = new List<Node>();

		while (reader.Read()) {
			nodes.Add(new Node(Int32.Parse(reader["idNodo"].ToString()), reader["nombre"].ToString(), double.Parse(reader["latitud"].ToString()), double.Parse(reader["longitud"].ToString())));
		}
		Dbcon.Close();
		Dbcon.Open();
		reader = Dbcmd.ExecuteReader();

		while (reader.Read()) {

			aux = new Node(Int32.Parse(reader["idNodo"].ToString()), reader["nombre"].ToString(), double.Parse(reader["latitud"].ToString()), double.Parse(reader["longitud"].ToString()));

			Dbcon2.Open();
			Dbcmd2 = Dbcon2.CreateCommand();
			query2 = "SELECT * FROM Arista WHERE nodoIni = " + reader["idNodo"] + ";";
			Dbcmd2.CommandText = query2;
			reader2 = Dbcmd2.ExecuteReader();
			edges = new Dictionary<Node, int>();

			while (reader2.Read()) {
				aux = SearchNodeById(nodes, Int32.Parse(reader2["nodoFin"].ToString()));
				if (aux != null) {
					Console.WriteLine(aux.Id + ", " + aux.Nombre);
					edges[aux] = Int32.Parse(reader2["costo"].ToString());
				}
			}
			graph.Vertices[SearchNodeById(nodes, Int32.Parse(reader["idNodo"].ToString()))] = edges;
			Dbcon2.Close();
		}
		Dbcon.Close();

		Console.WriteLine("----\n" + graph + "\n----");

		foreach (Node nodo in nodes)
			Console.WriteLine(nodo.Id + ", " + nodo.Nombre + ", " + nodo.Latitud + ", " + nodo.Longitud);
	}
	protected void OnDeleteEvent(object sender, DeleteEventArgs a) {
		Gtk.Application.Quit();
		a.RetVal = true;
	}
	protected void MapClick(object o, ButtonPressEventArgs args) {
		Update();

		lat = args.Event.X;
		lon = args.Event.Y;

		Gtk.Menu m = new Gtk.Menu();
		Gtk.MenuItem createNode = new Gtk.MenuItem("Create a Node");
		Gtk.MenuItem createEdge = new Gtk.MenuItem("Create an Edge");
		Gtk.MenuItem calculateDjkstra = new Gtk.MenuItem("Calculate cost");
		createNode.ButtonPressEvent += new ButtonPressEventHandler(CreateNodePressed);
		createEdge.ButtonPressEvent += new ButtonPressEventHandler(CreateEdgePressed);
		calculateDjkstra.ButtonPressEvent += new ButtonPressEventHandler(CalculateDjkstraPressed);
		m.Add(createNode);
		m.Add(createEdge);
		m.Add(calculateDjkstra);
		m.ShowAll();
		m.Popup();
	}
	protected void CreateNodePressed(object sender, EventArgs args) {
		NodeWindow NWin = new NodeWindow(nodes, lat, lon);
	}
	protected void CreateEdgePressed(object sender, EventArgs args) {
		EdgeWindow EWin = new EdgeWindow(nodes);
	}
	protected void CalculateDjkstraPressed(object sender, EventArgs args) {
		DjkstraWindow DWin = new DjkstraWindow(nodes, graph);	
	}
}