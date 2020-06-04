namespace dipproject
{
  public class CatNoise : IMakingNoise
  {
    public string makeNoise()
    {
      return "Meow";
    }

    public string canEat()
    {
      return "can eat";
    }
  }
}