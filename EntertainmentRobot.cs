namespace RobotPrototypeSystem
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            double batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return (EntertainmentRobot)this.MemberwiseClone();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Entertainment Feature: {EntertainmentFeature}");
        }
    }
}
