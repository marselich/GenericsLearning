public class Elf : Enemy
{
    private float _rangeDamage;

    public override void Initialize(EnemySettings enemySettings)
    {
        base.Initialize(enemySettings);

        if (enemySettings is ElfSettings elfSettings)
            _rangeDamage = elfSettings.RangeDamage;
    }

    public override string ToString() => $"{nameof(Elf)}\n{base.ToString()}Дальняя атака: {_rangeDamage}";
}