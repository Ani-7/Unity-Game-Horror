using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Pause : MonoBehaviour {

	
    public UnityEvent onPause = new UnityEvent();
    public UnityEvent onUnpause = new UnityEvent();
	public UnityEvent onPause2 = new UnityEvent();
    public UnityEvent onUnpause2 = new UnityEvent();

	public GameObject optionsTint;							//Store a reference to the Game Object OptionsTint 
	public GameObject pausePanel;


	//private ShowPanels showPanels;						//Reference to the ShowPanels script used to hide and show UI panels
	private bool isPaused;								//Boolean to check if the game is paused or not
	private StartOptions startScript;					//Reference to the StartButton script
	
	//Awake is called before Start()
	void Awake()
	{
		//Get a component reference to ShowPanels attached to this object, store in showPanels variable
		//showPanels = GetComponent<ShowPanels> ();
		//Get a component reference to StartButton attached to this object, store in startScript variable
		startScript = GetComponent<StartOptions> ();
	}

	// Update is called once per frame
	void Update () {	

   		
     	 //Debug.Log( "Time.timeScale: " + Time.timeScale );
		   

		//Check if the Escape key in Input Manager is down this frame and that game is not paused, and that we're not in main menu
		if (Input.GetKeyDown (KeyCode.Escape) && !isPaused && !startScript.inMainMenu) 
		{
            
			//Call the DoPause function to pause the game
			DoPause();
		} 
		//If the button is pressed and the game is paused and not in main menu
		else if (Input.GetKeyDown (KeyCode.Escape) && isPaused && !startScript.inMainMenu) 
		{
			//Call the UnPause function to unpause the game
			UnPause ();
		}
	
	}


	public void DoPause()
	{
		Debug.Log("pausing");
		//Set isPaused to true
		isPaused = true;
		//Set time.timescale to 0, this will cause animations and physics to stop updating
		Time.timeScale = 0f;
		//call the ShowPausePanel function of the ShowPanels script
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
        //SetSelection(pausePanel);
		Debug.Log("called panel");
		onPause.Invoke();
		onPause2.Invoke();
	}
	/*
	public void ShowPausePanel()
	{
		
		pausePanel.SetActive (true);
		optionsTint.SetActive(true);
        SetSelection(pausePanel);
    }

	//Call this function to deactivate and hide the Pause panel during game play
	public void HidePausePanel()
	{
		
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);

	}
	*/


	public void UnPause()
	{
		//Set isPaused to false
		isPaused = false;
		//Set time.timescale to 1, this will cause animations and physics to continue updating at regular speed
		Time.timeScale = 1f;
		//call the HidePausePanel function of the ShowPanels script
		pausePanel.SetActive (false);
		optionsTint.SetActive(false);
		onUnpause.Invoke();
		onUnpause2.Invoke();
	}


}
