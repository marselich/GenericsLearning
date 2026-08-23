public class Ork : Enemy
{
    private float _meleeDamage;

    public override void Initialize(EnemySettings enemySettings)
    {
        base.Initialize(enemySettings);

        if (enemySettings is OrkSettings orkSettings)
            _meleeDamage = orkSettings.MeleeDamage;
    }

    public override string ToString() => $"{nameof(Ork)}\n{base.ToString()}Ближняя атака: {_meleeDamage}";
}