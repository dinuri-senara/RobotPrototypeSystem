using System;

namespace RobotPrototypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                12,
                "v1.0",
                "Hospital Assistance"
            );

            // Clone Service Robot
            ServiceRobot serviceClone =
                (ServiceRobot)serviceRobot.Clone();

            serviceClone.BatteryCapacity = 15;
            serviceClone.SoftwareVersion = "v1.1";

            Console.WriteLine(" Original Service Robot ");
            serviceRobot.DisplayDetails();

            Console.WriteLine("\n Cloned Service Robot ");
            serviceClone.DisplayDetails();


            // Original Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                20,
                "v2.0",
                "Welding"
            );

            // Clone Industrial Robot
            IndustrialRobot industrialClone =
                (IndustrialRobot)industrialRobot.Clone();

            industrialClone.BatteryCapacity = 24;
            industrialClone.SoftwareVersion = "v2.1";

            Console.WriteLine("\n Original Industrial Robot ");
            industrialRobot.DisplayDetails();

            Console.WriteLine("\n Cloned Industrial Robot ");
            industrialClone.DisplayDetails();


            // Original Entertainment Robot
            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot(
                    "ER-300",
                    10,
                    "v3.0",
                    "Dance and Interaction"
                );

            // Clone Entertainment Robot
            EntertainmentRobot entertainmentClone =
                (EntertainmentRobot)entertainmentRobot.Clone();

            entertainmentClone.BatteryCapacity = 14;
            entertainmentClone.SoftwareVersion = "v3.1";

            Console.WriteLine("\n Original Entertainment Robot ");
            entertainmentRobot.DisplayDetails();

            Console.WriteLine("\n Cloned Entertainment Robot ");
            entertainmentClone.DisplayDetails();

            Console.WriteLine("\nRobot cloning completed successfully!");
        }
    }
}