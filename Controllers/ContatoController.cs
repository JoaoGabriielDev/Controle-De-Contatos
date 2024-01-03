using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ControleContatos.Models;
using ControleContatos.Repositorio;

namespace ControleContatos.Controllers;

public class ContatoController : Controller
{
    private readonly IContatoRepositorio _contatoRepositorio;
    public ContatoController(IContatoRepositorio contatoRepositorio)
    {
        _contatoRepositorio = contatoRepositorio;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Criar()
    {
        return View();
    }

    public IActionResult Editar()
    {
        return View();
    }
    public IActionResult ApagarConfirmacao()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(ContatoModel contato)
    {
        _contatoRepositorio.Adicionar(contato);
        return RedirectToAction("Index");
    }
}