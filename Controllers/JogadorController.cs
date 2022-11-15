using Microsoft.AspNetCore.Mvc;
using TwoFootball.Models;

namespace TwoFootball.Controllers;

public class JogadorController : Controller 
{
    private readonly TwoFootballContext _context;

    public JogadorController(TwoFootballContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View(_context.Jogador);
    }

    public IActionResult Show(int id)
    {
        Jogador jogador = _context.Jogador.Find(id);

        if(jogador == null)
        {
            return NotFound();
        }

        return View(jogador);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Jogador jogador)
    {
        if(!ModelState.IsValid) 
        {
            return View(jogador);
        }

        _context.Jogador.Add(jogador);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
        Jogador jogador = _context.Jogador.Find(id);

        if(jogador == null)
        {
            return NotFound();
        }

        return View(jogador);
    }

    [HttpPost]
    public IActionResult Update(Jogador jogador, int id)
    {
        if(!ModelState.IsValid) 
        {
            return View(jogador);
        }

        Jogador updateJogador = _context.Jogador.Find(jogador.Id);
        
        updateJogador.Nome = jogador.Nome;
        updateJogador.Posicao = jogador.Posicao;
        updateJogador.Numero = jogador.Numero;
        updateJogador.CopasParticipadas = jogador.CopasParticipadas;
        updateJogador.Nacionalidade = jogador.Nacionalidade;

        _context.Jogador.Update(updateJogador);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        Jogador jogador = _context.Jogador.Find(id);

        if(jogador == null)
        {
            return NotFound();
        }
        
        _context.Jogador.Remove(_context.Jogador.Find(id));
        _context.SaveChanges();

        return RedirectToAction("Index");
    }


}