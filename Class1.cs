using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace CalculatorTest
{
    public class Class1
    {
        [Test]
        public void GetAddition_Input6point2and4point8_Returns11point0()
        {
            //Arrange
            double number1 = 6.2;
            double number2 = 4.8;

            double expectedResult = number1 + number2;

        Calc testCalc = new Calc(number1, number2);

        //Act
        double actualResult = testCalc.GetAddition();

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
        }

        [Test ]
    public void GetAddition_Input5point2and8point8_Returns14point0()
    {
        //Arrange
        double number1 = 5.2;
        double number2 = 8.8;

        double expectedResult = number1 + number2;

        Calc testCalc = new Calc(number1, number2);

        //Act
        double actualResult = testCalc.GetAddition();

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
        [Test ]
    public void GetAddition_Input2point2and6point1_Returns8point3()
    {
        //Arrange
        double number1 = 2.2;
        double number2 = 6.1;

        double expectedResult = number1 + number2;

        Calc testCalc = new Calc(number1, number2);

        //Act
        double actualResult = testCalc.GetAddition();

        //Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
        [Test ]
    public void GetSubtraction_Input6point0and4point0_Returns2point0()
        {
            //Arrange
            double number1 = 6.0;
            double number2 = 4.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test ]
        public void GetSubtraction_Input11point0and6point0_Returns5point0()
        {
            //Arrange
            double number1 = 11.0;
            double number2 = 6.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test ]
        public void GetSubtraction_Input14point0and8point0_Returns6point0()
        {
            //Arrange
            double number1 = 14.0;
            double number2 = 8.0;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test ]
        public void GetMultiplication_Input14point0and8point0_Returns112point0()
        {
            //Arrange
            double number1 = 14.0;
            double number2 = 8.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test ]
        public void GetMultiplication_Input4pointand0and12point0_Returns48point0()
        {
            //Arrange
            double number1 = 4.0;
            double number2 = 12.0;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point0and9point0_Returns18point0()
        {
            //Arrange
            double number1 = 2.0;
            double number2 = 9.1;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void GetDivision_Input9poin0and3point8_Returns3point0()
        {
            //Arrange
            double number1 = 9.0;
            double number2 = 3.0;

            double expectedResult = number1 /number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

