using CompLab.Models.Entities;

namespace CompLab.Models.Collections
{
    public class RoomQueue
    {
        private Room[] _rooms;
        public RoomQueue()
        {
            _rooms = new Room[0];
        }

        public int Length { get => _rooms.Length; }
        public void Add(Room value)
        {
            var len = Length + 1;
            var roomsCopy = new Room[len];
            for(var i = 0;i<len; i++)
            {
                roomsCopy[i] = _rooms[i];
            }
            roomsCopy[Length] = value;
            _rooms = roomsCopy;
        }
        public Room GetNext()
        {
            if (Length == 0) return null;
            var len = Length - 1;
            var roomsCopy = new Room[len];
            for (var i = 1; i <= len; i++)
                roomsCopy[i-1] = _rooms[i];

            var result = _rooms[0];
            _rooms = roomsCopy;
            return result;
        }
    
        public RoomQueue Copy()
        {
            var copy = new RoomQueue();
            for (var i = 0; i < Length; i++)
                copy.Add(_rooms[i]);
            return copy;
        }
    }
}
