using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace DogBreed.Models
{

    public class DogBreed
    {
        public int Id { get; set; }
        public string Breed { get; set; } = string.Empty;
        public string? SubBreed { get; set; }

        //public JArray SubBreed { get; set; }
    }
}