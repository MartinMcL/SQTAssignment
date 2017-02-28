using Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;

namespace FitnesseTests
{
    public class FitnesseTests : fit.ColumnFixture
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
