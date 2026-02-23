using GameApplication.DTOs;
using GameApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GameApplication.Models;

namespace GameApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("cadastrar")]
        public IActionResult CadastrarJogo([FromBody] GameCreateDto dto)
        {
            var game = _gameService.CadastrarJogo(dto);
            return CreatedAtAction(nameof(BuscarJogo), new { id = game.Id }, game);
        }

        [HttpGet("buscar/{id}")]
        public IActionResult BuscarJogo(Guid id)
        {
            var game = _gameService.BuscarJogo(id);
            if (game == null) return NotFound("Jogo não encontrado.");
            
            return Ok(game);
        }

        [HttpGet("listar")]
        public IActionResult ListarJogos()
        {
            var games = _gameService.ListarJogos();
            return Ok(games);
        }

        [HttpPut("editar")]
        public IActionResult EditarJogo([FromBody] GameUpdateDto dto)
        {
            var gameAtualizado = _gameService.EditarJogo(dto);
            if (gameAtualizado == null) return NotFound("Jogo não encontrado para edição.");

            return Ok(gameAtualizado);
        }

        [HttpDelete("remover/{id}")]
        public IActionResult RemoverJogo(Guid id)
        {
            var sucesso = _gameService.RemoverJogo(id);
            if (!sucesso) return NotFound("Jogo não encontrado para remoção.");

            return NoContent();
        }
    }
}