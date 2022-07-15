using MailKit.Net.Smtp;
using MimeKit;

namespace SMTP_demo_smtp4dev
{
    public static class MailService
    {
        public static MimeMessage ConfigureMessage(MailContentModel mailContentModel)
        {
            var emailMessage = new MimeMessage();
            emailMessage.To.Add(new MailboxAddress(mailContentModel.Name, mailContentModel.To));
            emailMessage.Subject = mailContentModel.Subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = mailContentModel.Content;
            emailMessage.Body = bodyBuilder.ToMessageBody();

            return emailMessage;
        }
        public static async Task SendMailAsync(MimeMessage emailContent)
        {
            using var client = new SmtpClient();

            MailModel mail = new("localhost", 2525);

            emailContent.From.Add(new MailboxAddress(mail.Name, mail.From));

            client.Connect(mail.Host, mail.Port, mail.Option);

            await client.SendAsync(emailContent);

            client.Disconnect(true);
        }
    }
}
