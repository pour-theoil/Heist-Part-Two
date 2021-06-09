using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace heistpart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            void header()
            {
                Console.WriteLine(@"
 /$$   /$$           /$$             /$$            /$$$$$$                                   
| $$  | $$          |__/            | $$           /$$__  $$                                  
| $$  | $$  /$$$$$$  /$$  /$$$$$$$ /$$$$$$        | $$  \__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$ 
| $$$$$$$$ /$$__  $$| $$ /$$_____/|_  $$_/        | $$ /$$$$ |____  $$| $$_  $$_  $$ /$$__  $$
| $$__  $$| $$$$$$$$| $$|  $$$$$$   | $$          | $$|_  $$  /$$$$$$$| $$ \ $$ \ $$| $$$$$$$$
| $$  | $$| $$_____/| $$ \____  $$  | $$ /$$      | $$  \ $$ /$$__  $$| $$ | $$ | $$| $$_____/
| $$  | $$|  $$$$$$$| $$ /$$$$$$$/  |  $$$$/      |  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$
|__/  |__/ \_______/|__/|_______/    \___/         \______/  \_______/|__/ |__/ |__/ \_______/           
            
                                                                                           ");
            }
            header();
            IRobber hack = new Hacker();
            hack.Name = "Martin Bishop";
            hack.SkillLevel = 50;
            hack.PercentageCut = 10;

            IRobber hacks = new Hacker();
            hacks.Name = "Cosmo";
            hacks.SkillLevel = 99;
            hacks.PercentageCut = 10;

            IRobber mrstrong = new Muscle();
            mrstrong.Name = "Donald Vrease";
            mrstrong.SkillLevel = 99;
            mrstrong.PercentageCut = 40;

            IRobber pick = new LockSpecialist();
            pick.Name = "Mother";
            pick.SkillLevel = 99;
            pick.PercentageCut = 10;

            IRobber picker = new LockSpecialist();
            picker.Name = "Whistler";
            picker.SkillLevel = 99;
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
                Console.WriteLine("What is their cut? (1-100) ");
                while (true)
                {
                    string cuts = Console.ReadLine();
                    if (int.TryParse(cuts, out Cut) && Cut > 0 && Cut < 101)
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
                    rolodex.Add(add);
                }
                else if (Choice == 2)
                {
                    IRobber add = new Muscle();
                    add.Name = name;
                    add.SkillLevel = Skill;
                    add.PercentageCut = Cut;
                    rolodex.Add(add);
                }
                else
                {
                    IRobber add = new LockSpecialist();
                    add.Name = name;
                    add.SkillLevel = Skill;
                    add.PercentageCut = Cut;
                    rolodex.Add(add);
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
            Console.Clear();
            header();
            void secure(){

            if (newbank.AlarmScore > newbank.SecureityGaurdScore && newbank.AlarmScore > newbank.VaultScore)
            {
                if (newbank.SecureityGaurdScore > newbank.VaultScore)
                {
                    Console.WriteLine("Most Secure: Alarm     Least Secure: Vault");
                }
                else
                {
                    Console.WriteLine("Most Secure: Alarm     Least Secure: Gaurd");
                }
            }
            else if (newbank.SecureityGaurdScore > newbank.AlarmScore && newbank.SecureityGaurdScore > newbank.AlarmScore)
            {
                if (newbank.VaultScore > newbank.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Gaurd     Least Secure: Alarm");
                }
                else
                {
                    Console.WriteLine("Most Secure: Gaurd     Least Secure: Vault");
                }
            }
            else
            {
                if (newbank.SecureityGaurdScore > newbank.AlarmScore)
                {
                    Console.WriteLine("Most Secure: Vault     Least Secure: Gaurd");
                }
                else
                {
                    Console.WriteLine("Most Secure: Vault     Least Secure: Alarm");
                }
            }
            }


            List<IRobber> crew = new List<IRobber>();

            while (true)
            {
                Console.Clear();
                header();
                secure();
                Console.WriteLine("Build your crew");


                int k = 0;
                var list3 = rolodex.Except(crew).ToList();
                foreach (IRobber l in list3)
                {

                    Console.WriteLine($@"Name: {l.Name}
Skill: {l.SkillLevel}
Precentage Cut: {l.PercentageCut}
Index: {k}
");
                    k++;
                }
                Console.WriteLine("Enter the index of the crew you would like to add: ");
                string member = Console.ReadLine();
                if (member == "")
                {
                    break;
                }
                int Member;
                while (true)
                {

                    if (int.TryParse(member, out Member) && Member >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Enter the index of the crew you would like to add: ");
                    member = Console.ReadLine();
                }

                int cut = 0;
                foreach (IRobber r in crew)
                {
                    cut += r.PercentageCut;
                }
                cut = cut + list3[Member].PercentageCut;
                if (cut < 100)
                {

                    crew.Add(list3[Member]);
                }
                else
                {
                    Console.WriteLine("You cannot afford to pay them add a different member");
                    System.Threading.Thread.Sleep(2000);
                }


            }

            Console.Clear();
            header();
            foreach (IRobber ir in crew)
            {
                ir.PreformSkill(newbank);
            }

            if (newbank.IsSecure())
            {
                Console.WriteLine("You Failed to break into the bank");
            }
            else
            {
                Console.WriteLine("You broke into the bank");
                int payout = 0;
                foreach (IRobber rob in crew)
                {
                    payout += rob.PercentageCut;
                    int payoutcut = rob.PercentageCut*newbank.CashOnHand/100;
                    Console.WriteLine($"{rob.Name} got ${payoutcut}");
                }
                Console.WriteLine($"After paying all of your crew you are left with ${newbank.CashOnHand-(payout/100*newbank.CashOnHand)}");
            }
        }
    }
}

