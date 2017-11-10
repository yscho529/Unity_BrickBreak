using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScr : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    private Vector3 pos;

	// Use this for initialization
	void Start () {
        pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
	}
}
