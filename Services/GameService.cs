using GameApplication.DTOs;
using GameApplication.Interfaces;
using GameApplication.Models;

namespace GameApplication.Services
{
    public class GameService : IGameService
    {
        // Lista em memória para simular um banco de dados
        private readonly List<Game> _games = new();

        public Game CadastrarJogo(GameCreateDto dto)
        {
            var game = new Game
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Image = dto.Image,
                Description = dto.Description
            };
            
            _games.Add(game);
            return game;
        }

        public Game? BuscarJogo(Guid id)
        {
            return _games.FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Game> ListarJogos()
        {
            return _games;
        }

        public Game? EditarJogo(GameUpdateDto dto)
        {
            var game = _games.FirstOrDefault(g => g.Id == dto.Id);
            if (game == null) return null;

            game.Name = dto.Name;
            game.Image = dto.Image;
            game.Description = dto.Description;

            return game;
        }

        public bool RemoverJogo(Guid id)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);
            if (game == null) return false;

            _games.Remove(game);
            return true;
        }
    }
}