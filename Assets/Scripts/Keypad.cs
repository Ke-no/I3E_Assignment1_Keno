using UnityEngine;

public class Keypad : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this function is for designing the interaction 
    protected override void Interact()
    {
        Animator anim = door.GetComponent<Animator>();
        doorOpen = !doorOpen;
        anim.SetBool("IsOpen", doorOpen);
    }
}
