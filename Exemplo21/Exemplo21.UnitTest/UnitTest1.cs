using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exemplo21.UnitTest
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelled_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            var result = reservation.CanBeCancelledBy(new User { isAdmin = true });
            //Assert
            Assert.IsTrue(result);
        }
    }
}
