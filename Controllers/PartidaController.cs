using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class PartidaController : Controller
{
    private readonly TwoFootballContext _context;

    public PartidaController(TwoFootballContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Partida);
    }

    public IActionResult Show(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }

        return View(partida);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Partida partida)
    {
        if(!ModelState.IsValid) 
        {
            return View(partida);
        }

        _context.Partida.Add(partida);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }

        return View(partida);
    }

    [HttpPost]
    public IActionResult Update(Partida partida, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(partida);
        }

        Partida updatePartida = _context.Partida.Find(partida.Id);
        
        updatePartida.TimeDaCasa = partida.TimeDaCasa;
        updatePartida.TimeVisitante = partida.TimeVisitante;
        updatePartida.Data = partida.Data;

        _context.Partida.Update(updatePartida);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Partida partida = _context.Partida.Find(id);

        if(partida == null)
        {
            return NotFound();
        }
        
        _context.Partida.Remove(_context.Partida.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}