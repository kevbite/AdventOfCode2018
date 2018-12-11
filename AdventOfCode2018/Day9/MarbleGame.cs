using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day9
{
    public class MarbleGame
    {
        private LinkedListNode<int> _currentMarble;
        private readonly LinkedList<int> _linkedList;

        public MarbleGame()
        {
            _linkedList = new LinkedList<int>();
            _currentMarble = new LinkedListNode<int>(0);
            _linkedList.AddFirst(_currentMarble);
        }

        public void Play(Player player, int marble)
        {
            if (marble % 23 == 0)
            {
                PlayScoredMove(player, marble);
            }
            else
            {
                PlayUnscoredMove(marble);
            }
        }

        private void PlayUnscoredMove(int marble)
        {
            var linkedListNode = new LinkedListNode<int>(marble);
            var after = NextMarbleAfter(1);

            _linkedList.AddAfter(after, linkedListNode);
            _currentMarble = linkedListNode;
        }

        private void PlayScoredMove(Player player, int marble)
        {
            var sevenBefore = PreviousMarbleAfter(7);
            _currentMarble = NextMarbleAfter(sevenBefore, 1);
            _linkedList.Remove(sevenBefore);

            player.AddScore(marble);
            player.AddScore(sevenBefore.Value);
        }

        private LinkedListNode<int> NextMarbleAfter(int after)
        {
            var node = _currentMarble;

            return NextMarbleAfter(node, after);
        }

        private LinkedListNode<int> NextMarbleAfter(LinkedListNode<int> node, int after)
        {
            for (var i = 0; i < after; i++)
            {
                node = node.Next
                       ?? _linkedList.First;
            }

            return node;
        }

        private LinkedListNode<int> PreviousMarbleAfter(int after)
        {
            var node = _currentMarble;
            
            for (var i = 0; i < after; i++)
            {
                node = node.Previous
                       ?? _linkedList.Last;
            }

            return node;
        }

        public string GetBoard()
        {
            var enumerable = _linkedList.Select(x =>
                x == _currentMarble.Value ? $"({x})" : x.ToString()
            );

            return string.Join(" ", enumerable);
        }
    }
}