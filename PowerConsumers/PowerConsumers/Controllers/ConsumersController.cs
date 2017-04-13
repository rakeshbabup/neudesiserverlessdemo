using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerConsumers.Controllers
{
    [Route("api/[controller]")]
    public class ConsumersController : Controller
    {
        [HttpGet]
        [Route("/api/consumers/total")]
        public int GetTotalCount()
        {
            var randomizer = new Random(1000000);
            return randomizer.Next(1000200);
        }


        [HttpGet]
        [Route("/api/consumers/{start}/{count}")]
        public IEnumerable<Consumer> GetCustomers(int start, int count)
        {
            var randomizer = new Random(1000000);
            var currentBatch = new List<Consumer>();
            int counter = 1;
            do
            {
                var consumer = new Consumer();
                consumer.FirstName = $"FirstName{counter}";
                consumer.LastName = $"LastName{counter}";
                consumer.ConsumerNumber = (uint)randomizer.Next(5000000);
                consumer.PersonalPreferences = new NotificationPreferences {IsEmailEnabled = true, IsSmsEnabled = counter % 2 == 0 ? true : false };
                currentBatch.Add(consumer);
            }
            while (count > counter++);
            return currentBatch;
        }
    }
}
