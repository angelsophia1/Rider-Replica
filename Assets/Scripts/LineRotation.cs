using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRotation : MonoBehaviour {
    private bool isCollide = false;
    public float rotAngle =1f;
    public RectTransform rectTranform;
    public Vector3 direction;
    public Transform pivotPoint;
    private void Start()
    {

    }
	// Update is called once per frame
	private void Update () {
        if(isCollide == true)
        {
            direction = new Vector3(0.001636505f, -0.333045f, 0.557f); 
            transform.RotateAround(pivotPoint.position,direction,-rotAngle*Time.deltaTime*50f);
        }
	}

    private void OnCollisionEnter2D()
    {
        isCollide = true;
    }
    private void OnCollisionExit2D()
    {
        isCollide = false;
    }

}
