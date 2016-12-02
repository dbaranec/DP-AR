using UnityEngine;
using System.Collections;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler   {

	private GameObject vbButtonObject;
	private GameObject spider;
	// Use this for initialization
	void Start () {
		spider = GameObject.Find ("spider");
		vbButtonObject = GameObject.Find ("actionButton");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		ReInvoke ();//vyvolavanie attaku

	}

	private void Repeat(){
		spider.GetComponent<Animation> ().Play();
	}
	private void ReInvoke(){
		InvokeRepeating("Repeat", 1.0f, 1.0f);
	}


	public void OnButtonPressed  (VirtualButtonAbstractBehaviour vb) {
			
		spider.active = true;
		//ked sa stlaci bude visible
	//	spider.SetActive(true);
			

	}


	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		spider.active=false;
		//ked pustim bude invisible

	}
}