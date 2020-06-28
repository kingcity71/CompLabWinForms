using CompLab.Models.Entities;
using System.Collections;

namespace CompLab.Models.Collections
{
    public class ComputerListEnumerator : IEnumerator
    {
        private readonly ComputerList _list;
        private Computer _current;
        private bool _isFirst = true;
        public ComputerListEnumerator(ComputerList list)
        {
            _list = list;
            _current = list.Head;
        }

        public object Current => _current;

        public bool MoveNext()
        {
            if (_current.Id == _list.Head.Id && _isFirst)
            {
                _isFirst = false;
                return true;
            }
            if (_current.Next.Id == _list.Head.Id)
                return false;
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            _current = _list.Head;
            _isFirst = true;
        }
    }
    public class ComputerList : IEnumerable
    {
        private Computer _head;
        public Computer Head { get => _head; }
        public void Push(Computer computer)
        {
            if (_head == null)
            {
                _head = computer;
                _head.Next = computer;
                return;
            }

            var current = _head;
            while (current.Next.Id != _head.Id)
                current = current.Next;

            current.Next = computer;
            computer.Next = _head;
        }
        public void Remove(Computer computer)
        {
            if (_head == null) return;
            if (_head.Id == computer.Id)
            {
                var second = _head.Next;
                var cur = _head.Next;
                while (cur.Next.Id != _head.Id)
                    cur = cur.Next;
                cur.Next = second;
                _head = second;
                return;
            }
            var prev = _head;
            var current = _head.Next;
            while (current.Id != _head.Id)
            {
                if (current.Id == computer.Id)
                {
                    prev.Next = current.Next;
                    computer.Next = null;
                    return;
                }
                prev = current;
                current = current.Next;
            }
        }
        public IEnumerator GetEnumerator() => new ComputerListEnumerator(this);
    }
}