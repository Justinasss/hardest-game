using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public List<Vector3> path = new();

    public float speed = 2.0f;

    private Vector3 target;
    private int index = 0;

    void Start()
    {
        target = path[index];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 0.3f)
        {
            index++;
            if (index >= path.Count)
            {
                index = 0;
            }
            target = path[index];
            
        }
        

        transform.LookAt(target);
        transform.position += transform.transform.forward * speed * Time.deltaTime;

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        for (int i = 0; i < path.Count; i++)
        {
            Gizmos.DrawLine(path[i], path[i + 1]);
        }
    }
}
