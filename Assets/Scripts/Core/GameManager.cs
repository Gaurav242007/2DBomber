using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject MisislePrefab;
    public Player player;
    public Vector3 firePos;


    public void FireMissile()
    {
        Vector2 playerPos = player.transform.position + firePos;
        GameObject prefab = Instantiate(MisislePrefab, playerPos, Quaternion.identity);
        if (player.isFlip)
            prefab.GetComponent<SpriteRenderer>().flipX = true;
        prefab.GetComponent<Rigidbody2D>().velocity = player.rb.velocity;

    }
}
