using UnityEngine;

public class Remote : Interactable
{
    [SerializeField]
    private GameObject wallToDestory;

    protected override void Interact()
    {
        if (wallToDestory != null)
        {
            Destroy(wallToDestory);
        }
        Destroy(gameObject);
    }
}
