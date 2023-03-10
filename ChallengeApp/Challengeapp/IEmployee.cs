using static Challengeapp.EmployeeBase;

namespace Challengeapp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Gender { get; }
        int Age { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

        public event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}