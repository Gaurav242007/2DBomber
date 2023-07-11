using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTower : MonoBehaviour
{
    public static int startHealth;
    public int health;

    public Slider healthBar;
    public ParticleSystem destroyFx;

    void Start()
    {
        startHealth = health;
        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(destroyFx, transform.position, Quaternion.identity);
        }
        health -= damage;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        healthBar.value = health / startHealth;

    }
}
