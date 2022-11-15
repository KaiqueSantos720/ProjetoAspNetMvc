using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class TimeController : Controller
{
    private readonly TwoFootballContext _context;

    public TimeController(TwoFootballContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Time);
    }

    public IActionResult Show(int id)
    {
        Time time = _context.Time.Find(id);

        if(time == null)
        {
            return NotFound();
        }

        return View(time);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Time time)
    {
        if(!ModelState.IsValid) 
        {
            return View(time);
        }

        _context.Time.Add(time);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Time time = _context.Time.Find(id);

        if(time == null)
        {
            return NotFound();
        }

        return View(time);
    }

    [HttpPost]
    public IActionResult Update(Time time, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(time);
        }

        Time updateTime = _context.Time.Find(time.Id);
        
        updateTime.Pais = time.Pais;
        updateTime.Patrocinador = time.Patrocinador;
        updateTime.Titulos = time.Titulos;
        updateTime.JogadorDeDestaque = time.JogadorDeDestaque;

        _context.Time.Update(updateTime);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Time time = _context.Time.Find(id);

        if(time == null)
        {
            return NotFound();
        }
        
        _context.Time.Remove(_context.Time.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}