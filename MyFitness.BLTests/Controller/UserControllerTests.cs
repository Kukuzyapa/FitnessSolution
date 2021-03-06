using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrage
            var userName = Guid.NewGuid().ToString();
            var height = 180;
            var weight = 80;
            var birthDate = DateTime.Now.AddYears(-18);
            var gender = "man";
            var controller = new UserController(userName);

            // Act
            controller.SetNewUserData(gender, birthDate, weight, height);
            var controller2 = new UserController(userName);

            // Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(birthDate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrage
            var userName = Guid.NewGuid().ToString();

            // Act
            var controller = new UserController(userName);

            // Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}