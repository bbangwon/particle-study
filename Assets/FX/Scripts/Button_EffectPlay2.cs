 using UnityEngine;
using System.Collections;

public class Button_EffectPlay2 : MonoBehaviour {
	
	public GameObject Normal;
	public GameObject Rare;
	public GameObject SuperRare;
	 
	void Start(){
		if(Normal != null) {	
			Normal.SetActive(true);
		}
		if(Rare != null) {
			Rare.SetActive(false);
		}
		if(SuperRare != null) {
			SuperRare.SetActive(false);
		}
	}

	void OnGUI () {
		if(Normal != null){
			if(GUI.Button(new Rect(20,40,80,20), " Normal")) {
				Normal.SetActive(true);
				if(Rare != null) {
					Rare.SetActive(false);
				}
				if(SuperRare != null) {
					SuperRare.SetActive(false);
				}
			}
		}
		if(Rare != null){
			if(GUI.Button(new Rect(20,70,80,20), " Rare")) {
				if(Normal != null) {	
					Normal.SetActive(false);
				}
				Rare.SetActive(true);
				if(SuperRare != null) { 
					SuperRare.SetActive(false);
				}
			}
		}
		if(SuperRare != null){
			if(GUI.Button(new Rect(20,100,80,20), " SuperRare")) {
				if(Normal != null) {	
					Normal.SetActive(false);
				}
				if(Rare != null) { 
					Rare.SetActive(false);
				}
				SuperRare.SetActive(true);
			}
		}
		 
	}
}