using System.Collections;
using System.Collections.Generic;
using GoogleARCore.Examples.Common;
using UnityEngine;

public class PlaneToggle : MonoBehaviour {

	// This script is used to toggle OFF/ON the plane visualizations once we enter Aryzon mode

	public void TogglPlanes(bool toggle)
	{
		foreach (GameObject plane in GameObject.FindGameObjectsWithTag ("Plane"))
		{
            Renderer r = plane.GetComponent<Renderer> ();
            DetectedPlaneVisualizer t = plane.GetComponent<DetectedPlaneVisualizer>();
            r.enabled = toggle;
            t.enabled = toggle;
        }
	}

}
