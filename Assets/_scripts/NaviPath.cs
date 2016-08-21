using UnityEngine;
using System.Collections;

public class NaviPath : MonoBehaviour {
    
	// Use this for initialization
	private Camera cameraObject;
	private Matrix4x4 viewMatrix;
        
	void Start () {
		cameraObject = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		viewMatrix = cameraObject.worldToCameraMatrix;

	}
	
	// Update is called once per frame
	void Update () {
	}
}
