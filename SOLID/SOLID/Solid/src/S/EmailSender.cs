namespace Solid.S
{
    class EmailSender
    {

        // This class contains method which helps to send an email

        public void SendEmail(string Email, string Message)
        {
            System.Console.WriteLine($"Sending email to {Email}: {Message}");
        }
    }
}