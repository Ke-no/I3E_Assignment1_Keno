using UnityEngine;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;
    [SerializeField]
    private TextMeshProUGUI taskText;
    [SerializeField]
    private TextMeshProUGUI progressText;
    [SerializeField]
    private TextMeshProUGUI healthText;
    [SerializeField]
    private PlayerHealth playerhealth;
    [SerializeField]
    private TextMeshProUGUI winText;
    [SerializeField]
    private TextMeshProUGUI dieText;

    void Start()
    {
        if (winText != null)
        {winText.gameObject.SetActive(false);}

        if (dieText != null)
        {dieText.gameObject.SetActive(false);}
        
        if (GameManager.Instance != null)
        {GameManager.Instance.OnWin += HandleWin;}

        if (playerhealth != null)
        {playerhealth.OnDie += HandleDie;}
    }

    void OnDestroy()
    {
        if (GameManager.Instance != null)
        {GameManager.Instance.OnWin -= HandleWin;}

        if (playerhealth != null)
        {playerhealth.OnDie -= HandleDie;}
    }

    void Update()
    {
        if (GameManager.Instance == null)
           return;

        // Task
        if (taskText != null)
        {taskText.text = "Task: Collect & uncover the slide to escape";}
        
        // Progress
        if (progressText != null)
        {progressText.text = $"Collect: {GameManager.Instance.collectedItems}/6";}

        // Health
        if (healthText != null && playerhealth != null)
        {healthText.text = $"Health: {playerhealth.currentHealth}/{playerhealth.maxHealth}";}
    }
        
       // Prompts
       public void UpdateText(string promptMessage)
       {
        if(promptText != null)
        {promptText.text = promptMessage;}
       }
    
        // When player wins text appears
        public void HandleWin()
        {
            if(winText != null)
            {
                winText.gameObject.SetActive(true);
                winText.text = "You have escaped this floor";
            }
        }

        // When player dies (lose) text appears
        private void HandleDie()
    {
        if (dieText != null)
        {
            dieText.gameObject.SetActive(true);
            dieText.text = "You died and slowly devoured by the floor...";
        }
    }
}
