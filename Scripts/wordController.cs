using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class wordController : MonoBehaviour
{
    public wordStore wordstore = null;
	public TextMeshProUGUI final = null;
	private string remaining = string.Empty;
	private string current = string.Empty;
	public int Count = 0;
    void Start()
    {
        SetCurrent();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    public void SetCurrent()
   {
   	current = wordstore.GetWord();
   	SetRemaining(current);
   }
   public void SetRemaining(string newString)
   {
   	remaining = newString;
   	final.text = remaining;
   }

   public void CheckInput()
   {
   	if(Input.anyKeyDown)
   	{
   		string KeyPressed = Input.inputString;
   		if(KeyPressed.Length == 1)
   			EnterLetter(KeyPressed);
   	}
   }
   public void EnterLetter(string typedLetter)
   {
   		if(IsCorrectLetter(typedLetter))
   		{	
   			
   			RemoveLetter();
   			if(IsWordComplete())
   				SetCurrent();
   		}
   		else if(remaining.Length != typedLetter.Length)
   		{
   			Count += 1;
   		}
   		} 
public bool IsCorrectLetter(string letter)
{
	return remaining.IndexOf(letter) == 0;
}

public void RemoveLetter()
{
	string newString = remaining.Remove(0,1);
	final.color = Color.red;
	SetRemaining(newString);
}
public bool IsWordComplete()
{
	return remaining.Length == 0;
}
}
