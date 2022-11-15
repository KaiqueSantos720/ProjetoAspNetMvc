using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class GrupoController : Controller 
{
    private readonly TwoFootballContext _context;

    public GrupoController(TwoFootballContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Grupo);
    }

    public IActionResult Show(int id)
    {
        Grupo grupo = _context.Grupo.Find(id);

        if(grupo == null)
        {
            return NotFound();
        }

        return View(grupo);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Grupo grupo)
    {
        if(!ModelState.IsValid) 
        {
            return View(grupo);
        }

        _context.Grupo.Add(grupo);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        
        Grupo grupo = _context.Grupo.Find(id);

        if(grupo == null)
        {
            return NotFound();
        }

        return View(grupo);
    }

    [HttpPost]
    public IActionResult Update(Grupo grupo, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(grupo);
        }
        
        Grupo updateGrupo = _context.Grupo.Find(grupo.Id);
        
        updateGrupo.Nome = grupo.Nome;
        updateGrupo.Pote1 = grupo.Pote1;
        updateGrupo.Pote2 = grupo.Pote2;
        updateGrupo.Pote3 = grupo.Pote3;
        updateGrupo.Pote4 = grupo.Pote4;

        _context.Grupo.Update(updateGrupo);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Grupo grupo = _context.Grupo.Find(id);

        if(grupo == null)
        {
            return NotFound();
        }
        
        _context.Grupo.Remove(_context.Grupo.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }


}