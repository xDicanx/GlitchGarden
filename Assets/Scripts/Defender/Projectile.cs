using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;
    [SerializeField] int maxHits;
    [SerializeField] float degreesPerSecond;

    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (maxHits > 0)
        {
            Move();
            Rotation();
        }
        DestroyProjectile();
    }

    //Move gameobjec to the right
    private void Move()
    {
        this.transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
    }

    private void Rotation()
    {
        if (this.transform.tag == "Banana")
            this.transform.Rotate(0, 0, -degreesPerSecond * Time.deltaTime);
    }

    //Destroys gameobject 
    private void DestroyProjectile()
    {
        if (maxHits <= 0)
        {
            damage = 0;
            anim.Play("Explosion");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Health>().ReceiveDamage(this.damage);
            this.maxHits--;
        }
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
}
