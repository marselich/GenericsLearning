using System;
using UnityEngine;

[Serializable]
public class DragonSettings : EnemySettings
{
    [field: SerializeField, Min(0)] public float FireDamage { get; private set; }
}