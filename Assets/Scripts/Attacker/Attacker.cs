using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField]float currentSpeed = 0;
    
    
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime, Space.World);
    }

    void SetMovementSpeed(float newSpeed)
    {
        currentSpeed = newSpeed;        
    }
}
