using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;

   public void ReceiveDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(this.gameObject);
    }
}
