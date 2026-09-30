namespace RobotPrototypeSystem
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            return (ServiceRobot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Service Task: {ServiceTask}");
        }
    }
}
