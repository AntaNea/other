using System;
using System.Text;
using Google.Protobuf;
using ProtoBuf;
using System.IO;

namespace Second
{
    class Program
    {
        static void ShowAsText(People p) => Console.WriteLine("{p.Id}: Hello, My name is {p.Name}, I'm {p.Age}"); //for showing

        static T Desear(byte[] data) where T:class //Method for desearelization all classes
        {
            if (obj == null) return null;
            try
            {
                using (var sream = new MemoryStream())
                    return Serealizer.Deserealizer<T>(srteam);
            }
            catch
            {
                throw;
            }
        }

        static void Main()
        {
            People p0 = new People { Id = 0, Name = "Adam", Age = 18, IsMan = true };//Experemental p
            ShowAsText(p0);

            var p1 = p0.ToByteArray(); //Convert to array
            foreach (byte p in p1) //how it sees
                Console.Write(p);

            People p2 = new People();
            p2 = Desear<People>(p1);    //Back convert to People
            ShowAsText(p2);       
        }  
    }
}
