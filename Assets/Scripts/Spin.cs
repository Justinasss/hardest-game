using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        //speed * Time.deltaTime makes the rotation frame rate independent
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
