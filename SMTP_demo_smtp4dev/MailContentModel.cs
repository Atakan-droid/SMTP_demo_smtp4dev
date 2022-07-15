namespace SMTP_demo_smtp4dev
{
    public class MailContentModel
    {
        public string To { get; private set; }
        public string Name { get; private set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public MailContentModel(string to, string toname)
        {
            To = to;
            Name = toname;
        }
    }
}
