using GameApplication.DTOs;
using GameApplication.Models;

namespace GameApplication.Interfaces;

public interface IGameService
{
    Game CadastrarJogo(GameCreateDto dto);
    Game? BuscarJogo(Guid id);
    IEnumerable<Game> ListarJogos();
    Game? EditarJogo(GameUpdateDto dto);
    bool RemoverJogo(Guid id);
}