using System.Collections;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

 
    public GameObject bulletPrefab;
    public Transform bulletSpawner;
    [SerializeField] public float bulletForce;
    [SerializeField] public float speed;

    GameObject bullet;

    private void Start()
    {
        StartCoroutine(BulletCoroutine());
    }

    private IEnumerator BulletCoroutine()
    {
        while (true)
        {
         
            yield return new WaitForSeconds(2f);
            bullet = Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
          
            rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);


            yield return new WaitForSeconds(5f);
            Destroy(transform.gameObject);
        }
    }


    //private void FireBullet()
    //{
    //    Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation) ;
    //}
}

















    //    public GameObject bulletPrefab;
    //    // public Transform bulletSpawn;
    //    [SerializeField] public float bulletSpeed;
    //    [SerializeField] float force;


    //    //Rigidbody rb;

    //    private void Start()
    //    {
    //        //rb = GetComponent<Rigidbody>();
    //        // rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);

    //        StartCoroutine(bulletSpawner());

    //    }
    //    IEnumerator bulletSpawner()
    //    {  GameObject bullet;
    //        yield return new WaitForSeconds(5f);
    //            bullet = Instantiate(bulletPrefab, transform.position,Quaternion.identity);
    //            bullet.AddComponent<DestroyEnemyBullet>();
    //            Rigidbody rb = bullet.GetComponent<Rigidbody>();
    //            rb.AddRelativeForce(transform.position * bulletSpeed, ForceMode.Impulse);





//}
