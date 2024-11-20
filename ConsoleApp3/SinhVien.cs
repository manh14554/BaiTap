using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SinhVien
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public SinhVien() { }
        public SinhVien(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
