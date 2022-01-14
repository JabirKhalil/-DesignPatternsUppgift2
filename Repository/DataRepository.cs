using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class DataRepository : IDataRepository
    {
        public SimulatedDatabase simulatedDatabase { get; set; }
        public DataRepository()
        {
            simulatedDatabase = new SimulatedDatabase();
        }
        public string GetAnimal()
        {
            return simulatedDatabase.GetAnimal();
        }

        public string GetCustomer()
        {
            return simulatedDatabase.GetCustomer();
        }

        public string GetData()
        {
            return simulatedDatabase.GetData();
        }

        public string Load(string v)
        {
            return simulatedDatabase.Load(v);
        }

        public void Save(string data)
        {
             simulatedDatabase.Save(data);
        }
    }
}
