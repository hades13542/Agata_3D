using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {
	public string temp;
	public string temp2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		temp = "Ilosc niezbitych klockow: "+Strzal.Instance.cubes;
		temp2 = "Ilosc kul: "+Strzal.Instance.iloscKul;
	}
	void OnGUI(){
		GUI.TextArea(new Rect(10, 10, 190, 24), temp);
		GUI.TextArea(new Rect(Screen.width-100, 10, 90, 24), temp2);
		GUI.TextArea(new Rect((Screen.width/2)-50, 5, 90, 20), "LEVEL 2");
	}
}
