using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// required references
using System.Web.Mvc;
using harman_asg2.Controllers;

namespace harman_asg2.Tests.Controllers
{
    
    [TestClass]
    public class table1furnitureTest
    {
        [TestMethod]
        public void IndexLoadsValid()
        {
            //Arrange
            table1furnitureController controller = new table1furnitureController();

            //act
            ViewResult result = controller.Index() as ViewResult;

            //assert
            Assert.IsNotNull(result); 
        }
    }
}
