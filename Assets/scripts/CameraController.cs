using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float ScrollSpeed = 10f;
    public float ZoomSpeed = 100f;
    
	void FixedUpdate () {
        Move();
	}

    private void Move()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        var zoom = -Input.GetAxis("Mouse ScrollWheel");

        var component = GetComponent<Rigidbody>();

        var velocity = new Vector3(
            ScrollSpeed * h,
            zoom * ZoomSpeed,
            ScrollSpeed * v);

        component.velocity = velocity;	
    }
}
