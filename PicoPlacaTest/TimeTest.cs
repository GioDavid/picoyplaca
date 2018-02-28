using PicoYPlaca.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PicoPlacaTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para TimeTest y se pretende que
    ///contenga todas las pruebas unitarias TimeTest.
    ///</summary>
    [TestClass()]
    public class TimeTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Constructor Time Test
        ///</summary>
        [TestMethod()]
        public void TimeConstructorTest()
        {
            Time target = new Time("");
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///CheckTimeInIntervals in the morning
        ///</summary>
        [TestMethod()]
        public void checkTimeInIntervalsWhenTimeIsInInterval1Test()
        {
            string value = "08:00:00"; 
            Time target = new Time(value); 
            bool expected = true; 
            bool actual;
            actual = target.checkTimeInIntervals();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///CheckTimeInIntervals in the morning no interval
        ///</summary>
        [TestMethod()]
        public void checkTimeInIntervalsWhenTimeIsNotInAnyIntervalTest()
        {
            string value = "11:00:00"; 
            Time target = new Time(value); 
            bool expected = false; 
            bool actual;
            actual = target.checkTimeInIntervals();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///CheckTimeInIntervals in the afternoon
        ///</summary>
        [TestMethod()]
        public void checkTimeInIntervalsWhenTimeIsInInterval2Test()
        {
            string value = "17:00:00";
            Time target = new Time(value); 
            bool expected = true; 
            bool actual;
            actual = target.checkTimeInIntervals();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///hasCorrectFormat test correct format
        ///</summary>
        [TestMethod()]
        public void hasCorrectFormatWhenIsCorrectTest()
        {
            string value = "17:00:00";
            Time target = new Time(value); 
            bool expected = true; 
            bool actual;
            actual = target.hasCorrectFormat();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///hasCorrectFormat wrong format
        ///</summary>
        [TestMethod()]
        public void hasCorrectFormatWhenIsNotCorrectTest()
        {
            string value = "SDGSGFLKH"; 
            Time target = new Time(value); 
            bool expected = false; 
            bool actual;
            actual = target.hasCorrectFormat();
            Assert.AreEqual(expected, actual);
        }

    }
}
