using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Insurance;
using fit;

namespace InsuranceTest
{
    [TestFixture]
    public class InsuranceTests
    {
        [Test]
        public void ShouldBeZeroUnderageFemale()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(15, "female"), Is.EqualTo(0));
        }

        [Test]
        public void ShouldBeSixYoungMale()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(25, "male"), Is.EqualTo(6));
        }


        [Test]
        public void ShouldBeOneSeventyFiveOverFiftyFemale()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(60, "female"), Is.EqualTo(1.75));
        }
        [Test]
        public void ShouldBeFiveMaleOver36()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(40, "male"), Is.EqualTo(5));
        }
        [Test]
        public void ShouldBeFiveYoungFemale()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(24, "female"), Is.EqualTo(5));
        }
        [Test]
        public void ShouldBeZeroUnderageMale()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(15, "male"), Is.EqualTo(0));
        }
        [Test]
        public void ShouldBeZeroInvalidGender()
        {
            var sut = new Customer();
            Assert.That(sut.CalcPremium(25, "neither"), Is.EqualTo(0));
        }
    }
    public class IntegTest : fit.ColumnFixture
    {
        public int age;
        public string gender;
        public float CalcPremium()
        {
            var sut = new Customer();
            return sut.CalcPremium(age, gender);
        }
    }
}
