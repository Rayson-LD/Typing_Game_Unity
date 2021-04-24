using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class wordStore : MonoBehaviour
{
	private List<string> originalWords = new List<string>()
	{
		"Pancakes","Are","Delicious","far", "to", "life", "eye", "follow","so", "page", 
		"new", "sometimes", "been", "together", "or", "number", "go", "page", "set", "feet", 
		"now", "page", "every", "under", "most", "as", "help","up", "all", "if","got", "below", 
		"watch", "name", "little", "make", "more", "year", "take", "there","something","which", 
		"do", "car", "help", "black", "tree", "land", "still", "much", "four", "any","without","we", 
		"even","began","there","end","food","with","might","line","later", "begin", "you", 
		"really","these","fall","and","help", "few", "for","at","you","from", "was", "only",
		 "one","move","talk","like","and","eye","around", "its", "carry", "thought", "head", "something", 
		 "night", "people", "left", "under", "way", "say", "air", "fall", "both", "another", "school", "land", "is", "could",
		  "sound", "miss","if", "run", "your", "upon", "head", "father", "mother", "read", "us","around", "above", "about", 
		  "us", "good", "still", "father", "they", "with", "walk", "number", "us", "learn", "open","watch", "walk", "that", 
		  "other", "seem", "do", "part","by", "different", "ask","her", "said", "such", "different", "out", "river", "hard", 
		  "paper", "made", "there", "go", "his", "thought", "city", "at", "read", "use", "need", "word", "under","girl", 
		  "letter", "car", "try", "high"
	};
	private List<string> workingWords = new List<string>();
    // Start is called before the first frame update
    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConverToLower(workingWords);
    }

    private void Shuffle(List<string> list)
    {
    	for(int i=0;i< list.Count; i++)
    	{
    		int random = Random.Range(i, list.Count);
    		string temporary = list[i];
    		list[i] = list[random];
    		list[random] = temporary;
    	}
    }
    private void ConverToLower(List<string> list)
    {
    	for (int i=0;i < list.Count; i++)
    		list[i] = list[i].ToLower();
    }
    public string GetWord()
    {
    	string newWord = string.Empty;
    	if(workingWords.Count != 0)
    	{
    		newWord = workingWords.Last();
    		workingWords.Remove(newWord);
    	}
    	return newWord;
    }
}
