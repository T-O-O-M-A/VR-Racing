using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour {

    public float vykon = 1000;
    public float uhelRizeni = 30;
    public string osaRizeni = "Horizontal";
    public string osaPlynuABrzdy = "Vertical";

    public WheelCollider lp, pp, lz, pz;
    public Rigidbody auto;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        lp.steerAngle = pp.steerAngle = uhelRizeni * Input.GetAxis(osaRizeni);
        if (Input.GetAxis(osaPlynuABrzdy) > 0)
        {
            Debug.Log(lz.motorTorque = pz.motorTorque = vykon * Input.GetAxis(osaPlynuABrzdy));
            lz.brakeTorque = pz.brakeTorque = 0;
        }
        else
        {
            lz.motorTorque = pz.motorTorque = 0;
            Debug.Log("b" +(lz.brakeTorque = pz.brakeTorque = -vykon * Input.GetAxis(osaPlynuABrzdy)).ToString());
        }
	}
}
