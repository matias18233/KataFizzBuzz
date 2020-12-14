using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void controlarFizz() {
            String[] listado = Kata.Program.obtenerListado();
            Assert.AreEqual(listado[5], "Fizz");
        }
        [TestMethod]
        public void controlarBuzz() {
            String[] listado = Kata.Program.obtenerListado();
            Assert.AreEqual(listado[9], "Buzz");
        }
        [TestMethod]
        public void controlarFizzBuzz() {
            String[] listado = Kata.Program.obtenerListado();
            Assert.AreEqual(listado[14], "FizzBuzz");
        }
        [TestMethod]
        public void controlarPosicion16() {
            String[] listado = Kata.Program.obtenerListado();
            Assert.AreEqual(listado[16], "17");
        }
        [TestMethod]
        public void controlarPosicion18() {
            String[] listado = Kata.Program.obtenerListado();
            Assert.AreEqual(listado[18], "19");
        }
    }
}