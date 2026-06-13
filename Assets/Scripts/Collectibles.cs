using UnityEngine;

public class Collectibles : Interactable
{
    [SerializeField]
    private bool isEgg = false;
    protected override void Interact()
    {
        GameManager.Instance.CollectItem();

        if (isEgg)
        {
            GameManager.Instance.CollectEgg();
        }
        
        Destroy(gameObject);
    }
}
