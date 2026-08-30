using UnityEngine;

public class EnemyBootstrap : MonoBehaviour
{
    private const float SpawnerPositionRadius = 5;
    private const float PositionY = 1;

    [SerializeField] private Dragon _dragonPrefab;
    [SerializeField] private Elf _elfPrefab;
    [SerializeField] private Ork _orkPrefab;

    [SerializeField] private DragonSettings[] _dragonSettings;
    [SerializeField] private ElfSettings[] _elfSettings;
    [SerializeField] private OrkSettings[] _orkSettings;

    private EnemySpawner _enemySpawner;

    private void Awake()
    {
        _enemySpawner = new EnemySpawner(_dragonPrefab, _elfPrefab, _orkPrefab);

        Dragon dragon = _enemySpawner.Spawn(GetRandomEnemySettings(_dragonSettings), GetRandomPosition()) as Dragon;

        Elf elf = _enemySpawner.Spawn(GetRandomEnemySettings(_elfSettings), GetRandomPosition()) as Elf;

        Ork ork = _enemySpawner.Spawn(GetRandomEnemySettings(_orkSettings), GetRandomPosition()) as Ork;

        Debug.Log(dragon.ToString());
        Debug.Log(elf.ToString());
        Debug.Log(ork.ToString());
    }

    private EnemySettings GetRandomEnemySettings(EnemySettings[] settings) => settings[Random.Range(0, settings.Length)];

    private Vector3 GetRandomPosition()
    {
        Vector2 positionPoint = Random.insideUnitCircle * SpawnerPositionRadius;

        return new Vector3(positionPoint.x, PositionY, positionPoint.y);
    }
}