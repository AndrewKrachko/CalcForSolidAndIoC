using System.Collections.Generic;
using System.Data;
using System.Linq;
using Calculator;
using Calculator.Interfaces;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ParserSimpleStringTest()
        {
            // Arrange
            var dataSourceMock = new Mock<IDataSource>();
            dataSourceMock.Setup(s => s.GetData()).Returns("$a=1.2+3");
            var equationSet = new List<IEquationSet>();
            var sut = new Parser();

            // Act
            var result = ((EquationSet)sut.Parse(dataSourceMock.Object)[0]).GetEquation();

            // Assert
            Assert.AreEqual(5, result.Count());
        }
    }
}