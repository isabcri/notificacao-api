using domain;
using infra.Repository;
using System;

namespace notificacaoapi.Service
{
    public class NotificacaoService : INotificacaoService
    {
        private readonly INotificacaoRepository _notificationsRepository;

        public NotificacaoService(INotificacaoRepository notificationsRepository)
        {
            _notificationsRepository = notificationsRepository;
        }

        public int SalvarMensagem(Email email)
        {
            email.DataInclusao = DateTime.Now;

            email.Mensagem = "Paciente não obteve problemas no dia " + DateTime.Now.ToString("dd/MM/yyyy");

            return _notificationsRepository.SalvarMensagem(email);
        }
    }
}