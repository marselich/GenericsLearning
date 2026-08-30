using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float Health;
    protected float Speed;

    public override string ToString() => $"Здоровье: {Health}\nСкорость: {Speed}\n";
}