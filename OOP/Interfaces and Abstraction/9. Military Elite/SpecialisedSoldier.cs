using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class SpecialisedSoldier : Soldier
    {
        private decimal salary;
        private static List<Commando> marinesCommandos = new List<Commando>();
        private static List<Engineer> marinesEngineers = new List<Engineer>();
        private static List<Commando> airforceCommandos = new List<Commando>();
        private static List<Engineer> airforceEngineers = new List<Engineer>();
        private string corps;
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName)
        {
            this.salary = salary;
            this.corps = corps;
        }
        protected decimal Salary { get { return salary; } }
        public static Commando LastCommando { get; set; }
        public static void AddMarinesEngineer(Engineer engineer, string[] repairs)
        {
            engineer.AddRepairs(repairs);
            marinesEngineers.Add(engineer);
        }
        public static void AddMarinesCommando(Commando commando)
        {
            marinesCommandos.Add(commando);
            LastCommando = commando;
        }
        public static void AddAirforceEngineer(Engineer engineer, string[] repairs)
        {
            airforceEngineers.Add(engineer);
            engineer.AddRepairs(repairs);
        }
        public static void AddAirforceCommando(Commando commando)
        {
            airforceCommandos.Add(commando);
            LastCommando = commando;
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary}\nCorps: {corps}\n";
        }
    }

}
