using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class EnemySpawner
{
    private Dragon _dragonPrefab;
    private Elf _elfPrefab;
    private Ork orkPrefab;

    public EnemySpawner(Dragon dragonPrefab, Elf elfPrefab, Ork orkPrefab)
    {
        _dragonPrefab = dragonPrefab;
        _elfPrefab = elfPrefab;
        this.orkPrefab = orkPrefab;
    }

    public Enemy Spawn(EnemySettings enemySettings, Vector3 position)
    {
        switch (enemySettings)
        {
            case DragonSettings dragonSettings:
                Dragon dragon = Object.Instantiate(_dragonPrefab, position, Quaternion.identity) as Dragon;
                dragon.Initialize(dragonSettings);

                return dragon;

            case ElfSettings elfSettings:
                Elf elf = Object.Instantiate(_elfPrefab, position, Quaternion.identity) as Elf;
                elf.Initialize(elfSettings);

                return elf;

            case OrkSettings orkSettings:
                Ork ork = Object.Instantiate(orkPrefab, position, Quaternion.identity) as Ork;
                ork.Initialize(orkSettings);

                return ork;

            default:
                throw new Exception("enemySettings not found");
        }
    }
}