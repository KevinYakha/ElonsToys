using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return "Driven " + _distanceDriven + " meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryPercentage <= 0)
            return "Battery empty";
        return "Battery at " + _batteryPercentage + "%";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0)
        {
            _distanceDriven += 20;
            _batteryPercentage -= 1;
        }
    }

    private int _distanceDriven = 0;
    private int _batteryPercentage = 100;
}
