public class Elf : Enemy
{
    private float _rangeDamage;

    public void Initialize(EnemySettings enemySettings)
    {
        Health = enemySettings.Health;
        Speed = enemySettings.Speed;

        if (enemySettings is ElfSettings elfSettings)
            _rangeDamage = elfSettings.RangeDamage;
    }

    public override string ToString() => $"{nameof(Elf)}\n{base.ToString()}Дальняя атака: {_rangeDamage}";
}