using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TrainingTasks1
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        // 1. Should implement 3 rules (must have a number, must have an uppercase letter, must be min of 10 in length). More may be needed later.
        // 2. A Blank password is not valid (First test stub below)
        // 3. If a password is invalid the reason it is invalid should be in the ValidationResult 
        //
        // Notes: Tests should cover all functionality
        //        C# conventions should be followed

        [Test]
        public void A_Blank_Password_Is_Not_Valid()
        {
            IPasswordValidation validation = new PasswordValidation();
            var result = validation.Validate("");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password cannot be blank");


            Console.WriteLine(result.IsValid);
            Console.WriteLine(result.Message);
        }

        [Test]
        public void Password_min_lenght()
        {
            IPasswordValidation validation = new PasswordValidation();
            var result = validation.Validate("123456789");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password lenght must be min of 10");


            Console.WriteLine(result.IsValid);
            Console.WriteLine(result.Message);
        }

        [Test]
        public void Password_with_Uppercase()
        {
            IPasswordValidation validation = new PasswordValidation();
            var result = validation.Validate("asdfg12");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password must have an uppercase letter");


            Console.WriteLine(result.IsValid);
            Console.WriteLine(result.Message);
        }

        [Test]
        public void Password_have_A_Number()
        {
            IPasswordValidation validation = new PasswordValidation();
            var result = validation.Validate("asdfg");

            Assert.False(result.IsValid);
            Assert.AreEqual(result.Message, "Password must have a Number");


            Console.WriteLine(result.IsValid);
            Console.WriteLine(result.Message);
        }

    }

    public static class Prog
    {
        public static void Main(string[] args)
        {
            var test = new PasswordValidatorTests();
            test.Password_min_lenght();

            Console.Read();
        }
    }
}
