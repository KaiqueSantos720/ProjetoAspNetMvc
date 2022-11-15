using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class ConfederacaoController : Controller 
{
    private readonly TwoFootballContext _context;

    public ConfederacaoController(TwoFootballContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Confederacao);
    }

    public IActionResult Show(int id)
    {
        Confederacao confederacao = _context.Confederacao.Find(id);

        if(confederacao == null)
        {
            return NotFound();
        }

        return View(confederacao);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Confederacao confederacao)
    {
        if(!ModelState.IsValid) 
        {
            return View(confederacao);
        }

        _context.Confederacao.Add(confederacao);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Confederacao confederacao = _context.Confederacao.Find(id);

        if(confederacao == null)
        {
            return NotFound();
        }

        return View(confederacao);
    }

    [HttpPost]
    public IActionResult Update(Confederacao confederacao, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(confederacao);
        }
        
        Confederacao updateConfederacao = _context.Confederacao.Find(confederacao.Id);
        
        updateConfederacao.Nome = confederacao.Nome;
        updateConfederacao.Continente = confederacao.Continente;
        updateConfederacao.Vagas = confederacao.Vagas;

        _context.Confederacao.Update(updateConfederacao);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Confederacao confederacao = _context.Confederacao.Find(id);

        if(confederacao == null)
        {
            return NotFound();
        }
        
        _context.Confederacao.Remove(_context.Confederacao.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }


}