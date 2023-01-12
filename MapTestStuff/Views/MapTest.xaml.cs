using MapTestStuff.ViewModels;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace MapTestStuff.Views;

public partial class MapTest : ContentPage
{
    private Location loc3 = new Location(35.352591, -80.680286);
    private int addCount = 0;

    public MapTest()
    {
        InitializeComponent();

        BindingContext = new MapTestViewModel();

        var location = new Location(35.351893771638714, -80.6830339076631);
        var mapSpan = MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(2));
        map.MoveToRegion(mapSpan);
    }

    //private void Button_Clicked(object sender, EventArgs e)
    //{
    //    addCount++;

    //    var whatever = map.Pins;

    //    var lat = loc3.Latitude + (0.001 * addCount);
    //    var lng = loc3.Longitude + (0.001 * addCount);

    //    map.Pins.Add(new Pin
    //    {
    //        Label = "A label",
    //        Location = new Location(lat, lng),
    //        Type = PinType.Generic
    //    });
    //}
}