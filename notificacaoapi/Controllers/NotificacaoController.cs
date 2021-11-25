using domain;
using Microsoft.AspNetCore.Mvc;
using notificacaoapi.Service;

namespace notificacaoapi.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificacaoController : ControllerBase
{
    private readonly INotificacaoService _notificationsService;

    public NotificacaoController(INotificacaoService notificacaoService)
    {
        _notificationsService = notificacaoService;
    }

    [HttpPost]
    public int CadastrarMensagem(Email email)
    {
        return _notificationsService.SalvarMensagem(email);
    }
}
