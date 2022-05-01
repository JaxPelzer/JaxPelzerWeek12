using Microsoft.VisualStudio.TestTools.UnitTesting;
using Group2_CompRepair;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CompRepair.Controllers;

namespace Group2_CompRepair.Tests
{
    [TestClass()]
    public class JwtAuthenticationManagerTests
    {
        [TestMethod()]
        public void AuthenticateTestNull()
        {

            JwtAuthenticationManager manager = new JwtAuthenticationManager("fakekeynotlogin1111!");

            User user = new User
            {
                username = "testUser",
                password = "testPassword"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }

        [TestMethod()]
        public void AuthenticateTestNotNull()
        {

            JwtAuthenticationManager manager = new JwtAuthenticationManager("fakekeynotlogin1111!");

            User user = new User
            {
                username = "test",
                password = "password"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNotNull(ret);
        }
    }
}