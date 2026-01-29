class RemoteControlCar
{

    private int _percentage = 100;
    private int _meters = 0;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        if(_percentage > 0)
        {
            return $"Battery at {_percentage}%";
        }
        else
        {
            return $"Battery empty";
        }
    }

    public void Drive()
    {
        if(_percentage > 0)
        {
            _percentage = _percentage - 1;
            _meters = _meters + 20; 
        }

    }
}
