using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Building office = new Building("799379, Мурманская область, город Красногорск, проезд Гоголя, 89", 12, 6, 8);
            Console.WriteLine(office.Print());
            Console.WriteLine();
            MultiBuilding housing = new MultiBuilding("844923, Ленинградская область, город Павловский Посад, пер. Балканская, 75", 54, 18, 26, 9);
            Console.WriteLine(housing.Print());
            Console.ReadKey();

        }
    }
    public class Building
    {
        public string Address { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public Building (string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public string Print()
        {
            return $"Адрес: {Address}\nДлина: {Length}\nШирина: {Width}\nВысота: {Height}";
        }
    }
    public sealed class MultiBuilding : Building
    {
        public int Levels { get; set; }
        public MultiBuilding(string address, int length, int width, int height, int levels)
            :base(address, length, width, height)
        {
            Levels = levels;
        }
        public new string Print()
        {
            return base.Print() + $"\nЭтажность: {Levels}";
        }
    }
}
