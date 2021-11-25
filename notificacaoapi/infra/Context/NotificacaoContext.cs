
using domain;
using Microsoft.EntityFrameworkCore;

namespace Context.Notificacao
{
    public class NotificacaoContext : DbContext
    {
        public NotificacaoContext(DbContextOptions<NotificacaoContext> option) : base(option)
        {

        }

        public DbSet<Email> Email { get; set; }

    }
}