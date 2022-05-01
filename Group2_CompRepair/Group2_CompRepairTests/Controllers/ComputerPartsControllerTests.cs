using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2_CompRepair.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CompRepair.Controllers;
using Group2_CompRepair.Data;
using Group2_CompRepair.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group2_CompRepair.Controllers.Tests
{
    [TestClass()]
    public class ComputerPartsControllerTests
    {
        private readonly Group2_ComprepairContext _context;
        [TestMethod()]
        public void GetComputerPartTest()
        {
            int id = 20;
            var controller = new ComputerPartsController(_context);

            
            Assert.IsInstanceOfType(controller.GetComputerPart(id), typeof(Task<ActionResult<ComputerPart>>));
            
        }

        [TestMethod()]
        public void GetComputerPartsTest()
        {
            
            var controller = new ComputerPartsController(_context);
            


            Assert.IsNotNull(controller.GetComputerParts());
        }

        [TestMethod()]
        public void GetComputerPartsTypeTest()
        {

            var controller = new ComputerPartsController(_context);



            Assert.IsInstanceOfType(controller.GetComputerParts(), typeof(Task<ActionResult<IEnumerable<ComputerPart>>>));
        }


    }
} 