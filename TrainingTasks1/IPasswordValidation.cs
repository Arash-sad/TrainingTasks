using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks1
{
    public interface IPasswordValidation
    {
        PasswordValidationResult Validate(string password);
    }

    public class PasswordValidation : IPasswordValidation
    {
        public PasswordValidationResult Validate(string password)
        {
            var res = new PasswordValidationResult();
            res.IsValid = false;
            res.Message = "Password lenght must be min of 10";
            return res;
        }
    }
}
