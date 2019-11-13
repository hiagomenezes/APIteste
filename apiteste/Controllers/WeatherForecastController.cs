using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


public class pessoa
{
    public string nome { get; set; }
    public int idade { get; set; }
    public string cpf { get; set; }
    public string rg { get; set; }
    public string data_nasc { get; set; }
    public string signo { get; set; }
    public string mae { get; set; }
    public string pai { get; set; }
    public string email { get; set; }
    public string senha { get; set; }
    public string cep { get; set; }
    public string endereco { get; set; }
    public int numero { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
    public string telefone_fixo { get; set; }
    public string celular { get; set; }
    public string altura { get; set; }
    public int peso { get; set; }
    public string tipo_sanguineo { get; set; }
    public string cor { get; set; }
}

namespace apiteste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost("Inova")]
        public List<pessoa> teste([FromBody] List<pessoa> json)
        {

            List<pessoa> teste = json;

            return teste;



        }

    }



}
