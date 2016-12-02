using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler   {

	private GameObject vbButtonObject;
	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("actionButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}
	

	public void OnButtonPressed  (VirtualButtonAbstractBehaviour vb) {
		Debug.Log ("Button Down");	
	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button up");
	}
}