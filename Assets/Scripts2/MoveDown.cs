using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 100f;
    private float zDestroy = -52.0f;

    Rigidbody enemyRigidbody;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        enemyRigidbody.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
