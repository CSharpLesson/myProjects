using System;
using System.Linq;

namespace Trening
{
    public static class LogisticsManager
    {
        public static void PlanDelivery(string logisticsName)
        {
            var logistics = GetLogistics(logisticsName);
            if (logistics == null)
            {
                Console.WriteLine("This logistics not supported!");
                return;
            }

            logistics.PlanDelivery();
        }

        static Logistics GetLogistics(string logisticsName)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = assemblies.SelectMany(s => s.GetTypes());
            var logisticsTypes = types.Where(w => typeof(Logistics).IsAssignableFrom(w));
            logisticsTypes = logisticsTypes.Where(w => !w.IsAbstract);

            var className = logisticsName + "Logistics";
            var logisticType = logisticsTypes.FirstOrDefault(f => f.Name.ToLower() == className.ToLower());
            if (logisticType == null)
                return null;

            return Activator.CreateInstance(logisticType) as Logistics;
        }
    }
}