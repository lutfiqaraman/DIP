namespace dipproject
{
  public class Mammal
  {
    IMakingNoise noise;
    public Mammal(IMakingNoise IMN)
    {
      this.noise = IMN;
    }

    public string makeNoise()
    {
      return this.noise.makeNoise();
    }
  }
}