using PicoYPlaca.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PicoPlacaTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para DateTest y se pretende que
    ///contenga todas las pruebas unitarias DateTest.
    ///</summary>
    [TestClass()]
    public class DateTest
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
        ///Constructor Date test
        ///</summary>
        [TestMethod()]
        public void DateConstructorTest()
        {
            Date target = new Date(DateTime.Today);
            Assert.IsNotNull(target);
        }

        /// <summary>
        /// getDayOfTheWeekFromDate test
        ///</summary>
        [TestMethod()]
        public void getDayOfTheWeekFromDateTest()
        {
            DateTime date = new DateTime(2018, 3, 2, 7, 0, 0); 
            Date target = new Date(date);
            int expected = 5;
            int actual;
            actual = target.getDayOfTheWeekFromDate();
            Assert.AreEqual(expected, actual);
        }
    }
}
