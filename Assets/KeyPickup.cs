using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static bool hasKey = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            Destroy(gameObject);

            Debug.Log("Key Collected!");
        }
    }
}