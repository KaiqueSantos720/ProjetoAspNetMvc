using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class EstadioController : Controller 
{
    private readonly TwoFootballContext _context;

    public EstadioController(TwoFootballContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Estadio);
    }

    public IActionResult Show(int id)
    {
        Estadio estadio = _context.Estadio.Find(id);

        if(estadio == null)
        {
            return NotFound();
        }

        return View(estadio);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Estadio estadio)
    {
        if(!ModelState.IsValid) 
        {
            return View(estadio);
        }

        _context.Estadio.Add(estadio);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Estadio estadio = _context.Estadio.Find(id);

        if(estadio == null)
        {
            return NotFound();
        }

        return View(estadio);
    }

    [HttpPost]
    public IActionResult Update(Estadio estadio, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(estadio);
        }

        Estadio updateEstadio = _context.Estadio.Find(estadio.Id);
        
        updateEstadio.Nome = estadio.Nome;
        updateEstadio.Cidade = estadio.Cidade;
        updateEstadio.Capacidade = estadio.Capacidade;


        _context.Estadio.Update(updateEstadio);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Estadio estadio = _context.Estadio.Find(id);

        if(estadio == null)
        {
            return NotFound();
        }
        
        _context.Estadio.Remove(_context.Estadio.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }


}