using Labb1_MVC.Models;

namespace Labb1_MVC.Services
{
    public interface IPokemonService
    {
        Task<List<PokemonListItem>?> GetPokemonListsAsync();
        Task<Pokemon?> GetPokemonByNameAsync(string name);
    }
}
