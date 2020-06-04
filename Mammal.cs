namespace dipproject
{
  public class Mammal
  {
    IMakingNoise behaviour;
    
    public Mammal(IMakingNoise IMN)
    {
      this.behaviour = IMN;
    }

    public string makeNoise()
    {
      return this.behaviour.makeNoise();
    }

    public string canEat()
    {
      return this.behaviour.canEat();
    }
  }
}