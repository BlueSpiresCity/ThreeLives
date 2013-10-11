using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	TextManager TextControl;
	
	void Awake(){
		//Create a New World!
		new World();
		//AND DECLARE ITS MASTER!
		World.Instance.Master = this;
	}
	
	void Start () {
		TextControl = World.Instance.TextControl;
		TextControl.CreateText("1HelloTHEREHOWTYOUHOAVNEONVOEINV");
		TextControl.CreateText("2YEAAAAAAAAAAAAAAAAAAAAAAAAH!");
		TextControl.CreateText("3HelloTHEREHOWTYOUHOAVNEONVOEINV");
		TextControl.CreateText("4YEAAAAAAAAAAAAAAAAAAAAAAAAH!");
		TextControl.CreateText("5HelloTHEREHOWTYOUHOAVNEONVOEINV");
		TextControl.CreateText("6YEAAAAAAAAAAAAAAAAAAAAAAAAH!");
		TextControl.CreateText("7HelloTHEREHOWTYOUHOAVNEONVOEINV");
		TextControl.CreateText("8YEAAAAAAAAAAAAAAAAAAAAAAAAH!");
		TextControl.CreateText("9HelloTHEREHOWTYOUHOAVNEONVOEINV");
		TextControl.CreateText("10YEAAAAAAAAAAAAAAAAAAAAAAAAH!");
	}

	void Update () {
		
	}
}
