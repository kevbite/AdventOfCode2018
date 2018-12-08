namespace AdventOfCode2018.Day8
{
    public class Node
    {
        public Node(int[] metadata, Node[] nodes)
        {
            Metadata = metadata;
            Nodes = nodes;
        }

        public int[] Metadata { get; }

        public Node[] Nodes { get; }
    }
}