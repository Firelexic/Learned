using System;
using System.Collections.Generic;
using System.Text;

namespace OOPexampleThird
{
    public class Cat
    {
        private string name;
        private string color;
        private int age;

        public Cat()
        {
            name = "Tigger";
            age = 3;
            color = "Bronw";
        }
        public void SetName(string name) { this.name = name; }
        public void SetAge(int age) { this.age = age; }
        public void SetColor(string color) { this.color = color; }

        public string GetNmae() { return name; }
        public int GetAge() { return age; }
        public string GetColor() { return color; }

        public string cry() { return "Meow,meow"; }
    }
}
