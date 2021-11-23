using Fishingram.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fishingram.UnitTests.Domain.Entities
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class UserUnitTest
    {
        private User _user;
        private UserProfile _profile;
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsNull()
        {
            _user = new User(null, DateTime.Now, 1, _profile);

        }
    }    
}
