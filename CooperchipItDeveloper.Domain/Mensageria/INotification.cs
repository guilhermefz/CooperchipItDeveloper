namespace CooperchipItDeveloper.Domain.Mensageria
{
    public interface INotification
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificacacoes();

        void Handle(Notificacao notificacao);
    }
}
