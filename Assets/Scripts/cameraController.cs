using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

   // RectOffset = -4;

    // Use this for initialization
    void Start()
    {
        offset.z = (transform.position.z - 1);
        offset.x = (transform.position.x) + 1;
        offset.y = (transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
     //   yaw += speedH * Input.GetAxis("Mouse X");
     //   pitch -= speedV * Input.GetAxis("Mouse Y");

    }
}
