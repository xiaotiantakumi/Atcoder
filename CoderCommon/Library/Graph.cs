using System.Collections.Generic;

namespace CoderCommon
{
        public class Node<T>
        {
            public bool IsArrive { get; set; }

            public T Value { get; set; }
            public HashSet<Node<T>> Children { get; set; } 

            public Node(T value)
            {
                Value = value;
                IsArrive = false;
                Children = new HashSet<Node<T>>();
            }

            public override string ToString()
            {
                string ret = $"CurrentValue:{Value.ToString()}";
                return ret;
            }
        }

        public static class GraphUtil
        {
            public static Dictionary<T, Node<T>> CreateTree<T>(List<T[]> treeInfo)
            {
                Dictionary<T, Node<T>> dicNode = new Dictionary<T, Node<T>>();
                foreach (var nodes in treeInfo)
                {
                    if (!dicNode.ContainsKey(nodes[0]))
                    {
                        dicNode[nodes[0]] = new Node<T>(nodes[0]);
                    }

                    if (!dicNode.ContainsKey(nodes[1]))
                    {
                        dicNode[nodes[1]] = new Node<T>(nodes[1]);
                    }

                    dicNode[nodes[0]].Children.Add(dicNode[nodes[1]]);
                    dicNode[nodes[1]].Children.Add(dicNode[nodes[0]]);
                }

                return dicNode;
            }
        }
}