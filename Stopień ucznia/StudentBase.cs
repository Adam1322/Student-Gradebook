
namespace Stopień_ucznia
{
    public abstract class StudentBase : IStudent
    {
        public StudentBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
    }
}
