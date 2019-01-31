using System;
using System.Collections.Generic;
using System.Text;

namespace Pelyceum
{
    class Student
    {
        String name;
        int age;
        String major;
        String highschool;
        double GPA;
        int SAT;
        //insert other if answer = 0
        int ACT;
        String IntendedSemesterStart;
        String athletics;
        int income;
        int numOfJobs;
        String gender;
        String Password;

        public Student(string name, int age, int numOfJobs, string major, string highschool, double GPA, int SAT, int ACT, string IntendedSemesterStart, int income, string gender)
        {
            this.name = name;
            this.age = age;
            this.numOfJobs = numOfJobs;
            this.major = major;
            this.highschool = highschool;
            this.GPA = GPA;
            this.SAT = SAT;
            this.ACT = ACT;
            this.IntendedSemesterStart = IntendedSemesterStart;
            this.income = income;
            this.gender = gender; 


        }
        public void Name(string name)
        {
            name = Console.ReadLine();
            Console.WriteLine("Enter your name: " + name);
        }
        public void SetJob(int numOfJobs)
        {
            this.numOfJobs = numOfJobs;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetNumJobs(int numOfJobs)
        {
            this.numOfJobs = numOfJobs;
        }
        public void SetMajor(string major)
        {
            this.major = major;
        }
        public void SetHS(string highschool)
        {
            this.highschool = highschool;
        }
        public void SetGpA(double GPA)
        {
            this.GPA = GPA;
        }
        public void SetSaT(int SAT)
        {
            this.SAT = SAT;
        }
        public void SetAcT(int ACT)
        {
            this.ACT = ACT;
        }
        public void SetISS(string IntendedSemesterStart)
        {
            this.IntendedSemesterStart = IntendedSemesterStart;
        }
        public void SetIncome(int income)
        {
            this.income = income;
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
    }
}
