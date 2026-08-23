using UnityEngine;

public class EnemySpawner
{
    private const float PositionY = 1;

    private float _positionRadius;

    public EnemySpawner(float radiusPosition)
    {
        _positionRadius = radiusPosition;
    }

    public Enemy Spawn(EnemySettings enemySettings)
    {
        Enemy enemy = Object.Instantiate(enemySettings.EnemyPrefab, GetRandomPosition(), Quaternion.identity);
        enemy.Initialize(enemySettings);

        return enemy;
    }

    private Vector3 GetRandomPosition() =>
        new Vector3(Random.Range(-_positionRadius, _positionRadius), PositionY, Random.Range(-_positionRadius, _positionRadius));
}