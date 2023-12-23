using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Agente.Application;
using System.Collections.Generic;
using Agente.Core.Interfaces;

namespace Agente.Test
{
    [TestClass]
    public class AgenteCTests
    {
        [TestMethod]
        public void GetMedia()
        {
            // Arrange
            var agentA = new AgenteC();
            var numbers = new List<double> { 1, 2, 3, 4, 5 };

            // Act
            var result = agentA.GetMedia(numbers);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetStaircase()
        {
            var agentA = new AgenteC();

            var staircase = agentA.GetStaircase(4);

            Assert. AreEqual("   ####   \r\n  ######  \r\n ######## \r\n##########\r\n ######## \r\n  ######  \r\n   ####   \r\n", staircase);
        }
    }
}
