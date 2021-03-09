using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 0.125f;

    public Vector3 offset;

    public void LateUpdate()
    {
        transform.position = target.position + offset;
    }

}
