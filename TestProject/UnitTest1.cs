using NUnit.Framework;
using ReshetoE;
using System.Collections.Generic;


namespace TestProject
{
    public class Tests
    {
        TheSieveOfEratosthenes Re;

        [SetUp]
        public void Setup()
        {
            Re = new TheSieveOfEratosthenes();
        }

        [Test]
        public void Test_number_10()
        {
            Re.LimitNumbers(10); //Задаем N=10
            var actual = Re.ResultGrid();
            var expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; //Ожидаемый результат
            Assert.AreEqual(expected, actual); //Проверка работы алгоритма
        }
        [Test]
        public void Test_number_0()
        {
            Re.LimitNumbers(0); //Задаем N=0
            var actual = Re.ResultGrid();
            string expected = null; //Ожидаемый результат
            Assert.AreEqual(expected, actual); //Проверка работы алгоритма
        }
        [Test]
        public void Test_Negative_number()
        {
            Re.LimitNumbers(-30); //Задаем N=-30
            var actual = Re.ResultGrid();
            string expected = null; //Ожидаемый результат
            Assert.AreEqual(expected, actual); //Проверка работы алгоритма
        }
        [Test]
        public void Test_Big_Negative_number()
        {
            Re.LimitNumbers(-598); //Задаем N=-598
            var actual = Re.ResultGrid();
            string expected = null; //Ожидаемый результат
            Assert.AreEqual(expected, actual); //Проверка работы алгоритма
        }
        [Test]
        public void Test_Big_number()
        {
            Re.LimitNumbers(5473); //Задаем N=5473
            var actual = Re.ResultGrid();
            string expected = null; //Ожидаемый результат
            Assert.AreEqual(expected, actual); //Проверка работы алгоритма
        }
    }
}