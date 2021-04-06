using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float moveSpeed = 5;
    public Vector3 direction;
    void Start()
    {
        direction = player.transform.position - transform.position;
        direction = direction / direction.magnitude;
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
