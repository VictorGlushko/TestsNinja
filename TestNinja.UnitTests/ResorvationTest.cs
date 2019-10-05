using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ResorvationTest
    {
        [Test]
        public void CanCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
            Assert.That(result, Is.True);


        }

        [Test]
        public void CanBeCancellBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var resorvation = new Reservation { MadeBy = user };
            var result =  resorvation.CanBeCancelledBy(user);


            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancellBy_AnotherUserCancellingReservation_ReturnFalse()
        {
            var resorvation = new Reservation { MadeBy = new User() };

            var result = resorvation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }


    }
}
