using Elfie.Serialization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.IO;

namespace DogBreed.Models
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDogsFromJson(this ModelBuilder modelBuilder)
        {

            string basePath = Environment.CurrentDirectory;
            string filePath = "\\wwwroot\\file\\dogs.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", basePath + filePath);
            if (!File.Exists(path)) return;

            var json = File.ReadAllText(path);
            var data = JObject.Parse(json);

            int id = 1;
            var breeds = new List<DogBreed>();

            foreach (var breed in data)
            {
                var breedName = breed.Key.ToLowerInvariant();
                var subBreeds = breed.Value as JArray;

                if (subBreeds == null || subBreeds.Count == 0)
                {
                    breeds.Add(new DogBreed
                    {
                        Id = id++,
                        Breed = breedName,
                        SubBreed = null
                    });
                }
                else
                {

                    breeds.Add(new DogBreed
                    {
                        Id = id++,
                        Breed = breedName,
                        SubBreed = subBreeds.ToString().Replace(@"[", string.Empty).Replace(@"]", string.Empty).Replace(@"""", string.Empty)
                    });
                }
            }

            modelBuilder.Entity<DogBreed>().HasData(breeds);
        }
    }
}
