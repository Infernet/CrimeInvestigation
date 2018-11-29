using CrimeInvestigation.Classes.Comparers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeInvestigation.Classes
{
    class DataSingleton
    {
        public List<Policeman> Policemen;
        public List<CriminalCase> CriminalCases;
        private static DataSingleton instance;

        public Policeman CurrentPoliceman;
        public CriminalCase CurrentCriminalCase;

        public List<string> FNames;
        public List<string> Lnames;
        public List<string> Ranks;

        public List<string> Complexity;

        public List<string> Logs;

        private DataSingleton()
        {
            Policemen = new List<Policeman>();
            CriminalCases = new List<CriminalCase>();
            FNames = DataBus.GetFirstNames();
            Lnames = DataBus.GetLastNames();
            Ranks = DataBus.GetRanks();
            Complexity = DataBus.GetСomplexity();
            Logs = new List<string>();
        }

        public static DataSingleton GetInstance()
        {
            if (instance == null)
                instance = new DataSingleton();
            return instance;
        }

        public void ChainCreate()
        {
            if (Policemen.Count > 1)
            {
                Policemen.Sort(new PolicemanByRank());
                for (int i = 0; i < Policemen.Count - 1; i++)
                    Policemen[i].Successor = Policemen[i + 1];
            }
        }
    }
}
