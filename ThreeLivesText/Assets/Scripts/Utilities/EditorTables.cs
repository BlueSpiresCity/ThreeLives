using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item{
	public string TagName;
	public GameObject ItemObject;
}

[System.Serializable]
public class ItemTable{
	public Item[] Table;
	public Dictionary<string, GameObject> ItemDictionary;
	
	public void Initialize(){
		ItemDictionary = new Dictionary<string, GameObject>();
		foreach(Item Element in Table){
			ItemDictionary.Add(Element.TagName, Element.ItemObject);
		}
	}
}
