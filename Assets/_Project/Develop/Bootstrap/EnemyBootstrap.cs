using UnityEngine;

public class EnemyBootstrap : MonoBehaviour
{
    private const float SpawnerPositionRadius = 5;

    [SerializeField] private DragonSettings[] _dragonSettings;
    [SerializeField] private ElfSettings[] _elfSettings;
    [SerializeField] private OrkSettings[] _orkSettings;

    private EnemySpawner _enemySpawner;

    private void Awake()
    {
        _enemySpawner = new EnemySpawner(SpawnerPositionRadius);

        Dragon dragon = _enemySpawner.Spawn(GetRandomEnemySettings(_dragonSettings)) as Dragon;
        Elf elf = _enemySpawner.Spawn(GetRandomEnemySettings(_elfSettings)) as Elf;
        Ork ork = _enemySpawner.Spawn(GetRandomEnemySettings(_orkSettings)) as Ork;

        Debug.Log(dragon.ToString());
        Debug.Log(elf.ToString());
        Debug.Log(ork.ToString());
    }

    private EnemySettings GetRandomEnemySettings(EnemySettings[] settings) => settings[Random.Range(0, settings.Length)];
}