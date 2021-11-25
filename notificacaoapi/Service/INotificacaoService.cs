using domain;

namespace notificacaoapi.Service
{
    public interface INotificacaoService
    {
        int SalvarMensagem(Email email);
    }
}