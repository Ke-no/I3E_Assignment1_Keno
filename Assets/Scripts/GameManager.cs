using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int collectedItems = 0;
    public int requiredItems = 5;
    public bool hasEgg = false;

    [SerializeField]
    private GameObject winPanel;

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

    public void CollectEgg()
    {
        hasEgg = true;
        Debug.Log("Egg collected!");
    }

    public void WinGame()
    {
        Debug.Log("You have escaped the Backrooms!");

        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
