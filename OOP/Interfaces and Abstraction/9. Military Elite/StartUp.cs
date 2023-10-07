using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class StartUp
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split().ToList();
            List<Soldier> soldiers = new List<Soldier>();
            List<SpecialisedSoldier> Spsoldiers = new List<SpecialisedSoldier>();
            string lastCommandoCorp = "";
            while (list[0] != "End")
            {
                switch (list[0])
                {
                    case "Private":
                        soldiers.Add(new Private(list[1], list[2], list[3], decimal.Parse(list[4])));
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral lt = new LieutenantGeneral(list[1], list[2], list[3], decimal.Parse(list[4]));
                        list = list.Skip(5).ToList();
                        lt.PrivateCommanding(soldiers, list);
                        soldiers.Add(lt);
                        break;
                    case "Commando":
                        if (list[5] == "Marines")
                        {
                            Commando commando = new Commando(list[1], list[2], list[3], decimal.Parse(list[4]), list[5]);
                            soldiers.Add(commando);
                            SpecialisedSoldier.AddMarinesCommando(commando);

                        }
                        if (list[5] == "Airforces")
                        {
                            Commando commando = new Commando(list[1], list[2], list[3], decimal.Parse(list[4]), list[5]);
                            soldiers.Add(commando);
                            SpecialisedSoldier.AddAirforceCommando(commando);
                        }
                        lastCommandoCorp = list[5];
                        break;
                    case "Engineer":
                        if (list[5] == "Marines")
                        {
                            Engineer engineer = new Engineer(list[1], list[2], list[3], decimal.Parse(list[4]), list[5]);
                            soldiers.Add(engineer);
                            SpecialisedSoldier.AddMarinesEngineer(engineer, list.Skip(6).ToArray());
                        }
                        
                        if (list[5] == "Airforces")
                        {
                            Engineer engineer = new Engineer(list[1], list[2], list[3], decimal.Parse(list[4]), list[5]);
                            soldiers.Add(engineer);
                            SpecialisedSoldier.AddAirforceEngineer(engineer, list.Skip(6).ToArray());
                        }
                        break;
                    case "Spy":
                        soldiers.Add(new Spy(list[1], list[2], list[3], list[4]));
                        break;
                    default:
                        SpecialisedSoldier.LastCommando.AddMission(list.ToArray());
                        break;
                }
                list = Console.ReadLine().Split().ToList();
            }
            soldiers.ForEach(sol => Console.WriteLine(sol.ToString()));
        }
    }
}
