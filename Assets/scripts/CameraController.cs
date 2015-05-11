using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float ScrollSpeed = 10f;
    public float ZoomSpeed = 100f;

    public float MaxZoom = 8f;
    public float MinZoom = 2f;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        var h = Input.GetAxis("Horizontal") * ScrollSpeed;
        var v = Input.GetAxis("Vertical") * ScrollSpeed;
        var zoom = -Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;

        var component = GetComponent<Rigidbody>();

        var velocity = new Vector3(h, zoom, v);

        if ((component.position.y > MaxZoom && zoom > 0) || (component.position.y < MinZoom && zoom < 0))
        {
            velocity.y = 0;
        }

        component.velocity = velocity;
    }
}
