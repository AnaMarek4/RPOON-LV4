using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class RegistrationValidator : IRegistrationValidator
    {
        public EmailValidator mailValidator;
        public PasswordValidator passwordValidator;

        public RegistrationValidator()
        {
            mailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator(10);
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return mailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password);
        }
    }
}
