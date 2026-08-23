public class Dragon : Enemy
{
    private float _fireDamage;

    public override void Initialize(EnemySettings enemySettings)
    {
        base.Initialize(enemySettings);

        if (enemySettings is DragonSettings dragonSettings)
            _fireDamage = dragonSettings.FireDamage;
    }

    public override string ToString() => $"{nameof(Dragon)}\n{base.ToString()}Урон огнем: {_fireDamage}";
}