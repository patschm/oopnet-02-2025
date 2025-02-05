using Dependencies;
using Microsoft.AspNetCore.Mvc;

namespace CounterApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : ControllerBase
    {        
        private readonly ICounter _counter;

        public CounterController(ICounter counter)
        {
            //_counter = new FaultyCounter(new Payment());
            _counter = counter;
        }

        [HttpGet(Name = "Increment")]
        public int Get()
        {
           _counter.Increment();
            return _counter.CounterValue;
        }
    }
}
