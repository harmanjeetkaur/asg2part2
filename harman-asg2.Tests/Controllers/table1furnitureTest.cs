using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// required references
using System.Web.Mvc;
using harman_asg2.Controllers;
using Moq;
using harman_asg2.Models;
using System.Linq;


namespace harman_asg2.Tests.Controllers
{

    [TestClass]
    public class table1furnitureTest
    {
        //globals
        Table1furnitureController controller;
        Mock<ITable1furnitureRepository> mock;
        List<table1furniture> table1furniture;

        [TestInitialize]
        public void TestInitialize()
        {
            //arrange
            mock = new Mock<ITable1furnitureRepository>();


            //mock Album data
            table1furniture = new List<table1furniture>
                        {
                new table1furniture {CustomerID = 1, Brand= "American furniture", Price= 200 },
                 new table1furniture {CustomerID= 2, Brand= "R & W", Price= 400 },
                  new table1furniture {CustomerID = 3, Brand= "Collington", Price= 300 },
                   new table1furniture {CustomerID = 4, Brand= "Fewmy", Price= 200 },
                    new table1furniture {CustomerID = 5, Brand= "Cello", Price= 350 },
                     new table1furniture {CustomerID = 6, Brand= "Aradhana", Price= 400, },



                        };
            //add data to the mock object
            mock.Setup(m => m.table1furniture).Returns(table1furniture.AsQueryable());

            //pass the mock to the controller
            controller = new Table1furnitureController(mock.Object);
        }

        [TestMethod]
        public void IndexLoadsValid()
        {


            //act
            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexShowsValidtable1furniture()
        {
            //act
            var actual = (List<table1furniture>)controller.Index().Model;



            //assert
            CollectionAssert.AreEqual(table1furniture, actual);
        }


        [TestMethod]
        public void DetailsValidtable1furniture()
        {
            //act
            var actual = (table1furniture)controller.Details(1).Model;




            //assert
            Assert.AreEqual(table1furniture.ToList()[0], actual);
        }

        [TestMethod]

        public void DetailsInvalidId()
        {
            //act
            ViewResult actual = controller.Details(7);
            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DetailsInvalidNoId()
        {
            //act
            ViewResult actual = controller.Details(null);
            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedNoId()
        {
            //act
            ViewResult actual = controller.DeleteConfirmed(null);

            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }
        [TestMethod]
        public void DeleteConfirmedInvalidId()
        {
            //act
            ViewResult actual = controller.DeleteConfirmed(7);
            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedValidId()
        {
            //act

            ViewResult actual = controller.DeleteConfirmed(1);
            //assert
            Assert.AreEqual("Index", actual.ViewName);
        }

    }
}

