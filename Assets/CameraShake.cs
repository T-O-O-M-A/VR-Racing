using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public Camera kamera;
    public Rigidbody objekt;
    public float sila = 1;
    public float fov = 90;
    Vector3 rychlost, lastPos;
    float zrychleni;

	// Use this for initialization
	void Start () {
        rychlost = objekt.velocity;
        zrychleni = objekt.velocity.magnitude - rychlost.magnitude;
    }
	
	// Update is called once per frame
	void Update () {
        zrychleni = objekt.velocity.magnitude - rychlost.magnitude;
        rychlost = objekt.velocity;
        kamera.fov = Mathf.Lerp(kamera.fov,fov + zrychleni * sila,Time.deltaTime);
	}
}
