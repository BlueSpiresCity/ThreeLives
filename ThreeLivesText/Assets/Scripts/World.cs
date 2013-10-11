using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World{
	#region Singleton Declaration
	private static World InstanceInternal;
	public static World Instance{
		get{
			if (InstanceInternal == null){
				new World();
			}
			return InstanceInternal;
		}
	}
	
	public World(){
		if (InstanceInternal != null){
			Debug.Log("Cannot have two instances of singleton. Make sure new World() is done only once.");
			return;
		}
		InstanceInternal = this;
		Initialize();
	}
	#endregion
	
	//Variables here
	public GameController Master;
	public TextManager TextControl;
	
	//Dictionaries
	public Dictionary<int, TextItem> TextItemTable;
	
	void Initialize(){
		//Initialize Here
		TextItemTable = new Dictionary<int, TextItem>();
	}
}
