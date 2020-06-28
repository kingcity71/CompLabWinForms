using CompLab.Models.Entities;
using System.Collections;

namespace CompLab.Models.Collections
{
    internal class RoomQueueEnumerator : IEnumerator
    {
        private Room[] _rooms;
        private int _index = -1;
        public RoomQueueEnumerator(RoomQueue queue)
        {
            _rooms = queue.Rooms;
        }

        public object Current => _rooms[_index];

        public bool MoveNext()
        {
            if (_rooms.Length-1 == _index) return false;
            _index++;
            return true;
        }

        public void Reset() => _index = -1;

    }
    public class RoomQueue : IEnumerable
    {
        private Room[] _rooms;
        internal Room[] Rooms { get => _rooms; }
        public RoomQueue()
        {
            _rooms = new Room[0];
        }

        public int Length { get => _rooms.Length; }
        public void Push(Room value)
        {
            var len = Length + 1;
            var roomsCopy = new Room[len];
            for (var i = 0; i < Length; i++)
            {
                roomsCopy[i] = _rooms[i];
            }
            roomsCopy[Length] = value;
            _rooms = roomsCopy;
        }
        public Room Pop()
        {
            if (Length == 0) return null;
            var len = Length - 1;
            var roomsCopy = new Room[len];
            for (var i = 1; i <= len; i++)
                roomsCopy[i - 1] = _rooms[i];

            var result = _rooms[0];
            _rooms = roomsCopy;
            return result;
        }

        public RoomQueue Copy()
        {
            var copy = new RoomQueue();
            for (var i = 0; i < Length; i++)
                copy.Push(_rooms[i]);
            return copy;
        }
        public IEnumerator GetEnumerator() => new RoomQueueEnumerator(this);
    }
}
