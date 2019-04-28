using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {
    public float reachableDistance = 100.0f;
    public Camera playerCamera;

    Ray ray;
    RaycastHit hitInfo;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        ray = playerCamera.ViewportPointToRay(new Vector3(0.0f, 0.0f, 0));
        bool isRayhit = Physics.Raycast(ray, out hitInfo, reachableDistance);
        if (isRayhit && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(hitInfo.transform.name);
        }
    }
}
