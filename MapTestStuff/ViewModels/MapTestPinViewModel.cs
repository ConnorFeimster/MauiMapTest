using Microsoft.Maui.Controls.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTestStuff.ViewModels
{
    public class MapTestPinViewModel
    {
        public Location Location;
        public string Label;
        public string Address;
        public readonly DateTime TimeStamp;
        public PinType TypeOfPin;

        public MapTestPinViewModel()
        {
            TimeStamp = DateTime.UtcNow;
        }
    }
}
