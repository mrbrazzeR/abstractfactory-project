using UnityEngine;

public class Fire : IEffect
{
    private readonly int _damage;
    private readonly float _time;

    public void Executed(Enemy enemy)
    {
        enemy.EarnDamage(_damage, AttackType.Fire, _time);
    }

    public Fire(int damage, float time)
    {
        _damage = damage;
        _time = time;
    }
}