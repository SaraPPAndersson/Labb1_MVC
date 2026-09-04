using System.Text.Json.Serialization;

namespace Labb1_MVC.Models
{
    public class PokemonListItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;

    }

    public class PokemonListResponse
    {
        [JsonPropertyName("results")]
        public List<PokemonListItem> Results { get; set; } = new();
    }

}
