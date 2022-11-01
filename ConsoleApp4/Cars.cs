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
        public bool StartEngine;
        public bool CarKey;

        public string HumanKey;
        public string RightKey;

        public Vector3 Position;

        public Cars()
        {
            Position = new Vector3();
            Model = "Неизвестно";
            YearBuild = 0000;
            Run = 0;
            StartEngine = false;
            HumanKey = "0000";
            RightKey = "0100";
        }
        public Cars(string model, Vector3 pos)
        {
            Position = pos;
            Model = model;
            YearBuild = DateTime.Today.Year;
            Run = 0;
            StartEngine = false;
        }
        public void CheckKey()
        {
            string RightKey = "0100";
            Console.WriteLine("Вставьте ключ в замок зажигания(4 цифры 0 и 1)");
            string HumanKey = Console.ReadLine();
            if (HumanKey == RightKey)
            {
                CarKey = true;
            }
            else
            {
                Console.WriteLine("Ключ неверный");
            }
        }
        public void Start()
        {
            if (!CarKey)
                return;
            Console.WriteLine($"машина {Model} включилась");
            StartEngine = true;
        }

        public void Off()
        {
            if (!CarKey)
                return;
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