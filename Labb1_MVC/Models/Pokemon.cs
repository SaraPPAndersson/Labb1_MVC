using System.Text.Json.Serialization;
using static Labb1_MVC.Models.PokemonDetails;

namespace Labb1_MVC.Models
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
        [JsonPropertyName("types")]
        public List<PokemonType> Types { get; set; } = new();
        [JsonPropertyName("stats")]
        public List<PokemonStat> Stats { get; set; } = new();
        [JsonPropertyName("abilities")]
        public List<PokemonAbility> Abilities { get; set; } = new();
    }
}
