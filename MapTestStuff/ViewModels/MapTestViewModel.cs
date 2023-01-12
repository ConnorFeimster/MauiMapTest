using Microsoft.Maui.Controls.Maps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MapTestStuff.ViewModels
{
    public class MapTestViewModel
    {
        public ICommand AddPinCommand { get; private set; }

        private Location loc1 = new Location(35.350796, -80.680828);
        private Location loc2 = new Location(35.351487, -80.680611);
        private Location loc3 = new Location(35.352591, -80.680286);
        private int addCount = 0;


        public MapTestViewModel()
        {
            //StartAddLocations();

            AddPinCommand = new Command(AddPinClicked);
        }

        public ObservableCollection<MapTestPinViewModel> MapPositions { get; private set; } = new ObservableCollection<MapTestPinViewModel>();

        private void StartAddLocations()
        {
            MapPositions.Clear();
            MapPositions.Add(new MapTestPinViewModel
            {
                Label = "A label",
                Location = new Location(35.350796, -80.680828),
                TypeOfPin = PinType.Generic
            });

            MapPositions.Add(new MapTestPinViewModel
            {
                Label = "A label",
                Location = loc2,
                TypeOfPin = PinType.Generic
            });

            MapPositions.Add(new MapTestPinViewModel
            {
                Label = "A label",
                Location = loc3,
                TypeOfPin = PinType.Generic
            });
        }

        private void AddPinClicked()
        {
            addCount++;

            var lat = loc3.Latitude + (0.001 * addCount);
            var lng = loc3.Longitude + (0.001 * addCount);

            MapPositions.Add(new MapTestPinViewModel
            {
                Label = "A label",
                Location = new Location(lat, lng),
                TypeOfPin = PinType.Generic
            });
        }
    }
}
