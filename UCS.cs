using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacManGame
{
    class UniformCostSearch
    {
        private HashSet<Node> visited;
        private List<Node> path_UCS;
        private Node goal;
        private bool limitWasReached;
        public List<Node> UCS(Node start, Node goal, int limit)
        {
            visited = new HashSet<Node>();
            path_UCS = new List<Node>();
            limitWasReached = true;
            this.goal = goal;
            UCS(start, limit);
            if (path_UCS.Count > 0)
            {
                path_UCS.Add(start);
            }
            return path_UCS;
        }

        private bool UCS(Node node, int limit)
        {
            //node.Handler();
            node.Pass();

            if (node == goal)
            {
                return true;
            }
            if (limit == 0)
            {
                limitWasReached = false;
                return false;
            }
            visited.Add(node);
            foreach (var child in node.Children.Where(x => !visited.Contains(x)))
            {
                if (UCS(child, limit - 1))
                {
                    path_UCS.Add(child);
                    return true;
                }
            }
            return false;
        }
    }
}
