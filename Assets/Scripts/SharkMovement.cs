using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float radius = 1.0f;

    private Vector3 center;
    private float angle;

    void Start()
    {
        center = transform.position;
    }

    void Update()
    {
        angle -= speed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}
