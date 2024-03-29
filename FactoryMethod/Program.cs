using FactoryMethod.Pix;

namespace FactoryMethod;

public class Program
{
    static void Main(string[] args)
    {
        #region Exemplo com Pix
        string qrCode = string.Empty;
        TransacaoPix transacao = default;

        transacao = new CriadorPixDinamico();
        qrCode = transacao.CriarQrCode(14);

        transacao = new CriadorPixEstatico();
        qrCode = transacao.CriarQrCode(14);
        #endregion

        #region Exemplo com Mensagem

        NotificacaoFactory notificacaoFactory = new NotificacaoSMSFactory();

        Notificacao notificacao_1 = notificacaoFactory.CriarNotificacao();
        notificacao_1.Notificar();

        Notificacao notificacao_2 = notificacaoFactory.CriarNotificacao();
        notificacao_2.Notificar();

        Notificacao notificacao_3 = notificacaoFactory.CriarNotificacao();
        notificacao_3.Notificar();

        notificacaoFactory = new NotificacaoEmailFactory();

        Notificacao notificacao_4 = notificacaoFactory.CriarNotificacao();
        notificacao_4.Notificar();

        Notificacao notificacao_5 = notificacaoFactory.CriarNotificacao();
        notificacao_5.Notificar();
        #endregion
    }

    public abstract class NotificacaoFactory : Notificacao
    {
        public abstract Notificacao CriarNotificacao();
        public void Notificar()
        {
            throw new NotImplementedException();
        }
    }

    public class NotificacaoSMSFactory : NotificacaoFactory
    {
        public override Notificacao CriarNotificacao()
            => new NotificacaoSMS();
    }

    public class NotificacaoEmailFactory : NotificacaoFactory
    {
        public override Notificacao CriarNotificacao()
            => new NotificacaoEmail();
    }

    public interface Notificacao
    {
        void Notificar();
    }

    public class NotificacaoSMS : Notificacao
    {
        private readonly Guid _guid = Guid.NewGuid();
        public void Notificar()
        {
            Console.WriteLine($"SMS enviado com sucesso {_guid}!");
        }
    }

    public class NotificacaoEmail : Notificacao
    {
        private readonly Guid _guid = Guid.NewGuid();

        public void Notificar()
        {
            Console.WriteLine($"E-mail enviado com sucesso {_guid}!");
        }
    }
}
