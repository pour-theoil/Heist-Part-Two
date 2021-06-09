using System;

namespace heistpart2
{
    public class Hacker :  IRobber
    {
public string Name {get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PreformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the security system. Decreased by {SkillLevel}");
            if(bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the security");
            }
            Console.WriteLine("");
        }    
    }
}