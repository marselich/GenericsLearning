public class Ork : Enemy
{
    private float _meleeDamage;

    public void Initialize(EnemySettings enemySettings)
    {
        Health = enemySettings.Health;
        Speed = enemySettings.Speed;

        if (enemySettings is OrkSettings orkSettings)
            _meleeDamage = orkSettings.MeleeDamage;
    }

    public override string ToString() => $"{nameof(Ork)}\n{base.ToString()}Ближняя атака: {_meleeDamage}";
}