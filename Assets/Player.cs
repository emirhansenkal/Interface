using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamageable<float>, IKillable
{
    private float _health = 100;

    public float Health 
    { 
        get => _health;
        set => _health = value;
    }

    public void Damage(float damageTaken)
    {
        _health -= damageTaken;
    }

    public void Kill()
    {
        _health = 0;
    }
}
