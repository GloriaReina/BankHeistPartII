using System;
class Program
{
    static void Main(string[] args)
    {
        List<IRobber> rolodex = new List<IRobber>();

        Hacker hacker1 = new Hacker() { Name = "JaneDoe", SkillLevel = 25, PercentageCut = 50, Specialty= "Hacker" };
        rolodex.Add(hacker1);
        Hacker hacker2 = new Hacker() { Name = "ShadowStrike", SkillLevel = 60, PercentageCut = 45, Specialty= "Hacker" };
        rolodex.Add(hacker2);
        Muscle muscle1 = new Muscle() { Name = "RogueFalcon", SkillLevel = 80, PercentageCut = 30, Specialty= "Muscle"};
        rolodex.Add(muscle1);
        Muscle muscle2 = new Muscle() { Name = "MidnightViper", SkillLevel = 74, PercentageCut = 25, Specialty= "Muscle" };
        rolodex.Add(muscle2);
        LockSpecialist lockSpecialist1 = new LockSpecialist() { Name = "SlickBandit", SkillLevel = 96, PercentageCut = 40, Specialty= "Lock Specialist" };
        rolodex.Add(lockSpecialist1);

        
        RobberReport.RobberListReport(rolodex);

        Console.WriteLine($"Number of current operatives: {rolodex.Count}");

        while (true)
        {

            Console.WriteLine("To exit program, enter a blank space for name: ");
            Console.Write("Enter the name of a possible Recruit:");
            string recruitName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(recruitName))
            {
                Console.Write("Goodbye!");
                break; //break out of the outer loop= exit the program
            }
            Console.WriteLine();
            Console.WriteLine(@"Enter recruit's specialty: 
                                Hacker (Disables alarms)
                                Muscle (Disarms guards)
                                Lock Specialist (cracks vault)");
            string recruitSpecialty = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter the recruit's skill level as an integer between 1 and 100: ");
            int recruitSkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(" Enter percentage cut recruit demands for each mission: ");
            int recruitCutPercent = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (recruitSpecialty == "Hacker")
            {
                Hacker hacker = new Hacker()
                {
                    Name = recruitName,
                    Specialty= recruitSpecialty,
                    SkillLevel = recruitSkillLevel,
                    PercentageCut = recruitCutPercent
                };
                rolodex.Add(hacker);
            }
            else if (recruitSpecialty == "Muscle")
            {
                Muscle muscle = new Muscle()
                {
                    Name = recruitName,
                    Specialty= recruitSpecialty,
                    SkillLevel = recruitSkillLevel,
                    PercentageCut = recruitCutPercent
                };
                rolodex.Add(muscle);
            }
            else if (recruitSpecialty == "Lock Specialist")
            {
                LockSpecialist lockSpecialist = new LockSpecialist()
                {
                    Name = recruitName,
                    Specialty= recruitSpecialty,
                    SkillLevel = recruitSkillLevel,
                    PercentageCut = recruitCutPercent
                };
                rolodex.Add(lockSpecialist);
            }
            else
            {
                Console.WriteLine("Invalid specialty. Please try again.");
            }
        }
        
        Console.WriteLine($"Number of current operatives: {rolodex.Count}");

        //new bank object
         Bank unitedBank = new Bank() {
            CashOnHand = 1000000,
            AlarmScore  = 80,
            VaultScore = 60,
            SecurityGuardScore= 50
        };

        Console.WriteLine("Recon Report: Most secure system: Alarm; Least Secure system: Vault");

    }
}
