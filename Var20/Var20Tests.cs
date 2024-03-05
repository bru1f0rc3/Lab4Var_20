using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab4Var_20;

namespace Var20
{
    [TestClass]
    public class Var20Tests
    {
        [TestMethod]
        public void Task1_Enter_2_Minus4_7_Minus5_Minus6_ReturnMinus120_Minus4()
        {
            double[] a = { 2, -4, 7, -5, -6 };
            string expected = "-120 : -4";
            string actual = Variant20.Task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_Minus2_Minus4_Minus8_5_Minus6_ReturnMinus120_Minus4()
        {
            double[] a = { -2, -4, -8, 5, -6 };
            string expected = "384 : -2";
            string actual = Variant20.Task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_2_5_7_Minus9_ReturnMinus9_Minus9()
        {
            double[] a = { 2, 5, 7, -9 };
            string expected = "-9 : -9";
            string actual = Variant20.Task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_Minus11_Minus5_7_ReturnMinus55_Minus11()
        {
            double[] a = { -11, -5, 7 };
            string expected = "55 : -11";
            string actual = Variant20.Task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task1_Enter_2_Minus3_7_Minus8_Minus9_ReturnMinus216_Minus3()
        {
            double[] a = { 2, -3, 7, -8, -9 };
            string expected = "-216 : -3";
            string actual = Variant20.Task1(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_Enter_2_5_7_11_Return5_11_15_23()
        {
            double[] a = { 2, 5, 7, 11 };
            double[] expected = { 5, 11, 15, 23 };
            double[] actual = Variant20.Task2(a);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_Enter_10_11_22_Minus5_Return_21_23_45_Minus9()
        {
            double[] a = { 10, 11, 22, -5 };
            double[] expected = { 21, 23, 45, -9 };
            double[] actual = Variant20.Task2(a);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_Enter_Minus5_11_22_Minus4_Return_Minus9_23_45_Minus7()
        {
            double[] a = { -5, 11, 22, -4 };
            double[] expected = { -9, 23, 45, -7 };
            double[] actual = Variant20.Task2(a);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_Enter_2_Minus5_7_Minus11_Return_5_Minus9_15_Minus21()
        {
            double[] a = { 2, -5, 7, -11 };
            double[] expected = { 5, -9, 15, -21 };
            double[] actual = Variant20.Task2(a);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task2_Enter_40_48_120_Minus11_Return_81_97_241()
        {
            double[] a = { 40, 48, 120 };
            double[] expected = { 81, 97, 241 };
            double[] actual = Variant20.Task2(a);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void Task3_Enter_2_Minus3_4_Minus5_6_7_Return_15()
        {
            double[] a = { 2, -3, 4, -5, 6, 7 };
            double expected = 15;
            double actual = Variant20.Task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_Enter_2_Minus3_4_Minus5_6_7_Return_931()
        {
            double[] a = { 2, -3, 4, -5, 6, 7 };
            double expected = 15;
            double actual = Variant20.Task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void Task3_Enter_11_15_57_65_107_Return_931()
        {
            double[] a = { 11, 15, 57, 65, 107 };
            double expected = 4061;
            double actual = Variant20.Task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_Enter_5_101_205_599_1004_Return_243397()
        {
            double[] a = { 5, 101, 205, 599, 1004 };
            double expected = 243397;
            double actual = Variant20.Task3(a);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Task3_Enter_59_1_24_101_505_Return_609()
        {
            double[] a = { 59, 1, 24, 101, 505 };
            double expected = 609;
            double actual = Variant20.Task3(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
