using CompLab.Models.Collections;
using CompLab.Models.Entities;
using CompLab.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLab.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = @"C:\Users\dimad\Desktop\compLab\a1";
            TestDeleteComputer(root, new Computer() { Id = Guid.Parse("bfff06d0-f0bc-4b7f-97cb-4904b13d85da") });
        }

        #region Create
        static void TestCreateEmptyRoom(string path)
        {
            var room = new Room()
            {
                Num = "a4"
            };
            FileHelper.CreateRoom(path, room);
        }
        static void TestCreateNotEmptyRoom(string path)
        {
            var list = new ComputerList();
            var comp1 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp2 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp3 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp4 = new Computer() { Id = Guid.NewGuid(), Price = 4 };

            list.Push(comp1);
            list.Push(comp2);
            list.Push(comp3);
            list.Push(comp4);

            var room = new Room()
            {
                Num = "a5",
                Computers = list
            };
            FileHelper.CreateRoom(path, room);
        }
        #endregion

        #region Read
        static void TestReadComputerList(string path)
        {
            var list = FileHelper.ReadComputerList(path);
            foreach (Computer item in list)
                Console.WriteLine(item.Price);
        }
        static void TestWriteComputerList(string path)
        {
            var list = new ComputerList();
            var comp1 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp2 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp3 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp4 = new Computer() { Id = Guid.NewGuid(), Price = 4 };

            list.Push(comp1);
            list.Push(comp2);
            list.Push(comp3);
            list.Push(comp4);

            FileHelper.CreateComputerList(path, list);
        }
        static void TestReadRooms(string path)
        {
            var queue = FileHelper.ReadRooms(path);
            foreach (Room room in queue)
            {
                Console.WriteLine($"Room Num : {room.Num}");
                foreach (Computer computer in room.Computers)
                    Console.WriteLine($"\tComputerPrice : {computer.Price}");
            }
        }
        #endregion

        #region Update

        static void TestUpdateRoom(string root, string prevName, string newName)
        {
            FileHelper.UpdateRoom(root, prevName, newName);
        }
        static void TestUpdateComputer(string path, Guid compId, Guid nextId)
        {
            var comp = new Computer()
            {
                Price = 1234,
                Id = compId,
                Next = new Computer()
                {
                    Id = nextId
                }
            };
             FileHelper.UpdateComputer(path, comp);
        }

        #endregion

        #region Delete  
        static void TestDeleteRoom(string root, Room room)
            => FileHelper.DeleteRoom(root, room);
        static void TestDeleteComputer(string root, Computer computer)
            => FileHelper.DeleteComputer(root, computer);
        #endregion

        #region CollectionsTest     

        static void TestRooms()
        {
            var list1 = new ComputerList();
            var comp11 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp21 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp31 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp41 = new Computer() { Id = Guid.NewGuid(), Price = 4 };
            list1.Push(comp11);
            list1.Push(comp21);
            list1.Push(comp31);
            list1.Push(comp41);

            var list2 = new ComputerList();
            var comp12 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp22 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp32 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp42 = new Computer() { Id = Guid.NewGuid(), Price = 4 };
            list1.Push(comp12);
            list1.Push(comp22);
            list1.Push(comp32);
            list1.Push(comp42);

            var queue = new RoomQueue();
            queue.Push(new Room()
            {
                Num = "a1",
                Computers = list1
            });
            queue.Push(new Room()
            {
                Num = "b1",
                Computers = list2
            });


            foreach (var item in queue)
                Console.WriteLine(((Room)item).Num);
        }
        static void TestComputers()
        {
            var list = new ComputerList();
            var comp1 = new Computer() { Id = Guid.NewGuid(), Price = 1 };
            var comp2 = new Computer() { Id = Guid.NewGuid(), Price = 2 };
            var comp3 = new Computer() { Id = Guid.NewGuid(), Price = 3 };
            var comp4 = new Computer() { Id = Guid.NewGuid(), Price = 4 };

            list.Push(comp1);
            list.Push(comp2);
            list.Push(comp3);
            list.Push(comp4);

            foreach (var item in list)
                Console.WriteLine(((Computer)item).Price);
            Console.WriteLine();

            list.Remove(comp4);

            foreach (var item in list)
                Console.WriteLine(((Computer)item).Price);
        }
        #endregion
    }
}
