class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int noLayers)
    {
        return noLayers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int noLayers, int ovenMinutes)
    {
        return ovenMinutes+PreparationTimeInMinutes(noLayers);
    }
}
