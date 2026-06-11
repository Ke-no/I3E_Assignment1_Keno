using UnityEngine;
using System.Collections;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject door;

    // If player spam E, multiple coroutines will start so include this to prevent reopening while is already open
    private bool isDoorBusy = false;
    
    //this function is for designing the interaction 
    protected override void Interact()
    {
        if (!GameManager.Instance.HasAllItems())
        {
            Debug.Log("Need all 5 items!");
            return;
        }
        StartCoroutine(OpenDoorTemporarily());

    }

    private IEnumerator OpenDoorTemporarily()
    {
        Animator anim = door.GetComponent<Animator>();
        anim.SetBool("IsOpen", true);
        yield return new WaitForSeconds(5f);
        anim.SetBool("IsOpen", false);
    }
}