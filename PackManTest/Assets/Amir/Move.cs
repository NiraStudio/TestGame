using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");
        Vector2 t = transform.position;
        t.x += hor * speed * Time.deltaTime;
        t.y += ver * speed * Time.deltaTime;
        transform.position = t;
        
	}
}
