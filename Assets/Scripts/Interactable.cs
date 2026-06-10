using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // message displays to player when looking at an interactable
    public string promptMessage;

    //this function will be called from player
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        //template function to be overridden by subclassess
    }
}