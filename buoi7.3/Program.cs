namespace buoi7._3
{
    internal class Program
    {
        enum Channel
        {
            Email,
            SMS
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Select your channel: Email, SMS.");
            var selected = int.Parse(Console.ReadLine() ?? "0"); // 0 = Email, 1= Sms
            Channel channel = Channel.Email;
            if (selected == 0)
            {
                channel = Channel.Email;
            }
            else
            { channel = Channel.SMS; }


            Console.WriteLine($"Your channel: {channel}.");
            Console.WriteLine("Please enter your message: ");
            var yourMessage = Console.ReadLine() ?? "";

            INotifier notifierEmail = new EmailNotifier();
            INotifier notifierSms = new SmsNotifier();

            if (channel == Channel.Email)
            {
                notifierEmail.Send(yourMessage);
            }
            else
            {
                notifierSms.Send(yourMessage);
            }
            Console.Write("Done sent!");


        }
    }
}
