using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day8
{
    public class Tree
    {
        public Tree(Node node)
        {
            Node = node;
        }

        public Node Node { get; }

        public static Tree Parse(string input)
        {
            var array = new Queue<int>(input.Split(' ')
                .Select(int.Parse));

            var rootNode = BuildNode(array);

            return new Tree(rootNode);
        }

        private static Node BuildNode(Queue<int> array)
        {
            var nodeCount = array.Dequeue();
            var metadataCount = array.Dequeue();

            var nodes = BuildNodes(nodeCount, array);
            var metadata = BuildMetadata(metadataCount, array);

            return new Node(metadata, nodes);
        }

        private static int[] BuildMetadata(int metadataCount, Queue<int> array)
        {
            var metadata = new int[metadataCount];
            for (int i = 0; i < metadataCount; i++)
            {
                metadata[i] = array.Dequeue();
            }

            return metadata;
        }

        private static Node[] BuildNodes(int nodeCount, Queue<int> array)
        {
            var nodes = new Node[nodeCount];
            for (int i = 0; i < nodeCount; i++)
            {
                var node = BuildNode(array);
                nodes[i] = node;
            }

            return nodes;
        }
    }
}