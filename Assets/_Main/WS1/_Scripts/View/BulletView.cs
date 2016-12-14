using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UniRx;
using PogoTools;

public class BulletView : BulletViewBase
{
	public override void Initialize (ViewModelBase viewModel)
	{
		base.Initialize (viewModel);
	}

	public override void Bind ()
	{
		base.Bind ();
		Debug.Log (string.Format ("BulletView in {0} Bind.", gameObject.name));
	}

	public override void AfterBind ()
	{
		base.AfterBind ();
		Debug.Log (string.Format ("BulletView in {0} AfterBind.", gameObject.name));
	}
}
