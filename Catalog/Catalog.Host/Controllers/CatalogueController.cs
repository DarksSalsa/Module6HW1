using Catalog.Host.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route("[controller]")]
public class CatalogueController : ControllerBase
{
    private static readonly string[] Products = new[] 
        {"Shorts", "T-shirt","Sweater", "Jacket", "Coat","Jeans","Socks","Tracksuit" };

    private static readonly string[] Colors = new[]
        {"Green", "Blue","Black", "White", "Red","Violet","Brown","Grey" };

    private readonly ILogger<CatalogueController> _logger;

    public CatalogueController(ILogger<CatalogueController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCatalogue")]
    public IEnumerable<ClothingPiece> Get()
    {
        return Enumerable.Range(1, Products.Length).Select(i => new ClothingPiece()
        {
            ObjectsType = Products[Random.Shared.Next(Products.Length)],
            Color = Colors[Random.Shared.Next(Colors.Length)],
            Price = Math.Round(Random.Shared.NextDouble() * 100 + 10, 4),
            CollectionArrivalDate = DateTime.UtcNow.AddDays(Random.Shared.NextDouble() * 10)
        }).ToArray();
    }
}

