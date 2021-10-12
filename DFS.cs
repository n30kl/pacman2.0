using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class DepthFirstSearch
    {
        private HashSet<Node> visited;
        private LinkedList<Node> path_DFS;
        private Node goal;
        public LinkedList<Node> DFS(Node start, Node goal)
        {
            visited = new HashSet<Node>();
            path_DFS = new LinkedList<Node>();
            this.goal = goal;
            DFS(start);
            if (path_DFS.Count > 0)
            {
                path_DFS.AddFirst(start);
            }
            return path_DFS;
        }

        private bool DFS(Node node)
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
                if (DFS(child))
                {
                    path_DFS.AddFirst(child);
                    return true;
                }
            }
            return false;
        }

        internal object DFS(Node n06, Node n10, int v)
        {
            throw new NotImplementedException();
        }
    }
}
