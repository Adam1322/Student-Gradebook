﻿namespace Stopień_ucznia
{
    public abstract class Student
    {
        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
    }
}
