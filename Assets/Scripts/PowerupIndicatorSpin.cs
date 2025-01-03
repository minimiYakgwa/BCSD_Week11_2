using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupIndicatorSpin : MonoBehaviour
{
    private float rotateSpeed = 50.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
