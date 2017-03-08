using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    public Camera kamera;
    public Transform pos0;
    public Rigidbody objekt;
    public float sila = 1;
    public float fov = 90;
    Vector3 rychlost, zrychleni;

	// Use this for initialization
	void Start () {
        rychlost = objekt.velocity;
        zrychleni = objekt.velocity- rychlost;
    }
	
	// Update is called once per frame
	void Update () {
        zrychleni = Vector3.Lerp(zrychleni,objekt.velocity - rychlost,Time.deltaTime);
        rychlost = objekt.velocity;
        kamera.transform.position= pos0.position - zrychleni;
        kamera.transform.rotation = pos0.rotation;
	}
}
