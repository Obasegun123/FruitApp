using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FruitApi.Model;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FruitApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitApiController : ControllerBase
    {
        public string GetByName(string name)
    {
            string fileName = "jsonFruit.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
           Fruit fruits = JsonSerializer.Deserialize<Fruit>(jsonString);
            return jsonString;
    }
    }
 }       