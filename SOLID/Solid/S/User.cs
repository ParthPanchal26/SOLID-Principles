using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.S
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        /* 
            At this point of time this class is responsible for two changes.
                1. If we need to Add/Update/Delete properties of the user
                2. If we need to change business logic of register method 
            
            This violates single responsibility rule.
            A single responsibility rule says that a class should have only one reason to change.

            Solution: 
                Therefore we moved Register method to a UserService class as we can write all business logic there.
                Now this User class is only responsible for the properties
                UserService is responsible for the handling the business logic

                Both concerns are separated now!
        */

        // public void Register()
        // {
        //     // Register user logic...

        //     // Send email
        //     var emailSender = new EmailSender();
        //     emailSender.SendEmail(Email, "Welcome to platform");
        // }
    }
}
