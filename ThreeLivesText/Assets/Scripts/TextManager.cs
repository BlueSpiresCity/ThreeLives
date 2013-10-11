using UnityEngine;
using System.Collections;
using System.Text;

public class TextManager : MonoBehaviour {
	public TextMesh TextItemPrefab;
	public Transform TextRoot;
	
	int CurrentCharacterCount;
	
	void Awake(){
		World.Instance.TextControl = this;
	}
	
	public void CreateText(string Text){
		TextMesh TextItem = (TextMesh)Instantiate(TextItemPrefab);
		TextItem.transform.parent = TextRoot;
		TextItem.transform.localPosition = 
			new Vector3(
				(float)(CurrentCharacterCount % 42) * 2f,
				-(CurrentCharacterCount/42) * 2f,
				0
			);
		TextItem.text = Text;
		CurrentCharacterCount += Text.Length;
	}
	
	//string ProcessText(string Text, int LineLength){
		// Wrap text by line height
	private string ResolveTextSize(string input, int lineLength){
		// Split string by char " "    
		string[] words = input.Split(" "[0]);
	  // Prepare result
	  string result = "";
	 
	  // Temp line string
	  string line = "";
	 
	  // for each all words     
	  foreach(string s in words){
	    // Append current word into line
	    string temp = line + " " + s;
	 
	    // If line length is bigger than lineLength
	    if(temp.Length > lineLength){
	 
	      // Append current line into result
	      result += line + "\n";
	      // Remain word append into new line
	      line = s;
	    }
	    // Append current word into current line
	    else {
	      line = temp;
	    }
	  }
	 
	   // Append last line into result   
	   result += line;
	 
	   // Remove first " " char
	   return result.Substring(1,result.Length-1);
	}
}
