using SMTP_demo_smtp4dev;

Console.WriteLine("Please enter the information to send mail");

string to;
string name;
Console.WriteLine("To : ");

to = Console.ReadLine();

Console.WriteLine("Receiver Name : ");

name = Console.ReadLine();

MailContentModel mailContentModel = new(to, name);

Console.WriteLine("Subject : ");

mailContentModel.Subject = Console.ReadLine();

Console.WriteLine("Content (As Html) : ");

mailContentModel.Content = Console.ReadLine();

var messageModel = MailService.ConfigureMessage(mailContentModel);

await MailService.SendMailAsync(messageModel);