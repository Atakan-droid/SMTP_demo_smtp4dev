using MailKit.Security;

namespace SMTP_demo_smtp4dev
{
    public class MailModel
    {
        public string From { get; set; } = "test@test.com";
        public string Name { get; set; } = "Test Account";
        public string Host { get; private set; }
        public int Port { get; private set; }
        public SecureSocketOptions Option { get; set; } = SecureSocketOptions.None;

        public MailModel(string host, int port)
        {
            Host = "localhost";
            Port = 2525;
        }
    }
}
