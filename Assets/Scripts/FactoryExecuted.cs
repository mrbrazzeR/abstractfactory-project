using UnityEngine;

public class FactoryExecuted : MonoBehaviour
{
    [SerializeField] private Item item;
    private readonly Client _client = new();
    [SerializeField] private Enemy enemy;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (item.attackType == AttackType.Fire)
            {
                _client.ClientMethod(new FireDetectEffect(), item,enemy);
            }

            if (item.attackType == AttackType.Frost)
            {
                _client.ClientMethod(new FrostDetectEffect(), item,enemy);
            }

            if (item.attackType == AttackType.Normal)
            {
                _client.ClientMethod(new NormalDetectEffect(), item,enemy);
            }
        }
    }
}