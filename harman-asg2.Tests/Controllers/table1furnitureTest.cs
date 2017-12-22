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

        [TestInitialize]
        public void TestInitialize()
        {
            //arrange
            mock = new Mock<ITable1furnitureRepository>();

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
    }
}
