using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Agente.Application;
using System.Collections.Generic;
using Agente.Core.Interfaces;

namespace Agente.Test
{
    [TestClass]
    public class AgenteBTests
    {
        [TestMethod]
        public void GetMedia()
        {
            // Arrange
            var agentA = new AgenteB();
            var numbers = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };

            // Act
            var result = agentA.GetMedia(numbers);

            // Assert
            Assert.AreEqual(2.18978102189781, result);
        }

        [TestMethod]
        public void GetStaircase()
        {
            var agentA = new AgenteB();

            var staircase = agentA.GetStaircase(4);

            Assert.AreEqual("####\r\n ###\r\n  ##\r\n   #\r\n", staircase);
        }
    }
}
