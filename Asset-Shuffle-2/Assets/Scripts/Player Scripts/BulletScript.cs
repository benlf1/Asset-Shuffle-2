using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float moveSpeed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = transform.forward * moveSpeed * Time.deltaTime;
        transform.position += velocity;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
