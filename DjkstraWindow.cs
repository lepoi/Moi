using System;
using System.Collections.Generic;

namespace Moi {
	public partial class DjkstraWindow : Gtk.Window {

		List<Node> nodes;
		Graph graph;

		public DjkstraWindow(List<Node> nodes, Graph graph) : base(Gtk.WindowType.Toplevel) {

			this.nodes = nodes;
			this.graph = graph;

			this.Build();
		}

		protected Node SearchNodeById(List<Node> list, int id) {
			foreach (Node node in list)
				if (node.Id == id)
					return node;
			return null;
		}

		protected void CloseButtonPressed(object sender, EventArgs e) {
			this.Destroy();
		}

		protected void CalculateButtonClicked(object sender, EventArgs e) {
			Console.WriteLine(graph);
			List<Node> Path = graph.ShortestPath(SearchNodeById(nodes, Int32.Parse(StartEntry.Text)), SearchNodeById(nodes, Int32.Parse(FinishEntry.Text)));
			string str = "";
			foreach (Node node in Path)
				str += node.Id.ToString() + "\t" + node.Nombre + "\n";
			Console.WriteLine(str);
			DjkstraText.Buffer.Text = str;
		}

		protected void CloseButtonClicked(object sender, EventArgs e) {
			this.Destroy();
		}
	}
}
