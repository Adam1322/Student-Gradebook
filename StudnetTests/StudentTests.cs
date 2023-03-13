using Stopieñ_ucznia;

namespace StudnetTests
{
    public class StudentTests
    {

        [Test]
        public void CheckResultOfAddGrade()
        {
            //arange
            var student = new StudentInFile("Adam", "Kuliczkowski");
            student.AddGrade(6);
            student.AddGrade(2);

            //act
            var result = student.GetStatistics();

            //assert
            Assert.AreEqual(6, result.Max);
            Assert.AreEqual(2, result.Min);
        }
    }
}