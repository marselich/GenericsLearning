using System;
using UnityEngine;

[Serializable]
public class ElfSettings : EnemySettings
{
    [field: SerializeField, Min(0)] public float RangeDamage { get; private set; }
}