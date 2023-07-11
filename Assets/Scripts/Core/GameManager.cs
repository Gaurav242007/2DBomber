using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MisislePrefab;
    public Player player;
    public Button FireBtn;

    public Vector3 firePos;
    public float FireBtnDelay = .5f;


    public void FireMissile()
    {
        Vector2 playerPos = player.transform.position + firePos;
        GameObject prefab = Instantiate(MisislePrefab, playerPos, Quaternion.identity);
        if (player.isFlip)
            prefab.GetComponent<SpriteRenderer>().flipX = true;
        prefab.GetComponent<Rigidbody2D>().velocity = player.rb.velocity;
        StartCoroutine(ToggleFireBtn());
    }

    IEnumerator ToggleFireBtn()
    {
        FireBtn.interactable = false;
        yield return new WaitForSeconds(FireBtnDelay);
        FireBtn.interactable = true;
    }
}
