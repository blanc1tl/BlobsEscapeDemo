using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    public Animator doorAnimator;
    bool activate = false;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            activate = true;
        }
        else
        {
            activate = false;
        }
    }

    private void OnTriggerStay2D(Collider2D player)
    {
        doorAnimator.SetBool("PlayerTouch", true);

        if (activate == true)
            SceneManager.LoadScene("Level Select");
    }
}
