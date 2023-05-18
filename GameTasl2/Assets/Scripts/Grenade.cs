//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Grenade : MonoBehaviour
//{
//    public float delay = 3f;
//    float countDown;
//    bool hasExploded = false;
//    public float force = 700f;


//    private void Start()
//    {
//        countDown = delay;

//    }

//    private void Update()
//    {
//        countDown -= Time.deltaTime;
//        if (countDown <= 0f && !hasExploded)
//        {
//            Explode();
//            hasExploded = true;
//        }
//    }

//    private void Explode()
//    {
//        Debug.Log("BOOMM!");
//        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

//        foreach (Collider nearbyObject in colliders)
//        {
//            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
//            if (rb != null)
//            {
//                rb.AddExplosionForce(force, transform.position, radius);
//            }


//        }

//        Destroy(gameObject);
//    }
//}
