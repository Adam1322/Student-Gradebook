namespace Stopień_ucznia
{
    public interface IStudent
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
