namespace RobotPrototypeSystem
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return (IndustrialRobot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Industrial Task: {IndustrialTask}");
        }
    }
}
