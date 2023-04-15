using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiskovSubstitution.Interfaces;
using LiskovSubstitution.Vehicles;

namespace LiskovSubstitution
{
    public class Perfomance
    {
        public void PerformActions(Vehicle veh)
        {
            veh.StartEngine();
            if (veh is IFlyable)
            {
                ((IFlyable)veh).Fly();
            }
            if (veh is IRidable)
            {
                ((IRidable)veh).Ride();
            }
        }
    }
}
