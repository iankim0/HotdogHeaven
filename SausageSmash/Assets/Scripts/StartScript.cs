using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject StartPanel; 

    void Start()
    {
        Time.timeScale = 0f;
        if (StartPanel != null)
        {
            StartPanel.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
            if (StartPanel != null)
            {
                StartPanel.SetActive(false);
            }
            this.enabled = false;
        }
    }
}
