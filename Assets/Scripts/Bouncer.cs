using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{

    public float speed = 5.0f;

    public float height = 3f;
    // Update is called once per frame
    void Update()
    {
        var y = Mathf.Sin(Time.time * speed) * height;

        y = Mathf.Abs(y);

        var x = transform.position.x;
        var z = transform.position.y;

        transform.position = new Vector3(x, y, z);
    }
}
