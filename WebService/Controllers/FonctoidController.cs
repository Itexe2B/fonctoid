using Microsoft.AspNetCore.Mvc;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JsonController : ControllerBase
    {

        private readonly ILogger<JsonController> _logger;

        public JsonController(ILogger<JsonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetJson")]
        public Dictionary<string, List<String>> Get()
        {
            var dico = new Dictionary<string, List<String>>();
            for (int i = 0; i < Data.Data.csv.Count; i++)
            {
                List<String> row = Data.Data.csv[i];
                dico.Add(Data.Data.header[i], row);

            }
            return dico;
        }


    }
}