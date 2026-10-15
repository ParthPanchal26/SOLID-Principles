namespace Solid.S
{
    class UserService
    {

        // Below method is now separed from the User class.

        public void Register(User user)
        {
            // Register user logic...

            // Send email
            var emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, $"Welcome to platform {user.Username}");
        }
    }
}