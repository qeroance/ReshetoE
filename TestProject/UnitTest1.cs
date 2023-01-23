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
            Re.LimitNumbers(10); //������ N=10
            var actual = Re.ResultGrid();
            var expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }; //��������� ���������
            Assert.AreEqual(expected, actual); //�������� ������ ���������
        }
        [Test]
        public void Test_number_0()
        {
            Re.LimitNumbers(0); //������ N=0
            var actual = Re.ResultGrid();
            string expected = null; //��������� ���������
            Assert.AreEqual(expected, actual); //�������� ������ ���������
        }
        [Test]
        public void Test_Negative_number()
        {
            Re.LimitNumbers(-30); //������ N=-30
            var actual = Re.ResultGrid();
            string expected = null; //��������� ���������
            Assert.AreEqual(expected, actual); //�������� ������ ���������
        }
        [Test]
        public void Test_Big_Negative_number()
        {
            Re.LimitNumbers(-598); //������ N=-598
            var actual = Re.ResultGrid();
            string expected = null; //��������� ���������
            Assert.AreEqual(expected, actual); //�������� ������ ���������
        }
        [Test]
        public void Test_Big_number()
        {
            Re.LimitNumbers(5473); //������ N=5473
            var actual = Re.ResultGrid();
            string expected = null; //��������� ���������
            Assert.AreEqual(expected, actual); //�������� ������ ���������
        }
    }
}