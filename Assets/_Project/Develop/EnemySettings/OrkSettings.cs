using System;
using UnityEngine;

[Serializable]
public class OrkSettings : EnemySettings
{
    [field: SerializeField, Min(0)] public float MeleeDamage { get; private set; }
}