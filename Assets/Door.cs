using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (KeyPickup.hasKey)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Scene2");
            }
            else
            {
                Debug.Log("You need the key!");
            }
        }
    }
}