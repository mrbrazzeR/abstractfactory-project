public class FireDetectEffect:IDetectEffect
{
    public IEffect GetEffect(int damage=0, float time=0)
    {
        return new Fire(damage,time);
    }
}