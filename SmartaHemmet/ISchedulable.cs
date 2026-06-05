using System;
using System.Collections.Generic;
using System.Text;

namespace SmartaHemmet
{
    public interface ISchedulable
    {
        DateTime NextRun { get; set; }
        string Schedule(DateTime time);
        // void funkar inte för mig ...
        // void Schedule(DateTime time);
    }
}
