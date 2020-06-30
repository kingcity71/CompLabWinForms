using CompLab.Models.Collections;
using CompLab.Models.Entities;
using CompLab.Models.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace CompLab.Services
{
    public class FileHelper
    {
        #region Create
        public static void CreateRoom(string rootPath, Room room)
        {
            var path = $@"{rootPath}\{room.Num}";
            Directory.CreateDirectory(path);
            CreateComputerList(path, room.Computers);
        }
        
        public static void CreateComputer(string path, Computer computer)
        {
            var pathFile = $@"{path}\{computer.Id}.xml";
            if (File.Exists(pathFile))
                File.Delete(pathFile);
            var formatter = new XmlSerializer(typeof(ComputerXmlModel));
            using (var fs = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                var xmlModel = new ComputerXmlModel()
                {
                    Id = computer.Id,
                    Price = computer.Price,
                    Next = computer.Next.Id
                };
                formatter.Serialize(fs, xmlModel);
            }
        }

        public static void CreateComputerList(string path, ComputerList list)
        {
            var formatter = new XmlSerializer(typeof(ComputerXmlModel));
            foreach (Computer comp in list)
                CreateComputer(path, comp);
        }
        #endregion

        #region Read
        public static RoomQueue ReadRooms(string path)
        {
            var roomQueue = new RoomQueue();
            var allFolders = Directory.GetDirectories(path);
            foreach (var folder in allFolders)
                roomQueue.Push(new Room()
                {
                    Num = folder.Split('\\').Last(),
                    Computers = ReadComputerList(folder)
                });
            return roomQueue;
        }
        public static ComputerList ReadComputerList(string path)
        {
            var list = new ComputerList();
            var allFiles = Directory.GetFiles(path);

            if (allFiles.Length == 0) return list;

            var serializer = new XmlSerializer(typeof(ComputerXmlModel));
            var filePath = allFiles.First();

            var isLoop = false;
            while (!isLoop)
                using (var reader = new StreamReader(filePath))
                {
                    var xmlModel = (ComputerXmlModel)serializer.Deserialize(reader);
                    var computer = new Computer() { Id = xmlModel.Id, Price = xmlModel.Price };
                    list.Push(computer);
                    filePath = $@"{path}\{xmlModel.Next.ToString()}.xml";
                    if (xmlModel.Next == list.Head.Id)
                        isLoop = true;
                }
            return list;
        }
        #endregion

        #region Update
        public static void UpdateRoom(string path, string prevName, string newName)
            => Directory.Move($@"{path}\{prevName}", $@"{path}\{newName}");
        public static void UpdateComputer(string path, Computer computer)
            => CreateComputer(path, computer);
        #endregion

        #region Delete
        
        public static void DeleteRoom(string root, Room room)
            => Directory.Delete($@"{root}/{room.Num}", true);
        public static void DeleteComputer(string path, Computer computer)
        {
            var list = ReadComputerList(path);
            list.Remove(computer);
            File.Delete($@"{path}\{computer.Id.ToString()}.xml");
            CreateComputerList(path, list);
        }

        #endregion
    }
}
