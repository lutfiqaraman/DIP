namespace dipproject
{
  public class DogNoise : IMakingNoise
  {
    public string makeNoise()
    {
      return "Bark";
    }

    public string canEat()
    {
      return "can eat";
    }
  }
}