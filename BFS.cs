using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{

    class BreadthFirstSearch
    {
        private HashSet<Node> visited;
        private LinkedList<Node> path_BFS;
        private Node goal;

        public LinkedList<Node> BFS(Node start, Node goal)
        {
            visited = new HashSet<Node>();
            path_BFS = new LinkedList<Node>();
            this.goal = goal;
            BFS(start);
            if (path_BFS.Count > 0)
            {
                path_BFS.AddLast(start);
            }
            return path_BFS;
        }

        private bool BFS(Node node)
        {
            // node.Handler();

            node.Pass();
            if (node == goal)
            {
                return true;
            }
            visited.Add(node);
            foreach (var child in node.Children.Where(x => !visited.Contains(x)))
            {
                if (BFS(child))
                {
                    path_BFS.AddLast(child);
                    return true;
                }
            }
            return false;
        }
    }

}
