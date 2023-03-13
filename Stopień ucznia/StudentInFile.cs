namespace Stopień_ucznia
{
    public class StudentInFile : StudentBase
    {
        private const string fileName = "grades.txt";
        private List<float> grades = new List<float>();

        public StudentInFile(string name, string surname)
            : base(name, surname)
        {
            using (FileStream fs = File.Create(fileName));
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 1 && grade <= 6)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
                throw new Exception("Invalid grade value. Try again :)");
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            using (var reader = File.AppendText(fileName))
                switch (grade)
                {
                    case 'A':
                        this.AddGrade(5);
                        break;
                    case 'B':
                        this.AddGrade(4);
                        break;
                    case 'C':
                        this.AddGrade(3);
                        break;
                    case 'D':
                        this.AddGrade(2);
                        break;
                    case 'E':
                        this.AddGrade(1);
                        break;
                    case 'F':
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong grade");
                }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char character))
            {
                this.AddGrade(character);
            }
            else
            {
                throw new Exception("String is not a float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

    }
}
