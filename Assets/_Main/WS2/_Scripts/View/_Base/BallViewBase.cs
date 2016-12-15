using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WS2 {

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using UniRx;

	public class BallViewBase : ViewBase , IBallView
	{
		public BallViewModel VM;

		public BallViewModel Ball {
			get {
				return VM;
			}
		}

		public override ViewModelBase GetViewModel ()
		{
			return VM;
		}

		public override void Initialize (ViewModelBase viewModel)
		{
			if (viewModel != null) {
				VM = (BallViewModel)viewModel;
				VM.AddHostView (ViewModelBase.DefaultViewBaseKey, this);
			} else {
				if (AutoCreateViewModel && VM == null) {
					CreateViewModel ();
				}
			}

			base.Initialize (VM);
		}

		public override void CreateViewModel ()
		{
			if (UseEmptyViewModel || string.IsNullOrEmpty (ViewModelInitValueJson)) {
				VM = new BallViewModel ();
			} else {
				VM = JsonConvert.DeserializeObject<BallViewModel> (ViewModelInitValueJson);
				ViewModelPropertyRef ();
			}
			
			VM.AddHostView (ViewModelBase.DefaultViewBaseKey, this);
		}

		public void ViewModelPropertyRef ()
		{
			
		}

		public override void Bind ()
		{
			base.Bind ();
			
		}

		public override void AfterBind ()
		{
			base.AfterBind ();
		}

		

		
	}

}