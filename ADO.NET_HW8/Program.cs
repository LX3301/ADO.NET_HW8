namespace ADO.NET_HW8
{
    internal class Program
    {       
         static  List<Team> teams = new List<Team>()
            {
                new Team("Team A", 3, 2),
                new Team("Team B", 5, 4),
                new Team("Team C", 1, 1)
            };

        static void Main(string[] args)
        {
            Console.WriteLine("Name\tGoals Scored\tGoals Conceded\tGoal Difference");
            Console.WriteLine("------------------------------------------------------");

            foreach (Team team in teams)
            {
                Console.WriteLine(team.Name + "\t" + team.GoalsScored + "\t\t" + team.GoalsConceded + "\t\t" + team.GoalDifference);
            }

            Console.ReadLine();
        }
    }

    

    class Team
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalDifference { get { return GoalsScored - GoalsConceded; } }

        public Team(string name, int goalsScored, int goalsConceded)
        {
            Name = name;
            GoalsScored = goalsScored;
            GoalsConceded = goalsConceded;
        }


    }

    class Match
    {
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public DateTime Date { get; set; }

        public Match(Team homeTeam, Team awayTeam, int homeGoals, int awayGoals, DateTime date)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            HomeGoals = homeGoals;
            AwayGoals = awayGoals;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {HomeTeam.Name} {HomeGoals}:{AwayGoals} {AwayTeam.Name}";
        }
    }

}