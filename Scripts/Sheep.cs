using UnityEngine;
using UnityEngine.UI;


public class Sheep : MonoBehaviour{
	public TextMesh nameTextLeft; // Text on the left of the sheep
	public TextMesh nameTextRight; // Text on the right of the sheep

	public WheelControl[] wheels; // Saw a reel about how the sheep were on wheels.
	public int name; // The number that will be on the side of the sheep
	public float accelerationForce=;

	public bool isBot = true;
	void Awake(){
		nameTextLeft.text = (string) name;
		nameTextRight.text = (string) name;
	}

	void Update(){
		if(isBot){
			MoveLikeABot();
		}else{
			MoveWithThePerson();
		}
	}

	void MoveLikeABot(){
		for(WheelControl wheel in wheels){
			
		}
	}

	void MoveWithThePerson(){
		for(WheelControl wheel in wheels){
			
		}
	}

	public void Kill(){

	}

	// My theory is that if i have a different object serving as the sheep's
	// main collider and the collider with the script is the one detecting 
	// death, I wont have to put a script on the one checking for death.
	// Just a mess. Everything is theoretical cus no unity yet...
	void OnTriggerEnter(Collider other){
		if(other.tag == "floor"){
			Kill();
		}
	}
}
