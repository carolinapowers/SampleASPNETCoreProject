using System;
using System.Linq;
using SampleASPNetCoreProject.Models;
using Xunit;

namespace SampleXunitTestsProject
{
    public class SampleModelTest
    {

        [Fact(DisplayName="Create Total @create-property")]
        public void CheckPropertyExistsTest()
        {
            var sampleModelClass = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                   from type in assembly.GetTypes()
                                   where type.FullName == "SampleASPNetCoreProject.Models.SampleModel"
                                   select type).FirstOrDefault();
            Assert.True(sampleModelClass != null, "GradeBook.GradeBooks.RankedGradeBook doesn't exist.");

            Assert.True(sampleModelClass.GetProperty("Total") != null, "Property `Total` does not exists.");
        }

        [Fact(DisplayName="Iterate Total @iterate-total")]
        public void IterateTotalTest()
        {
            //setup
            var sampleModel = new SampleModel { Total = 1 };
            var expected = 2;
            sampleModel.IterateTotal();

            Assert.True(expected == sampleModel.Total, "`IterateTotal` did not iterate total.");
        }

        [Fact(DisplayName = "Add To Total @add-to-total")]
        public void AddToTotalTest()
        {
            var sampleModel = new SampleModel { Total = 1 };
            var expected = 3;
            sampleModel.AddToTotal(2);

            Assert.True(expected == sampleModel.Total, "`AddToTotal` did not propertly add to the total.");
        }

        [Fact(DisplayName = "Return Total @return-total")]
        public void ReturnTotalTest()
        {
            var sampleModel = new SampleModel { Total = 4 };
            var expected = 4;

            Assert.True(expected == sampleModel.ReturnTotal(), "`Return Total` did not return the value of the Total property.");
        }
    }
}
