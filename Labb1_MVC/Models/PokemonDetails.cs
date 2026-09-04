using System.Text.Json.Serialization;

namespace Labb1_MVC.Models
{
    public class PokemonDetails
    {
        public class PokemonType
        {
            [JsonPropertyName("type")]
            public TypeInfo Types { get; set; }
        }

        public class PokemonStat
        {
            [JsonPropertyName("base_stat")]
            public int BaseStat { get; set; }

            [JsonPropertyName("stat")]
            public StatInfo Stats { get; set; } = new();
        }

        public class PokemonAbility
        {
            [JsonPropertyName("ability")]
            public AbilityInfo Abilities { get; set; }
        }

        public class TypeInfo
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;
        }

        public class StatInfo
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;
        }

        public class AbilityInfo
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = string.Empty;

            [JsonPropertyName("url")]
            public string Url { get; set; } = string.Empty;
        }

    }
}
