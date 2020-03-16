using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator checkFlagAnimator;
    public GameObject checkFlag;
    public GameObject spawnPoint;

    private void OnTriggerStay2D(Collider2D player)
    {
        checkFlagAnimator.SetBool("playerTouch", true);
        spawnPoint.transform.position = checkFlag.transform.position + Vector3.up * 2f;

    }
}
