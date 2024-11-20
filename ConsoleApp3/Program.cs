using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> list = new List<SinhVien>();
            list.Add(new SinhVien(1, "Anh", 19));
            list.Add(new SinhVien(2, "Bao", 20));
            list.Add(new SinhVien(3, "Chau", 15));
            list.Add(new SinhVien(4, "Duy", 17));
            list.Add(new SinhVien(5, "Hai", 18));
            Console.WriteLine("Cau a");
            foreach (var student in list)
            {
                Console.WriteLine($" {student.Id}   {student.Name}   {student.Age}");
            }
            Console.WriteLine("Cau b");
            var x = list.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in x)
            {
                Console.WriteLine($" {student.Id}   {student.Name}   {student.Age}");
            }
            Console.WriteLine("Cau c");
            var a = list.Where(s => s.Name.StartsWith("A"));
            foreach (var student in a)
            {
                Console.WriteLine($" {student.Id}   {student.Name}   {student.Age}");
            }
            Console.WriteLine("Cau d");
            int tongTuoi = list.Sum(s => s.Age);
            Console.WriteLine($"Tong tuoi sv: " +tongTuoi);
            Console.WriteLine("Cau e");
            var Tuoi = list.OrderBy(s => s.Age).Last();
            Console.WriteLine($"SV co tuoi lon nhat: " + Tuoi.Age);
            Console.WriteLine("Cau f");
            var SapXepTuoi = list.OrderBy(s =>s.Age);
            foreach (var s in SapXepTuoi)
            {
                Console.WriteLine($" {s.Id}   {s.Name}   {s.Age}");
            }
            Console.ReadLine();
        }
    }
}
