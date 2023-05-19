using UnityEngine;

public class Frost:IEffect
{
    private readonly int _damage;
    private readonly float _time;
    public void Executed(Enemy enemy)
    {
        enemy.EarnDamage(_damage, AttackType.Frost, _time);
    }

    public Frost(int damage, float time)
    {
        _damage = damage;
        _time = time;
    }
}