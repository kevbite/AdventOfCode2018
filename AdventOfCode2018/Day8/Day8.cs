using System.Linq;

namespace AdventOfCode2018.Day8
{
    public class Day8
    {
        public int Part1(Tree tree)
        {
            int GetNodeMetaData(Node node)
            {
                return node.Metadata.Sum() + node.Nodes.Select(GetNodeMetaData).Sum();
            }

            return GetNodeMetaData(tree.Node);
        }

        public int Part2(Tree tree)
        {
            int GetNodeMetaData(Node node)
            {
                if (node.Nodes.Length == 0)
                {
                    return node.Metadata.Sum();
                }

                return node.Metadata.Where(x => node.Nodes.Length >= x)
                    .Select(x => GetNodeMetaData(node.Nodes[x- 1]))
                    .Sum();
            }

            return GetNodeMetaData(tree.Node);
        }
    }
}
