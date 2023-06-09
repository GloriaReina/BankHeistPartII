public class LockSpecialist:RobberReport,IRobber
{
  public string Name {get;set;}  
  public string Specialty {get;set;}  
  public int SkillLevel {get;set;}
  public int PercentageCut {get;set;}

  public void PerformSkill(Bank bank){
    bank.AlarmScore = bank.AlarmScore - SkillLevel;

    Console.WriteLine($"Mr {Name}is hacking the alarm system. Decreased security by {SkillLevel} points");

    if(bank.AlarmScore <= 0){
        Console.WriteLine($"Mr{Name}has disabled the alarm system!");
    }

  }
}