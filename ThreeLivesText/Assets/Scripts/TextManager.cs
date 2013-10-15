using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TextManager : MonoBehaviour {
	public TextMesh TextItemPrefab;
	public Transform TextRoot;
	
	public ItemTable Items;
	
	int CurrentCharacterCount;
	int CurrentLineCount;
	
	void Awake(){
		World.Instance.TextControl = this;
		Items.Initialize();
	}
	
	public void CreateText(string Text){
		TextMesh TextItem = (TextMesh)Instantiate(TextItemPrefab);
		TextItem.transform.parent = TextRoot;
		TextItem.transform.localPosition = Vector3.zero;
//		TextItem.transform.localPosition = 
//			new Vector3(
//				(float)(CurrentCharacterCount % 42) * 2f,
//				-(CurrentCharacterCount/42) * 2f,
//				0
//			);
		TextItem.text = WordWrap(Text, 42, 14);
		//CurrentCharacterCount += Text.Length;
	}
	
	private string WordWrap(string InputString, int LineLength, int LineHeight){
		string[] Words = InputString.Split(' ');
		StringBuilder CurrentLine = new StringBuilder();
		StringBuilder StringBuild = new StringBuilder();
		
		CurrentLineCount = 0;
		CurrentCharacterCount = 0;
		foreach(string Word in Words){
			if(CurrentLine.Length > LineLength){
				//Append CurrentLine into the Build
				StringBuild.AppendLine(CurrentLine.ToString());
				//Clear, and set the CurrentLine with the remaining Word
				CurrentLine.Clear();
				CurrentLineCount++;
				CurrentCharacterCount = 0;
			}
			string NewWord = Word;
			if(Word.Contains("<Item>")){
				NewWord = Word.Replace("<Item>", "");
				CreateItem(NewWord);
			}
			CurrentLine.Append(NewWord);
			CurrentLine.Append(" ");
			CurrentCharacterCount = CurrentLine.Length;
			
			//temp
			if(CurrentLineCount > LineHeight) return StringBuild.ToString();
		}
		//Append Final CurrentLine
		StringBuild.AppendLine(CurrentLine.ToString());
		
		return StringBuild.ToString();
	}
	
	void CreateItem(string InputString){
		//string TagName = InputString.Replace("<Item>", "").Replace("</Item>", "");
		GameObject InstantiatedItem = (GameObject)Instantiate(Items.ItemDictionary[InputString]);
		InstantiatedItem.transform.parent = TextRoot;
		print (CurrentCharacterCount + " " + CurrentLineCount);
		InstantiatedItem.transform.localPosition =
			new Vector3(
				CurrentCharacterCount * (18.5f/6f),
				CurrentLineCount * -11.5f,
				-1f
			);
	}
}

public static class StringBuilderExtension{
	/// <summary>
	///     Clears the contents of the string builder.
	/// </summary>
	/// <param name="value">
	///     The <see cref="StringBuilder"/> to clear.
	/// </param>
	public static void Clear(this StringBuilder value){
	    value.Length = 0;
	    value.Capacity = 0;
		value.Capacity = 16;
	}
}


