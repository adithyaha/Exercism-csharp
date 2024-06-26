using System;
using System.Globalization;

class WeighingMachine
{

    private int _precision;
    private double _weight;
    private double _tareAdjustment = 5.0;
    // TODO: define the 'Precision' property
    public int Precision
    {
        get
        {
            return _precision;
        }
        private set { _precision = value; }
    }
   
    public WeighingMachine(int precision)
    {
        this.Precision = precision;
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _weight = value;
        }
    }

    public double TareAdjustment
    {
        get
        {
            return _tareAdjustment;
        }

        set
        {
            _tareAdjustment = value;
        }

    }
    
    
    
    // TODO: define the 'DisplayWeight' property

    public string DisplayWeight
    {
        get
        {
            var format = new NumberFormatInfo() { NumberDecimalDigits = this.Precision };
            var weightString = (this.Weight - this.TareAdjustment).ToString("f", format);
            return $"{weightString} kg";
        }
    }
    

    // TODO: define the 'TareAdjustment' property
}
