using Fishingram.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.UnitTests.Domain.Entities
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class UserUnitTest
    {
        private User _user;
        private Profile _profile;
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsNull()
        {
            _profile = new Profile();
            _user = new User(null, DateTime.Now, 1, _profile);

            Assert.IsTrue(_user.va)
        }
    }    
}
