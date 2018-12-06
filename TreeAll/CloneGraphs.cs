using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
    /*
     *  Given the head of a graph, return a deep copy (clone) of the graph. Each node in the graph contains a label (int) and a list (List[UndirectedGraphNode]) of its neighbors. There is an edge between the given node and each of the nodes in its neighbors.

        OJ's undirected graph serialization (so you can understand error output):
        Nodes are labeled uniquely.

        We use # as a separator for each node, and , as a separator for node label and each neighbor of the node.
 

        As an example, consider the serialized graph {0,1,2#1,2#2,2}.

        The graph has a total of three nodes, and therefore contains three parts as separated by #.

        First node is labeled as 0. Connect node 0 to both nodes 1 and 2.
        Second node is labeled as 1. Connect node 1 to node 2.
        Third node is labeled as 2. Connect node 2 to node 2 (itself), thus forming a self-cycle.
 

        Visually, the graph looks like the following:

               1
              / \
             /   \
            0 --- 2
                 / \
                 \_/
        Note: The information about the tree serialization is only meant so that you can understand error output if you get a wrong answer. You don't need to understand the serialization to solve the problem.
     */
    public class UndirectedGraphNode
    {
        public int label;
        public IList<UndirectedGraphNode> neighbors;
        public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
    };
    public class CloneGraphs
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node==null)
            {
                return null;
            }

            Dictionary<int, UndirectedGraphNode> graphDic = new Dictionary<int, UndirectedGraphNode>();
            Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();

            q.Enqueue(node);

            UndirectedGraphNode undirectedGraphNode = new UndirectedGraphNode(node.label);

            graphDic.Add(undirectedGraphNode.label, undirectedGraphNode);

            while (q.Count != 0)
            {
                UndirectedGraphNode u = q.Dequeue();
                IList<UndirectedGraphNode> undirectedGraphNodeNeighbors = u.neighbors;

                foreach (var neghbor in undirectedGraphNodeNeighbors)
                {
                    if (graphDic.ContainsKey(neghbor.label))
                    {
                        graphDic[u.label].neighbors.Add(graphDic[neghbor.label]);
                    }
                    else
                    {
                        q.Enqueue(neghbor);
                        UndirectedGraphNode neighborsnodeCopy = new UndirectedGraphNode(neghbor.label);
                        graphDic.Add(neighborsnodeCopy.label, neighborsnodeCopy);
                        graphDic[u.label].neighbors.Add(neighborsnodeCopy);
                    }
                }
            }
            return undirectedGraphNode;
        }
    }
}
