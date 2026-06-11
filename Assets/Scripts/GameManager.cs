using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int collectedItems = 0;
    public int requiredItems = 5;

    private void Awake()
    {
        Instance = this;
    }

    public void CollectItem()
    {
        collectedItems++;
        Debug.Log("Collected: " + collectedItems + "/" + requiredItems);
    }

    public bool HasAllItems()
    {
        return collectedItems >= requiredItems;
    }
}
