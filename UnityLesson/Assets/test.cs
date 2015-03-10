using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				print("Hit: "+hit.collider.name);
				//GameObject obj = GameObject.Find(hit.collider.name);
				Color modelColor = hit.transform.renderer.material.color;
				modelColor.a=0;
				modelColor.r=0;
				modelColor.g=0;
				modelColor.b=0;
				hit.transform.renderer.material.color = modelColor;
			}
		}
	}
}
