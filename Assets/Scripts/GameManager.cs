using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerUI playerUI;

    public int collectedItems = 0;
    public int requiredItems = 5;
    public bool hasEgg = false;
    public event Action OnWin;

    private void Awake()
    {
        Instance = this;
    }

    public void CollectItem()
    {
        collectedItems++;
    }

    public bool HasAllItems()
    {
        return collectedItems >= requiredItems;
    }

    public void CollectEgg()
    {
        hasEgg = true;
    }

    public void WinGame()
    {
        Debug.Log("You have escaped the floor");

        OnWin?.Invoke();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }
}
