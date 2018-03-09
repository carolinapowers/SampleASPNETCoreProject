using System;

namespace SampleASPNetCoreProject.Models
{
    public class SampleModel
    {
        public string Name { get; set; }
        public int Total { get; set; }

        public SampleModel()
        {
            Total = 0;
        }

        public void IterateTotal()
        {
            Total++;
        }

        public void AddToTotal(int parameter1)
        {
            Total += parameter1;
        }

        public int ReturnTotal()
        {
            return Total;
        }

        public void BreakStuff()
        {
            //comment out this line of code to prevent the exception and cause the test to pass.
            throw (new Exception("THIS EXCEPTION IS BEING THROWN ON PURPOSE! To fix this test goto the `SampleXUnitTestsProject`'s `SampleModelTest` class and comment out the `throw` in the `ExceptionTest` method."));

            return;
        }
    }
}
