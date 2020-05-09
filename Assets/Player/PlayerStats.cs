using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "PlayerStats")]
public class PlayerStats : ScriptableObject
{
    public float baseBulletSpeed = 1f;
    public float bulletSpeed = 1f;

    public float baseFireRate = 1f;
    public float fireRate = 1f;

    public float baseSpeed = 1f;
    public float speed = 1f;

    public int maxHealth = 5;
    public int health = 5;
}
