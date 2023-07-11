using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10;


    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.collider.CompareTag("Enemy"))
        {
            EnemyTower enemy = hitInfo.collider.GetComponent<EnemyTower>();
            enemy?.TakeDamage(damage);
            Destroy(gameObject);

        }
        Destroy(gameObject);
    }
}
