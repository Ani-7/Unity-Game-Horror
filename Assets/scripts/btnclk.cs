using UnityEngine;
using System.Collections;

public class btnclk : MonoBehaviour {

	Animator anim;                      
	public AnimationClip Game;
	public string level;

	void Awake(){
		
		anim = GetComponent <Animator> ();

	}

	void LoadDelay()
	{
		Application.LoadLevel (level);
	}
	

	public void changescene ()
	{	
			anim.SetTrigger ("gameS");
			Invoke ("LoadDelay",Game.length*2f);

	}

	void Update()
	{
		if (Input.GetKeyDown ("return")) {
		
			anim.SetTrigger ("gameS");
			Invoke ("LoadDelay",Game.length*2f);
		}
	}
}
