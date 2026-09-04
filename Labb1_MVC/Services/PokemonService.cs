using Labb1_MVC.Models;
using System.Xml.Linq;

namespace Labb1_MVC.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;
        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PokemonListItem>?> GetPokemonListsAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<PokemonListResponse>("pokemon?limit=50");
                if ( response == null)
                {
                    return new List<PokemonListItem>();
                }
                return response.Results;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Pokemon?> GetPokemonByNameAsync(string name)
        {
            try
            {
                var pokemon = await _httpClient.GetFromJsonAsync<Pokemon>($"pokemon/{name.ToLower()}");
                return pokemon;
            }
            catch (Exception)
            {
                return null;
            }
        }
    } 
}
