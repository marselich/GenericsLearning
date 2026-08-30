public class Dragon : Enemy
{
    private float _fireDamage;

    public void Initialize(EnemySettings enemySettings)
    {
        Health = enemySettings.Health;
        Speed = enemySettings.Speed;

        if (enemySettings is DragonSettings dragonSettings)
            _fireDamage = dragonSettings.FireDamage;
    }

    public override string ToString() => $"{nameof(Dragon)}\n{base.ToString()}Урон огнем: {_fireDamage}";
}