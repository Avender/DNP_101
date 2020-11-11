using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebAPI.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;


namespace WebAPI.Data
{
    public class AdultService : IAdultService
    {
        
        private FileContext fileContext;
        
        public AdultService()
        {
            fileContext = new FileContext();
        }

        
        public Task<IList<Adult>> getAdult()
        {
            return Task.FromResult(fileContext.Adults);
        }

        public async Task Add(Adult newAdult)
        {
            fileContext.Adults.Add(newAdult);
            fileContext.SaveChanges();
        }

        public async Task Remove(Adult adultToRemove)
        {
            fileContext.Adults.Remove(adultToRemove);
            fileContext.SaveChanges();
        }
    }
}