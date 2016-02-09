using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
	private bool flag = true;
	// Use this for initialization
	void Start () {
		//Debug.Log("Ilosc pozostalych klockow "+Strzal.Instance.cubes);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Ilosc pozostalych klockow "+Strzal.Instance.cubes);
		if(flag){
			//Debug.Log(transform.position.y);
			if(transform.position.y<1){
				Strzal.Instance.cubes-=1;
				flag=false;
			}
		}
	}
}
