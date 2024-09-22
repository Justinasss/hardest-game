using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform target;

    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);

        transform.position += transform.forward * speed * Time.deltaTime;

    }
}
