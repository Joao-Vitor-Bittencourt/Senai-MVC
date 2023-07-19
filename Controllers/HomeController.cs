using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Joao", "043.246.871.01", "joao@bittencourt.com", "Laiedson");

        Cliente cliente2 = new Cliente(02, "Bittencourt", "888.888.888.45", "bittencourt@joao.com", "Chinchila"); 

        Cliente cliente3 = new Cliente(03, "Mouto", "444.444.555.21", "mouto@animal", "Dragão de Komodo");

        Cliente cliente4 = new Cliente(03, "Mouto", "444.321.231.21", "mouto@lapela", "Lampâda");

        Cliente cliente5 = new Cliente(03, "Samanta", "424.444.525.21", "samanta@animal", "Macaco Prego");

        Cliente cliente6 = new Cliente(03, "Placa", "442.111.515.21", "mouto@animalesco", "Peixe Dourado");


        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        listaClientes.Add(cliente6);

        ViewBag.listaClientes = listaClientes;
        
        Fornecedor fornecedor1 = new Fornecedor(01, "C# Pets S/A", "01.124.123/0000-34", "c-sharp@net.org");

        Fornecedor fornecedor2 = new Fornecedor(02, "Animais", "04.765.123.43/0000-12", "animais@animais.org");

        Fornecedor fornecedor3 = new Fornecedor(03, "Aráras", "01.546.123/0000-97", "sala@maleico.org");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
