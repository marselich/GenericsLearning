using System;
using UnityEngine;

[Serializable]
public class EnemySettings
{
    [field: SerializeField, Min(0)] public float Health { get; private set; }
    [field: SerializeField, Min(0)] public float Speed { get; private set; }
}