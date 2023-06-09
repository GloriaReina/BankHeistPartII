public class RobberReport
{

//made the method static so that in program.cs i dont have to instantiate it ie RobberReport robberReport = new RobberReport(); robberReport.RobberListReport(rolodex)------> instead syntax can be ---> RobberReport.RobberListReport(rolodex);
    public static void RobberListReport(List<IRobber>RobberList){
        
         Console.WriteLine("Operatives:");
        for (int i = 0; i < RobberList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Name: {RobberList[i].Name}, Specialty: {RobberList[i].Specialty},{RobberList[i].SkillLevel},{RobberList[i].PercentageCut}");
        }

    }
}