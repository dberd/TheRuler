using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRuler
{
    public class Event
    {
        public string dsc;
        public string dsc1, dsc2;
        //public int armyChange, popChange, fundChange, USSRChange, USAChange;
        /*public Event()
        {
            armyChange = 0;
            popChange = 0;
            fundChange = 0;
            USSRChange = 0;
            USAChange = 0;
        }*/
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int army = 50;
            int pop = 50;
            int fund = 50;
            int USA = 50;
            int USSR = 50;

            Random randomGenerator = new Random();
            while (true)
            {
                int ans = 0;
                int numEvent = randomGenerator.Next(1, 5);
                if (numEvent == 1)
                {
                    Event eventRebelAttack = new Event();
                    eventRebelAttack.dsc = "Rebels are attacking in the north";
                    eventRebelAttack.dsc1 = "We have to defend our population";
                    eventRebelAttack.dsc2 = "We have to pull back on better positions";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            pop += 15;
                            army -= 15;
                            break;
                        case 2:
                            pop -= 15;
                            army += 15;
                            break;
                    }
                }
                if (numEvent == 2)
                {
                    Event eventStarve = new Event();
                    eventStarve.dsc = "Our people are starving";
                    eventStarve.dsc1 = "I want to eat too";
                    eventStarve.dsc2 = "Here is your food";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            pop -= 30;
                            fund += 15;
                            break;
                        case 2:
                            fund -= 30;
                            pop += 15;
                            break;
                    }
                }
                if (numEvent == 3)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "Army asking for building a new Academy";
                    eventAcadem.dsc1 = "Why not?";
                    eventAcadem.dsc2 = "No we need to spend mour money more logically";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            fund -= 30;
                            army += 15;
                            break;
                        case 2:
                            army -= 30;
                            fund += 15;
                            break;
                    }
                }
                if (numEvent == 4)
                {
                    Event eventOpElect = new Event();
                    eventOpElect.dsc = "Official opposition is gaining support in future elections";
                    eventOpElect.dsc1 = "We need support of our people";
                    eventOpElect.dsc2 = "Make it quick...";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            fund -= 30;
                            pop += 15;
                            break;
                        case 2:
                            USSR -= 30;
                            USA -= 30;
                            break;
                    }
                }

                if ( pop >= 100 || pop <= 0 || 
                     army >= 100 || army <= 0 || 
                     fund >= 100 || fund <= 0 || 
                     USSR >= 100 || USSR <= 0 || 
                     USA >= 100 || USA <= 0 )
                {
                    if (pop >= 100)
                    {
                        Console.WriteLine("Resistance has grown too far and rebels conquered all of the country");
                        break;
                    }
                    else if (pop <= 0)
                    {
                        Console.WriteLine("Without any support of our people forces of UN came to our country");
                        break;
                    }
                    else if (army >= 100)
                    {
                        Console.WriteLine("Our Army became too powerful and overthrew us");
                        break;
                    }
                    else if (army <= 0)
                    {
                        Console.WriteLine("Without support of our army rebels easily took our palace");
                        break;
                    }
                    else if (fund >= 100)
                    {
                        Console.WriteLine("We had so much money in our treasury that people blamed us in deadly corruption and killed us");
                        break;
                    }
                    else if (army <= 0)
                    {
                        Console.WriteLine("We have nothing in our treasury and because of the crisis rebels took over the palace");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Without balanced support of superpowers they managed to divide our nation");
                        break;
                    }
                }
                if (USA <= 10)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "USA is going to attack us";
                    eventAcadem.dsc1 = "Ask Protection from the USSR";
                    eventAcadem.dsc2 = "Defend only by ourself";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            fund -= 15;
                            USSR -= 15;
                            USA += 15;
                            break;
                        case 2:
                            army -= 15;
                            USA += 15;
                            break;
                    }
                }
                if (USSR <= 10)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "USSR is going to attack us";
                    eventAcadem.dsc1 = "Ask Protection from the USA";
                    eventAcadem.dsc2 = "Defend only by ourself";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            fund -= 15;
                            USA -= 15;
                            USSR += 15;
                            break;
                        case 2:
                            army -= 15;
                            USSR += 15;
                            break;
                    }
                }
                if (fund <= 10)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "We have too low funding";
                    eventAcadem.dsc1 = "Increase taxes";
                    eventAcadem.dsc2 = "Ask International support";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            fund += 15;
                            pop -= 15;
                            break;
                        case 2:
                            fund += 15;
                            USSR -= 15;
                            USA -= 15;
                            break;
                    }
                }
                if (pop <= 10)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "We have too low support of our people";
                    eventAcadem.dsc1 = "Send in the Army";
                    eventAcadem.dsc2 = "Help With Funding Healthcare";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            army -= 15;
                            pop += 15;
                            break;
                        case 2:
                            fund -= 15;
                            pop += 15;
                            break;
                    }
                }
                if (army <= 10)
                {
                    Event eventAcadem = new Event();
                    eventAcadem.dsc = "We have too low support of our army";
                    eventAcadem.dsc1 = "Start few Purges";
                    eventAcadem.dsc2 = "Buy some people";
                    ans = Int32.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            army += 15;
                            pop -= 15;
                            break;
                        case 2:
                            fund -= 15;
                            army += 15;
                            break;
                    }
                }
            }
        }
    }
}