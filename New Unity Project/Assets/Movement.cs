using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed;
    public Rigidbody rig;
    Vector3 movement;
	// Use this for initialization
	void Start () {
		
	}
    void Update()
    {
      if(speed != 0)
      {
	      Debug.Log("You moving with " + speed + "speed");
      }
    }
	// Update is called once per frame
	void FixedUpdate () {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
	}
}
