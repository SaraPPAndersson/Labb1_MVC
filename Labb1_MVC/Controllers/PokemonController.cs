using Microsoft.AspNetCore.Mvc;
using Labb1_MVC.Services;
using Labb1_MVC.Models;

namespace Labb1_MVC.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;
        public PokemonController(IPokemonService PokemonService)
        {
            _pokemonService = PokemonService;
        }
        //Show the list of all pokémon
        public async Task<IActionResult> Index()
        {
            var pokemonList = await _pokemonService.GetPokemonListsAsync();
            //if API failed 
            if(pokemonList == null)
            {
                ViewBag.ErrorMessage = "Can't load Pokémon right now, try again later";
                return View(new List<PokemonListItem>());
            }
            var sortedList = pokemonList.OrderBy(p => p.Name).ToList();
            return View(sortedList);
        }
        //Show details for one specific pokémon
        public async Task<IActionResult> Details(string name)
        {
            var pokemon = await _pokemonService.GetPokemonByNameAsync(name);
            if (pokemon == null)
            {
                ViewBag.ErrorMessage = $"Cannot find Pokémon: {name}";
                return View("NotFound");
            }
            return View("PokemonDetails", pokemon);
        }
        //Handle pokémon search
        [HttpGet]
        public async Task<IActionResult> PokemonSearch(string query)
        {
            var pokemonList = await _pokemonService.GetPokemonListsAsync();
            if (pokemonList == null)
            {
                ViewBag.ErrorMessage = "Can't load Pokémon right now, try again later";
                return View("Index", new List<PokemonListItem>());
            }
            if (string.IsNullOrWhiteSpace(query))
            {
                return View("Index", pokemonList);
            }
            //Filter the list only pokémon whose name contails the search text
            var filteredList = pokemonList
                .Where(p => p.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return View("Index", filteredList);
        }
    }
}
