using Context.Notificacao;
using domain;

namespace infra.Repository
{
    public class NotificacaoRepository : INotificacaoRepository
    {
        private readonly NotificacaoContext _notificacaoContext;

        public NotificacaoRepository(NotificacaoContext notificacaoContext)
        {
            _notificacaoContext = notificacaoContext;
        }

        public int SalvarMensagem(Email email)
        {
            _notificacaoContext.Email.Add(email);

            return _notificacaoContext.SaveChanges();
        }
    }
}