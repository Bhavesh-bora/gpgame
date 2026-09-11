using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameObject winPanel;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("EXIT DOOR TRIGGERED");

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER REACHED EXIT");

            winPanel.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }
    }
}