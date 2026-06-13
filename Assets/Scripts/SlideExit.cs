using UnityEngine;

public class SlideExit : MonoBehaviour
{
    protected void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (GameManager.Instance.hasEgg)
        {
            GameManager.Instance.WinGame();
        }
        else
        {
            Debug.Log("The slide needs something Big and Oval");
        }
    }
}
