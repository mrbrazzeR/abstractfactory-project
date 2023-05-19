using System;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int _damage;
    private float _timeEffect;
    private float _currentTime;
    [SerializeField] private int speed;
    private int _baseSpeed;

    private void Start()
    {
        _baseSpeed = speed;
    }

    public void EarnDamage(int damage, AttackType attackType, float time = 0f)
    {
        _damage = damage;
        _timeEffect = time;
        StartCoroutine(EarnEffect(attackType));
    }

    private IEnumerator EarnEffect(AttackType type)
    {
        switch (type)
        {
            case AttackType.Fire:
            {
                while (_currentTime < _timeEffect)
                {
                    Debug.Log("earn Effect and damage" + _damage);
                    yield return new WaitForSeconds(0.2f);
                    _currentTime += 0.1f;
                }

                _currentTime = 0;
                break;
            }
            case AttackType.Frost:
            {
                while (_currentTime < _timeEffect)
                {
                    Debug.Log("earn Effect and damage" + _damage);
                    speed -= 1;
                    Debug.Log("enemy slowed, current speed: " + speed);
                    yield return new WaitForSeconds(0.2f);
                    _currentTime += 0.1f;
                }

                speed = _baseSpeed;
                _currentTime = 0;
                break;
            }
            case AttackType.Normal:
            {
                {
                    Debug.Log("earn Effect and damage" + _damage);
                    yield return new WaitForSeconds(0.2f);
                    _currentTime = 0;
                }
                
                break;
            }
        }
    }
}