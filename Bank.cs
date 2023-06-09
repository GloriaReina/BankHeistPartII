public class Bank {
    public int CashOnHand {get;set;}
    public int AlarmScore {get;set;}
    public int VaultScore {get;set;}
    public int SecurityGuardScore {get;set;}
    public bool IsSecure {get;set;}


   public void IsItSecure(){
    int allScore = AlarmScore + VaultScore + SecurityGuardScore;

    if (allScore<= 0){
        IsSecure = false;
    }
    else
    {
        IsSecure = true;
    }
   } 
}