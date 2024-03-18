using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    internal class MechanicRepositoryImpl : MechanicRepository
    {
        private readonly string repositoryPath = "Mechanics.json";
        private IList<Mechanic> mechanics =  new List<Mechanic>();

        public MechanicRepositoryImpl()
        {
            LoadRepository();        
        }

        private void StoreRepository() 
        {
                string json = JsonConvert.SerializeObject(mechanics, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                File.WriteAllText(repositoryPath, json);
        }

        private void LoadRepository()
        {
            if (File.Exists(repositoryPath))
            {
                try
                {
                    string json = File.ReadAllText(repositoryPath);
                     mechanics = JsonConvert.DeserializeObject<List<Mechanic>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                }
                catch
                {
                    mechanics =  new List<Mechanic>();
                }
            }
        }
        public void Add(Mechanic m)
        {
            mechanics.Add(m);
            StoreRepository();
        }

        public IList<Mechanic> GetAll()
        {
            return mechanics;
        }

        public void Remove(Mechanic m)
        {
            mechanics.Remove(m);
            StoreRepository();
        }

        public void Clear()
        {
            mechanics.Clear();
            StoreRepository();
        }
    }
}
