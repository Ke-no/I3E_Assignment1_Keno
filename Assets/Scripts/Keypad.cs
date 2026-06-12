using UnityEngine;
using System.Collections;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject door;

    // prevents the player from spamming E
    private bool isDoorBusy = false;
    
    protected override void Interact()
    {
        if (!GameManager.Instance.HasAllItems())
        {
            Debug.Log("Need all 5 items!");
            return;
        }

        // check if door is busy (opened)
        if (isDoorBusy)
        return;

        StartCoroutine(OpenDoorTemporarily());

    }

    private IEnumerator OpenDoorTemporarily()
    {
        // mark the door as busy
        isDoorBusy = true;

        Animator anim = door.GetComponent<Animator>();
        anim.SetBool("IsOpen", true);
        yield return new WaitForSeconds(5f);
        anim.SetBool("IsOpen", false);

        // allow keypad to be used again
        isDoorBusy = false;
    }
}