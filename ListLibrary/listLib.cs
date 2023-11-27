using System.Collections.Generic;
using System.Linq;

namespace ListLibrary
{
    public class Node<T>
    {
        public T Value { private set; get; }
        public Node<T> NextNode { set; get; }
        public Node( T value)
        {
            Value = value;
            NextNode = null;    
        }
    }

    public class ListLib<T> : IEnumerable <T>
    {
        public int Count { set; get; }
        Node<T> _head;
        Node<T> _lastNode;
        private static string _author = "Olga Yakimova";

        public ListLib()
        {
            Count = 0;
            _head = null;
            _lastNode = null;
        }
        public ListLib (IEnumerable<T> list)
        {
            var enumerable = list as T[] ?? list.ToArray();
            if (list == null || !enumerable.Any())
            {
                Count = 0;
                return;
            }
            CreateFirstNode ( new Node<T>(enumerable.ElementAt(0)));
            
            foreach (var value in enumerable.Skip(1))
            {
                Add(value);
            }
        }
        public void Add( T value)
        {
            var newListNode = new Node<T>(value);
            if (_lastNode != null)
            {
                _lastNode.NextNode = newListNode;
                _lastNode = newListNode;
                Count++;
            }
            else
            {
                CreateFirstNode(newListNode);
            }
        }

        private void CreateFirstNode(Node<T> newListNode)
        {
            _head = newListNode;
            _lastNode = _head;
            Count = 1;
        }

        public T[] ToArray()
        {
            if(Count < 1 ) return new T[0];
            T[] values = new T[this.Count];
            Node<T> first = _head;
            for(int i = 0; i < this.Count; i++)
            {
                values[i] = first.Value;
                first = first.NextNode;
            }
            return values;
        }

        public void AddRange(IEnumerable<T> list)
        {
            var values = list as T[] ?? list.ToArray();
            if (list == null || !values.Any())
            {
                return;
            }
            foreach (var value in values)
            {
                Add(value);
            }
         }

        #region IEnumerable<T> Members

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (Node<T> listNode = _head; listNode != null; listNode = listNode.NextNode)
            {
                yield return listNode.Value ;
            }
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            for (Node<T> listNode = _head; listNode != null; listNode = listNode.NextNode)
            {
                yield return listNode.Value;
            }
        }

        #endregion
    }
}
