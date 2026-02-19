using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void FirstDeclensionsOnRuble()
        {
            int enteredValue = 1500;
            string result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("15 рублей ", result);

            enteredValue = 3500;
            result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("35 рублей ", result);

            enteredValue = 4000;
            result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("40 рублей ", result);
        }
        [TestMethod()]
        public void SecondDeclensionsOnRuble()
        {
            int enteredValue = 100;
            string result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("1 рубль ", result);

            enteredValue = 5100;
            result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("51 рубль ", result);
        }
        [TestMethod()]
        public void ThirdDeclensionsOnRuble()
        {
            int enteredValue = 2215;
            string result = Logic.rublesTransformation(enteredValue);
            Assert.AreEqual("22 рубля ", result);
        }
        [TestMethod()]
        public void FirstDeclensionsOnPenny()
        {
            int enteredValue = 100;
            string result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("ровно", result);
        }
        [TestMethod()]
        public void SecondDeclensionsOnPenny()
        {
            int enteredValue = 1115;
            string result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("15 копеек", result);

            enteredValue = 7;
            result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("7 копеек", result);

            enteredValue = 2020;
            result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("20 копеек", result);
        }
        [TestMethod()]
        public void ThirdDeclensionsOnPenny()
        {
            int enteredValue = 1;
            string result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("1 копейка", result);

            enteredValue = 31;
            result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("31 копейка", result);
        }
        [TestMethod()]
        public void FourthDeclensionsOnPenny()
        {
            int enteredValue = 4;
            string result = Logic.pennyTransformation(enteredValue);
            Assert.AreEqual("4 копейки", result);
        }

    }

}