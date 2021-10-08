using API.DAL.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace API.DAL
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public async Task CreateAsync(T entity)
        {

            using (StreamWriter writer = File.CreateText(Path.GetTempFileName() + ".json"))
            {
                await writer.WriteAsync(JsonConvert.SerializeObject(entity));
            }

        }

    }
}
