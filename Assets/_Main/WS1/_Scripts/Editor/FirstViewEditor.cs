using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UniRx;

[CustomEditor (typeof(FirstView))]
public class FirstViewElementViewEditor : FirstElementEditor
{
	public FirstView V { get; set; }

	void OnEnable ()
	{
		V = (FirstView)target;

		if (EditorApplication.isPlaying == false) {
			V.CreateViewModel ();
		}
		VM = V.VM;

		CommandParams = new Dictionary<string, string> ();
	}

	public override void VMCopyToJson ()
	{
		V.ViewModelInitValueJson = JsonConvert.SerializeObject ((FirstViewModelBase)VM);
	}
}