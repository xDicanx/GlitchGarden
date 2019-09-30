using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    [SerializeField] Projectile projectilePrefab;
    [SerializeField] GameObject gun;
    
     public void LauchProjectile()
    {
        Instantiate(projectilePrefab, gun.transform.position, Quaternion.identity);
    }
}
