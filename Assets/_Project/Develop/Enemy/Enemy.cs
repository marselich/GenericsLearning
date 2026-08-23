using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private float _health;
    private float _speed;

    public virtual void Initialize(EnemySettings enemySettings)
    {
        _health = enemySettings.Health;
        _speed = enemySettings.Speed;
    }

    public override string ToString() => $"Здоровье: {_health}\nСкорость: {_speed}\n";
}