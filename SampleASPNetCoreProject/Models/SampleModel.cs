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
    }
}
