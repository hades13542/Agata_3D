using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public int cubes;
	public Rigidbody pocisk;
	public Transform Pozycja;
	public bool strzelanie;
	public int iloscKul;
	public static Shoot Instance;
	
	void Awake(){
		Instance = this;
	}
	void Start () {
		cubes = 6;
		iloscKul = 1;
		strzelanie = true;
		//Debug.Log(cubes);
	}
	
	// Update is called once per frame
	void Update () {
		//if klawisz escape -> wyjsc z gry!!!!!!!!!!!!!!!!!!!!
		/*if(Application.loadedLevelName == "scena2"){
			Debug.Log("SCENA2");
		}*/
		//Debug.Log("Current: "+cubes);
		if(cubes == 0){
			Application.LoadLevel("scena2");
		}
		
		if (iloscKul==-1){
			if(cubes == 0){
				Application.LoadLevel("scena2");
			}else{
				Application.LoadLevel("game_over");
			}
		}
		
		if(Input.GetMouseButtonDown(0) && strzelanie == true){
			iloscKul -= 1;
			Rigidbody clone;
			clone = Instantiate(pocisk,Pozycja.position,Pozycja.rotation) as Rigidbody; //tworze nowy obiekt, strzelam pociskami, wiec pocisk, ustawiam pozycje, rotacje
			clone.AddForce(Pozycja.forward * 1000); //ustawienie wektora sily
			Destroy(clone.gameObject, 4); //po 4 sekundach pociski znikaja
		}
		
	}
}
