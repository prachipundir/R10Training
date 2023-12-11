namespace ChainOfResponsibilityDesignPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamLeader teamLeader= new TeamLeader();
            ProjectManager projectManager = new ProjectManager();
            HR hR = new HR();
            teamLeader.SetNextSupervisor(projectManager);
            projectManager.SetNextSupervisor(hR);
            teamLeader.ApplyLeave("Prachi", 9);
            Console.WriteLine();
            teamLeader.ApplyLeave("Pranaya", 18);
            Console.WriteLine();
            teamLeader.ApplyLeave("Priyanka", 30);
            Console.WriteLine();
            teamLeader.ApplyLeave("Ramesh", 50);
            
        }
    }
}