using UnityEngine;

public class Collectibles : Interactable
{
    protected override void Interact()
    {
        GameManager.Instance.CollectItem();
        Destroy(gameObject);
    }
}
