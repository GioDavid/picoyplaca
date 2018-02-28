using PicoYPlaca.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PicoPlacaTest
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para VehicleTest y se pretende que
    ///contenga todas las pruebas unitarias VehicleTest.
    ///</summary>
    [TestClass()]
    public class VehicleTest
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
        ///Una prueba de Constructor Vehicle
        ///</summary>
        [TestMethod()]
        public void VehicleConstructorTest()
        {
            Vehicle target = new Vehicle("PDA5700");
            Assert.IsNotNull(target);
        }

        /// <summary>
        /// Plate test
        ///</summary>
        [TestMethod()]
        public void PlateTest()
        {
            Vehicle target = new Vehicle(""); 
            string expected = string.Empty; 
            string actual;
            target.Plate = expected;
            actual = target.Plate;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Verify the plate when is correct
        ///</summary>
        [TestMethod()]
        public void verifyPlateTestWithRightFormat()
        {
            string plate = "PDA2500" ; 
            Vehicle target = new Vehicle(plate); 
            bool expected = true; 
            bool actual;
            actual = target.verifyPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///verifyPlate when is wrong
        ///</summary>
        [TestMethod()]
        public void verifyPlateTestWithWrongFormat()
        {
            string plate = "4DA250Q"; 
            Vehicle target = new Vehicle(plate); 
            bool expected = false; 
            bool actual;
            actual = target.verifyPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisMondayTest()
        {
            string plate = "PDA4521"; 
            Vehicle target = new Vehicle(plate); 
            int expected = 1; 
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisMonday2Test()
        {
            string plate = "PDA4522";  
            Vehicle target = new Vehicle(plate);  
            int expected = 1;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisTuesdayTest()
        {
            string plate = "PDA4523";  
            Vehicle target = new Vehicle(plate);  
            int expected = 2;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisTuesday2Test()
        {
            string plate = "PDA4524";  
            Vehicle target = new Vehicle(plate);  
            int expected = 2;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisWednesday1Test()
        {
            string plate = "PDA4525";  
            Vehicle target = new Vehicle(plate);  
            int expected = 3;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisWednesday2Test()
        {
            string plate = "PDA4526";  
            Vehicle target = new Vehicle(plate);  
            int expected = 3;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisThursday1Test()
        {
            string plate = "PDA4527";  
            Vehicle target = new Vehicle(plate);  
            int expected = 4;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisThursday2Test()
        {
            string plate = "PDA4528";  
            Vehicle target = new Vehicle(plate);  
            int expected = 4;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisFriday1Test()
        {
            string plate = "PDA4529";  
            Vehicle target = new Vehicle(plate);  
            int expected = 5;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenDayisFriday2Test()
        {
            string plate = "PDA4520";  
            Vehicle target = new Vehicle(plate);  
            int expected = 5;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPicoPlacaDayOfPlate test
        ///</summary>
        [TestMethod()]
        public void getPicoPlacaDayOfPlateWhenPlateisIncorrectTest()
        {
            string plate = "PDA4520P";  
            Vehicle target = new Vehicle(plate);  
            int expected = 0;  
            int actual;
            actual = target.getPicoPlacaDayOfPlate();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///getPlate test
        ///</summary>
        [TestMethod()]
        public void getPlateTest()
        {
            string plate = string.Empty;  
            Vehicle target = new Vehicle(plate);  
            string expected = string.Empty;  
            string actual;
            actual = target.getPlate();
            Assert.AreEqual(expected, actual);
        }
    }
}
