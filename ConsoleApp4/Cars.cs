using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Cars
    {

        public string Model;
        public int YearBuild;
        public const float MaxSpeed = 320;
        public int Run;
        public int cark;
        public int humkey;
        public bool StartEngine;
        public bool CarKey;

        public Vector3 Position;

        public Cars()
        {
            Position = new Vector3();
            Model = "Неизвестно";
            YearBuild = 0000;
            Run = 0;
            StartEngine = false;
            //cark = 0110;
            //humkey = 0000;
            //CarKey = false;
        }
        public Cars(string model, Vector3 pos)
        {
            Position = pos;
            Model = model;
            YearBuild = DateTime.Today.Year;
            Run = 0;
            StartEngine = false;
        }
        //public void KeyIn()
        //{
        //    Console.WriteLine("напишите 4x значный код ключа");
        //    humkey = Convert.ToInt32(Console.ReadLine());
        //    if (cark == humkey)
        //    {
        //        Console.WriteLine("Ключ вставлен");
        //        CarKey = true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ключ не подходит");
        //    }

        //}
        //public void KeyOut()
        //{
        //    CarKey = false;
        //    Console.WriteLine("Ключ был вынут");
        //}
        public void Start()
        {
            //if (!CarKey)
            //    return;
            Console.WriteLine($"машина {Model} включилась");
            StartEngine = true;
        }

        public void Off()
        {
            //if (!CarKey)
            //    return;
            Console.WriteLine($"машина {Model} выключилась");
            StartEngine = false;
        }

        public void Move(Vector3 vector)
        {
            if (!StartEngine)
                return;

            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            Run++;

            Console.WriteLine($"Машина {Model} передвинулась на X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}");
        }

        public string GetInfo() => $"Тачка {Model}. {YearBuild} - год производства. Двигатель {StartEngine}. Позиция = X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}. Пробег = {Run}";
    }
}
//сделать key()