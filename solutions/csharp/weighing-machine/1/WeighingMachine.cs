class WeighingMachine
{
    private double _weight;
    private double _tareAdjustment;
    private string _displayWeight;

    // TODO: define the 'Precision' property
    public int Precision{get;}
    public WeighingMachine(int precision)
    {
        Precision = precision;
        TareAdjustment = 5.0;
    }

    // TODO: define the 'Weight' property
    public double Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if(value < 0) throw new ArgumentOutOfRangeException(nameof(value),"Valor debe ser positivo o cero");
            
            _weight = value;
        }
    }


    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment{get; set;}

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get
        {
            double netWeight = Weight - TareAdjustment;
            return $"{netWeight.ToString("F"+Precision)} kg";
        }
    }

}
