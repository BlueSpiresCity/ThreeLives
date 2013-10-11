using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TextItem))]
public class TextItemEditor : Editor {
	string StringText;
	float Height = 200f; 
	
	public override void OnInspectorGUI () {
		//default
		base.DrawDefaultInspector();
		Height = EditorGUILayout.FloatField("Text Box Height", Height);
		GUILayout.Label("Enter Text:");
		StringText = EditorGUILayout.TextArea(StringText , GUILayout.Height(Height));
		if(GUILayout.Button("Commit")){
			Commit();
		}
    }
	
	void Commit(){
		TextItem Item = (TextItem)target;
		Item.SetText(StringText);
	}
}
