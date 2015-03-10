using UnityEngine;
using System.Collections;

public class RotateModel : MonoBehaviour {
	private Vector3 lastMousePosition;
	public Transform anatomyModel;
	public GUIStyle guistyle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{

			//GameObject model = GameObject.Find("Female_119");
			//model.SetActive(false);


			

		}
		lastMousePosition = Input.mousePosition;
	}

	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(10,10,Screen.width-10, Screen.height-10),"Test");
		if(GUILayout.Button("TEst"))
		{

		}
		GUILayout.EndArea();
	}
}
