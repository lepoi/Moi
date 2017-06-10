using System;
using System.Collections.Generic;

namespace Moi {
	public class Graph {
		public Dictionary<Node, Dictionary<Node, int>> Vertices = new Dictionary<Node, Dictionary<Node, int>>();

		public void AddVertex(Node Vertex, Dictionary<Node, int> Edges) {
			Vertices[Vertex] = Edges;
		}

		public override string ToString() {
			string str = "";
			foreach (var item in Vertices) {
				str += item.Key.Id +", " + item.Key.Nombre + "\n";

				foreach (var item2 in item.Value) {
					str += "\t" + item2.Key.Id + ", " + item2.Key.Nombre + ", " + item2.Value + "\n";
				}
			}
			if (str == "")
				str = "NO HAY DATOS";
			return str;
		}

		public List<Node> ShortestPath(Node Start, Node Finish) {
			var Previous = new Dictionary<Node, Node>();
			var Distances = new Dictionary<Node, int>();
			var Nodes = new List<Node>();

			List<Node> Path = null;

			foreach (var Vertex in Vertices) {
				if (Vertex.Key == Start) {
					Distances[Vertex.Key] = 0;
				} else {
					Distances[Vertex.Key] = int.MaxValue;
				}

				Nodes.Add(Vertex.Key);
			}

			while (Nodes.Count != 0) {
				Nodes.Sort((x, y) => Distances[x] - Distances[y]);

				var Smallest = Nodes[0];
				Nodes.Remove(Smallest);

				if (Smallest == Finish) {
					Path = new List<Node>();
					while (Previous.ContainsKey(Smallest)) {
						Path.Add(Smallest);
						Smallest = Previous[Smallest];
					}

					break;
				}

				if (Distances[Smallest] == int.MaxValue) {
					break;
				}

				foreach (var Neighbor in Vertices[Smallest]) {
					var Alt = Distances[Smallest] + Neighbor.Value;
					if (Alt < Distances[Neighbor.Key]) {
						Distances[Neighbor.Key] = Alt;
						Previous[Neighbor.Key] = Smallest;
					}
				}
			}

			return Path;
		}
	}
}