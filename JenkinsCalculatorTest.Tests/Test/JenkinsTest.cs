using JenkinsCalculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsCalculatorTest.Tests.Test
{
    public class JenkinsTest
    {
        private CalculatorController controller;
        [SetUp]
        public void SetUp()
        {
            controller = new CalculatorController();
        }

        [Test]
        public void TestAdd()
        {
            int result;
            result = controller.Add(4, 5);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void TestSub()
        {
            int result;
            result = controller.Sub(5, 3);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void TestMultiply()
        {
            int result;
            result = controller.Multiply(5, 3);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void TestDivide()
        {
            IActionResult result = controller.Divide(4, 2);
            Assert.IsInstanceOf<ObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.AreEqual(2, okResult.Value);
        }
        [Test]
        public void TestDivideByZero()
        {
            IActionResult result = controller.Divide(10, 0);
            Assert.IsInstanceOf<BadRequestObjectResult>(result);
            var badRequestResult = result as BadRequestObjectResult;
            Assert.AreEqual("Cannot divide by 0.", badRequestResult.Value);
        }
    }
}
