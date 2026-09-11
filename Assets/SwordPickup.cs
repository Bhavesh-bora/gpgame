using UnityEngine;

public class SwordPickup : MonoBehaviour
{
    public static bool hasSword = false;

    public float pickupDistance = 1.5f;
    public Transform player;

    void Update()
    {
        if (player != null &&
            Vector3.Distance(transform.position, player.position) <= pickupDistance)
        {
            hasSword = true;

            Destroy(gameObject);

            Debug.Log("Sword Picked Up!");
        }
    }
}