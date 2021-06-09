using System;

namespace  heistpart2
{
    public class Muscle : IRobber 
    {

        public string Name {get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PreformSkill(Bank bank)
        {
            bank.SecureityGaurdScore = bank.SecureityGaurdScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the lock. Decreased by {SkillLevel}");
            if(bank.SecureityGaurdScore <= 0)
            {
                Console.WriteLine($"{Name} has opened the Vault");
            }
        }    
    }
}