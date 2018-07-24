using System;
using System.Collections.Generic;
using System.Text;

namespace CallConstFromCon
{
    public class Student
    {
        private int ID;
        private int tuitionFees;
        private float totalFees;
        private string name;
        
        public Student(int id,string name,int tuitionFees)
        {
            this.ID = id;
            this.name = name;
            this.tuitionFees = tuitionFees;
            this.totalFees = tuitionFees;
        }

        public Student(int id,string name,int tuitionFees,int x) : this(id,name,tuitionFees)
        {
            this.totalFees = tuitionFees + x;
        }

        public Student(int id,string name,int tuitionFees,int x,int y) : this(id,name,tuitionFees)
        {
            this.totalFees = tuitionFees + x + y;
        }

        public void showStudent()
        {
            Console.WriteLine($"ID: {this.ID}, Name : {this.name}, Tuition Fees : {this.tuitionFees}" +
                $" ,Total School Fees : {this.totalFees}");
        }
    }
}
