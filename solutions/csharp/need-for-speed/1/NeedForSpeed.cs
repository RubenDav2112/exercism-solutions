class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _battery = 100;
    private int _distanceDriven = 0;
    public int getSpeed => _speed;
    public int getBatteryDrain => _batteryDrain;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if(_battery >= _batteryDrain)
        {
            return false;
        }

        return true;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _battery -= _batteryDrain;
            _distanceDriven += _speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }


}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

    private int _distance;

    

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int veces = 100/car.getBatteryDrain;
        int distanceMax = veces * car.getSpeed;

        return distanceMax >= _distance;

    }
}
