using UnityEngine;

public class Normal:IEffect
{
    private readonly int _damage;
    public void Executed(Enemy enemy)
    {
        enemy.EarnDamage(_damage,AttackType.Normal);
    }
    public Normal(int damage)
    {
        _damage = damage;
    }
}