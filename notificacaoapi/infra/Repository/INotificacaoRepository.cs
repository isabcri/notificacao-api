using domain;

namespace infra.Repository
{
    public interface INotificacaoRepository
    {
         int SalvarMensagem(Email email );
    }
}