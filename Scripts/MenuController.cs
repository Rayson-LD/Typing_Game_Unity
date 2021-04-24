using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
	public AudioSource buttonSound;
	public GameObject GamePanel;
	public GameObject QuitPanel;
	public GameObject InfoPanel;
	public bool isMuted;
	public bool isOn = false;
	public Sprite AudioOff;
	public Sprite AudioOn;
	public Image AudioToggle;
    // Start is called before the first frame update
    public void Awake()
    {
    	buttonSound.Pause();
    	isMuted = false;
        GamePanel.SetActive(false);
        QuitPanel.SetActive(false);
        InfoPanel.SetActive(false);
        AudioToggle.sprite = AudioOn;
    }

    public void OnPlay()
    {
    	GamePanel.SetActive(true);
    }
    public void OnGameExit()
    {
    	GamePanel.SetActive(false);
    	
    }
    public void OnQuit()
    {
    	QuitPanel.SetActive(true);
    }
    public void OnYes()
    {
    	Application.Quit();
    }
    public void OnNo()
    {
    	QuitPanel.SetActive(false);
    }
    public void OnInfo()
    {
    	 InfoPanel.SetActive(true);
    }
    public void OnInfoExit()
    {
    	InfoPanel.SetActive(false);
    }
    public void OnSound()
    {
    	
    	isMuted = !isMuted;
    	AudioListener.pause = isMuted;
    	
    }
    public void sprite()
    {
    	isOn = !isOn;
    	if (isOn == true)
    	AudioToggle.sprite = AudioOff;

    	else
    	AudioToggle.sprite = AudioOn;
    }
    public void click()
{
	buttonSound.Play();
}
public void facebook()
 {
     Application.OpenURL ("https://www.facebook.com/officialsmvitm/");
 }
 public void twitter()
 {
     Application.OpenURL ("https://twitter.com/SmvitM?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor");
 }
 public void mail()
 {
     Application.OpenURL ("https://sode-edu.in/contact-us/");
 }
}
