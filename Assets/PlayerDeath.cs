using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject gameOverPanel;
    public float deathDistance = 1.2f;

    public Transform enemy1;
    public Transform enemy2;

    void Update()
    {
        if (Vector3.Distance(transform.position, enemy1.position) <= deathDistance ||
            Vector3.Distance(transform.position, enemy2.position) <= deathDistance)
        {
            gameOverPanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;

            Debug.Log("Player Died!");
        }
    }
}