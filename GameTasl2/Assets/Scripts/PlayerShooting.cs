using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    Ray ray;
    RaycastHit hit;

    public float bulletLifetime = 5f;
    GameObject bullet;

    [SerializeField] public float BulletForce;

    private void Start()
    {
        //Destroy(gameObject, bulletLifetime);
    }
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {

                bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                bullet.gameObject.tag = "PlayerBullet";
                rb.AddForce(transform.forward * BulletForce, ForceMode.Impulse);
                bullet.AddComponent<PlayerBllet>();

            }
        }


    }

    private void OnCollisionEnter(Collision collision)
    {

        //if (collision.gameObject.CompareTag("Enemy"))
        //{
        //    Destroy(collision.gameObject);
        //}

    }


}


