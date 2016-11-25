using UnityEngine;
using System.Collections;
using UniRx;

public class FBControllerBase<T> : ControllerBase<T>
	where T: Singleton<T>, new()
{

	public override void Attach (ViewModelBase viewModel)
	{
		UnityEngine.Debug.Log ("FBControllerBase.Attach");

		FBViewModel vm = (FBViewModel)viewModel;

		
		vm.RC_FBTestCMD.Subscribe (_ => {
			FBTestCMD ((FBViewModel)viewModel);
		});
	}

	
	/*  */
	public virtual void FBTestCMD (FBViewModel viewModel)
	{
	}
}