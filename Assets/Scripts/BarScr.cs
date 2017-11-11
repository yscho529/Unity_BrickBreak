using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScr : MonoBehaviour {

    public Rigidbody2D rb;
    public float _speed;
    public Vector3 _target;

	// Use this for initialization
	void Start () {
        //_speed = 15;
	}
	
	// Update is called once per frame
	void Update () {
        _target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _target.z = transform.position.z;
        _target.y = transform.position.y;
        transform.position = Vector3.Lerp(transform.position, _target, _speed * Time.deltaTime);
	}
}
