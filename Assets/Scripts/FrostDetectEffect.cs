public class FrostDetectEffect : IDetectEffect
{
    public IEffect GetEffect(int damage=0, float time=0)
    {
        return new Frost(damage,time);
    }
}