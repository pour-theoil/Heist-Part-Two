using System;
using System.Collections.Generic;

namespace heistpart2
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobber hack = new Hacker();
            hack.Name = "Martin Bishop";
            hack.SkillLevel = 50;
            hack.PercentageCut = 10;

            IRobber hacks = new Hacker();
            hacks.Name = "Cosmo";
            hacks.SkillLevel = 50;
            hacks.PercentageCut = 10;

            IRobber mrstrong = new Muscle();
            mrstrong.Name = "Donald Vrease";
            mrstrong.SkillLevel = 50;
            mrstrong.PercentageCut = 10;

            IRobber pick = new LockSpecialist();
            pick.Name = "Mother";
            pick.SkillLevel = 50;
            pick.PercentageCut = 10;

            IRobber picker = new LockSpecialist();
            picker.Name = "Whistler";
            picker.SkillLevel = 50;
            picker.PercentageCut = 10;

            List<IRobber> rolodex = new List<IRobber>() { hack, hacks, mrstrong, pick, picker };

            Console.WriteLine($"There are {rolodex.Count} in your rolox of crew.");

            while (true)
            {
                Console.WriteLine("Add members to your crew, whats the members name? ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                Console.WriteLine(@"What is their speciality? 
1) Hacker (Disables alarms)
2) Muscle (Disarms guards)
3) Lock Specialist (cracks vault)");
                int Choice;
                while (true)
                {
                    string choice = Console.ReadLine();
                    if (int.TryParse(choice, out Choice) && Choice > 0 && Choice < 4)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a number between 1-3...");
                }

                Console.WriteLine("What is their skill level? (1-100) ");
                int Skill;
                while (true)
                {
                    string skill = Console.ReadLine();
                    if (int.TryParse(skill, out Skill) && Skill > 0 && Skill < 101)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a number between 1-100...");
                }

                int Cut;
                while (true)
                {
                    string cut = Console.ReadLine();
                    if (int.TryParse(cut, out Cut) && Cut > 0 && Cut < 101)
                    {
                        break;
                    }
                    Console.WriteLine("Please enter a number between 1-100...");
                }


                if (Choice == 1)
                {
                    IRobber add = new Hacker();
                    add.Name = name;
                    add.SkillLevel = Skill;
                    add.PercentageCut = Cut;
                }
                else if (Choice == 2)
                {
                    IRobber add = new Muscle();
                    add.Name = name;
                    add.SkillLevel = Skill;
                    add.PercentageCut = Cut;
                }
                else
                {
                    IRobber add = new LockSpecialist();
                    add.Name = name;
                    add.SkillLevel = Skill;
                    add.PercentageCut = Cut;
                }
            }


            Bank newbank = new Bank();
            Random i = new Random();
            int genRand = i.Next(0, 100);
            newbank.AlarmScore = genRand;

            genRand = i.Next(0, 100);
            newbank.SecureityGaurdScore = genRand;

            genRand = i.Next(0, 100);
            newbank.VaultScore = genRand;

            genRand = i.Next(50000, 1000000);
            newbank.CashOnHand = genRand;

            if (newbank.AlarmScore > newbank.SecureityGaurdScore && newbank.AlarmScore > newbank.VaultScore)
            {
                if (newbank.SecureityGaurdScore > newbank.VaultScore)
                {
                    Console.WriteLine("Most Secure: Alarm     Lease Secure: Vault");
                }
                else
                {
                    Console.WriteLine("Most Secure: Alarm     Lease Secure: Gaurd");
                }
            }
            else if (newbank.SecureityGaurdScore > newbank.AlarmScore && newbank.SecureityGaurdScore > newbank.AlarmScore)
            {
                if (newbank.VaultScore > newbank.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Gaurd     Lease Secure: Alarm");
                }
                else
                {
                    Console.WriteLine("Most Secure: Gaurd     Lease Secure: Vault");
                }
            }
            else
            {
                if (newbank.SecureityGaurdScore > newbank.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Vault     Lease Secure: Gaurd");
                }  
                else{
                    Console.WriteLine("Most Secure: Vault     Lease Secure: Alarm");
                }
            }
            Console.WriteLine(newbank.AlarmScore);
            Console.WriteLine(newbank.SecureityGaurdScore);
            Console.WriteLine(newbank.VaultScore);
            Console.WriteLine(newbank.CashOnHand);

        }
    }
}
