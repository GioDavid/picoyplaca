using PicoYPlaca.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PicoPlacaTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ValidationTest y se pretende que
    ///contenga todas las pruebas unitarias ValidationTest.
    ///</summary>
    [TestClass()]
    public class ValidationTest
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
        ///Constructor Validation Test
        ///</summary>
        [TestMethod()]
        public void ValidationConstructorTest()
        {
            Date date = null; 
            Vehicle vehicle = null; 
            Time time = null; 
            Validation target = new Validation(date, vehicle, time);
            Assert.IsNotNull(target);
        }

        /// <summary>
        //canBeOnRoad test with a wrong hour
        ///</summary>
        [TestMethod()]
        public void canBeOnRoadWhenIsOnDayAndInWronHourTest()
        {
            DateTime datetime = new DateTime(2018, 3, 2, 7, 0, 0);
            Date date = new Date(datetime); 
            Vehicle vehicle = new Vehicle("PDA5500"); 
            Time time = new Time("09:00:00"); 
            Validation target = new Validation(date, vehicle, time); 
            bool expected = false; 
            target.canBeOnRoad();
            bool actual = target.isValid;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///canBeOnRoad test in another day
        ///</summary>
        [TestMethod()]
        public void canBeOnRoadTestWhenIsNotTheDay()
        {
            DateTime datetime = new DateTime(2018, 2, 28, 7, 0, 0);
            Date date = new Date(datetime); 
            Vehicle vehicle = new Vehicle("PDA5500"); 
            Time time = new Time("09:00:00"); 
            Validation target = new Validation(date, vehicle, time); 
            bool expected = true; 
            target.canBeOnRoad();
            bool actual = target.isValid;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///canBeOnRoad test in non pico placa time
        ///</summary>
        [TestMethod()]
        public void canBeOnRoadTestWhenIsNotPicoPlacaTime()
        {
            DateTime datetime = new DateTime(2018, 3, 2, 7, 0, 0);
            Date date = new Date(datetime); 
            Vehicle vehicle = new Vehicle("PDA5500"); 
            Time time = new Time("10:00:00"); 
            Validation target = new Validation(date, vehicle, time); 
            bool expected = true; 
            target.canBeOnRoad();
            bool actual = target.isValid;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///canBeOnRoad test when plate is bad
        ///</summary>
        [TestMethod()]
        public void canBeOnRoadTestWhenPlateIsWrong()
        {
            DateTime datetime = new DateTime(2018, 3, 2, 7, 0, 0);
            Date date = new Date(datetime); 
            Vehicle vehicle = new Vehicle("2r43f"); 
            Time time = new Time("10:00:00"); 
            Validation target = new Validation(date, vehicle, time); 
            bool expected = false; 
            target.canBeOnRoad();
            bool actual = target.isValid;
            Assert.AreEqual(expected, actual);
        }
    }
}
