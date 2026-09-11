using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public float attackRange = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            foreach (GameObject enemy in enemies)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);

                if (distance <= attackRange)
                {
                    enemy.SetActive(false);
                    Debug.Log("ENEMY KILLED");
                }
            }
        }
    }
}