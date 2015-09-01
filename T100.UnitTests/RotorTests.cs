using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T100.Model;

namespace T100.UnitTests
{
    [TestClass]
    public class RotorTests
    {
        private Rotor CreateSut(int initialPosition)
        {
            return new Rotor(new IdentityRotorAlg(), initialPosition);
        }

        [TestMethod]
        public void Single_rotor_increase_position_wen_step()
        {
            const int initialPosition = 0;
            var sut = CreateSut(initialPosition);
            
            sut.Step();

            Assert.AreNotEqual(initialPosition, sut.Position);
        }

        [TestMethod]
        public void Single_rotor_can_turn_around()
        {
            const int initialPosition = 0;
            var sut = CreateSut(initialPosition);

            for (int i = 0; i < Helper.RotorPositions; i++)
            {
                sut.Step();
            }

            Assert.AreEqual(initialPosition, sut.Position);
        }
    }
}
