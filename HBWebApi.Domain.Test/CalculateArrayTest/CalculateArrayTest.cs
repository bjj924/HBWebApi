using HBWebApi.Domain.ArrayLogic;
using HBWebApi.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HBWebApi.Domain.Test.CalculateArrayTest
{
    public class CalculateArrayTest 
    {
        [Fact]
        public void ResultOkEvenNumbers()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "1234567",
                SecondNumber = "1234567"
            };

            var expectingResult = "8888888";
            var expectedStatusCode = 200;

            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.Result, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void ResultOkFirstGreaterThanSecond()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "1234567899945",
                SecondNumber = "1234567"
            };

            var expectingResult = "1234575554266";
            var expectedStatusCode = 200;

            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.Result, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void ResultOkSecondGreaterThanFirst()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "12345678",
                SecondNumber = "1234567899945"
            };

            var expectingResult = "5499999999999";
            var expectedStatusCode = 200;

            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.Result, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void ResultErrorCharacterInFirstNumber()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "12345678A",
                SecondNumber = "12345678"
            };

            var expectingResult = "The first number contains a non decimal value";
            var expectedStatusCode = 400;
            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.ErrorMessage, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void ResultErrorCharacterInSecondNumber()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "12345678",
                SecondNumber = "12345678B"
            };

            var expectingResult = "The second number contains a non decimal value";
            var expectedStatusCode = 400;
            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.ErrorMessage, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void FirstNumberEmpty()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "",
                SecondNumber = "12345678"
            };

            var expectingResult = "87654321";
            var expectedStatusCode = 200;

            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.Result, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void SecondNumberEmpty()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "12345678",
                SecondNumber = ""
            };

            var expectingResult = "12345678";
            var expectedStatusCode = 200;

            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.Result, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void FirstNumberEmptyAndSecondWithCharacter()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "",
                SecondNumber = "12345678B"
            };

            var expectingResult = "The second number contains a non decimal value";
            var expectedStatusCode = 400;
            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.ErrorMessage, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }

        [Fact]
        public void SecondNumberEmptyAndFirstWithCharacter()
        {
            //Arrange
            var arrayLogic = new CalculateArray();
            var request = new CharArray()
            {
                FirstNumber = "12345678B",
                SecondNumber = ""
            };

            var expectingResult = "The first number contains a non decimal value";
            var expectedStatusCode = 400;
            //Act
            var act = arrayLogic.Calculate(request);

            //Assert
            Assert.Equal(act.Result.ErrorMessage, expectingResult);
            Assert.Equal(act.Result.StatusCode, expectedStatusCode);
        }
    }
}
