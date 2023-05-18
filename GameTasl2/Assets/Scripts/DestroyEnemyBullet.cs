using System.Collections;
using UnityEngine;

public class DestroyEnemyBullet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(nameof(DestroyBullet));
    }


    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f);

        Destroy(gameObject);
    }
}
