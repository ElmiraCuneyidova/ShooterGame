using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBllet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(nameof(DestroyBullet));
    }

    void Update()
    {
        
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f);
        Destroy(transform.gameObject);
    }
}
