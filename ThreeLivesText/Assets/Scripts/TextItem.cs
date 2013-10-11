using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TextItem : MonoBehaviour {	
	TextMesh ThisTextMesh;
	
	void Awake(){
		World.Instance.TextItemTable.Add(GetInstanceID(), this);
		ThisTextMesh = GetComponent<TextMesh>();
	}
	
	public void SetText(string Text){
		ThisTextMesh.text = Text;
	}
}
