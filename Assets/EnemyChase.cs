using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;

    void Update()
    {
        transform.LookAt(player);
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}