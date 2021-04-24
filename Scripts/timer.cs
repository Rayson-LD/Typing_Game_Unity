using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
	
	public wordController wordControl;
    public float timeRemaining = 0;
    public Text timeText;
     public Text scoreText;
     public Text mistakeText;
     public GameObject scorePanel;
     public float minutes = 0.0f;
     public float seconds = 0.0f;
     
 	bool timeActive = false;
 	public Text BtnText;
 	public void Start()
 	{
 		
 			
 		scorePanel.SetActive(false);
 	
 	}
   public void Update()
   {	
   		wordControl.CheckInput();
   		if(timeActive){
   		timeRemaining += Time.deltaTime;
     	minutes = Mathf.FloorToInt(timeRemaining / 60);
         seconds = Mathf.FloorToInt(timeRemaining % 60);
     	timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
   } 
}
public void Reset()
{
	timeRemaining = 0;
	wordControl.Count = 0;
	scorePanel.SetActive(false);
	
}

public void timerButton()
{
	wordControl.SetCurrent();
	timeActive = !timeActive;
	BtnText.text = timeActive ? "Pause" : "Start";
}
public void Pause()
{
	if (timeActive == false)
	{
		
		scorePanel.SetActive(true);
		scoreText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
		mistakeText.text = string.Format("{0}",wordControl.Count);
	}
}

     
}