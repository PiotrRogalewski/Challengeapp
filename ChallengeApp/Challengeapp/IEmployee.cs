namespace Challengeapp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Gender { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}