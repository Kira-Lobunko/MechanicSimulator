using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    internal class FixTaskRepositoryImpl : FixTaskRepository
    {
        private readonly string repositoryPath = "FixTasks.json";
        private IList<FixTask> tasks = new List<FixTask>();

        public FixTaskRepositoryImpl()
        {
            LoadRepository();
        }

        private void StoreRepository()
        {
            string json = JsonConvert.SerializeObject(tasks, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText(repositoryPath, json);
        }

        private void LoadRepository()
        {
            if (File.Exists(repositoryPath))
            {
                try
                {
                    string json = File.ReadAllText(repositoryPath);
                    tasks = JsonConvert.DeserializeObject<List<FixTask>>(json, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                }
                catch
                {
                    tasks = new List<FixTask>();
                }
            }
        }
        public void Add(FixTask t)
        {
            tasks.Add(t);
            StoreRepository();
        }

        public IList<FixTask> GetAll()
        {
            return tasks;
        }

        public void Remove(FixTask t)
        {
            tasks.Remove(t);
            StoreRepository();
        }

        public void Clear()
        {
            tasks.Clear();
            StoreRepository();
        }
    }
}
