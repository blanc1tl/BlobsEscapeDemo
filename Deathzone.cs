using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Deathzone : MonoBehaviour
{
    public Transform spawn;


    void OnTriggerEnter2D(Collider2D player)
    {
        Time.timeScale = 0;
        player.GetComponent<AudioSource>().Play();
        StartCoroutine(Wait(player));
    }

    IEnumerator Wait(Collider2D player)
    {
        yield return new WaitForSecondsRealtime(0.6f);
        movePlayer(player);
    }

    void movePlayer(Collider2D player)
    {
        Time.timeScale = 1;
        player.transform.position = spawn.position;
    }

}
