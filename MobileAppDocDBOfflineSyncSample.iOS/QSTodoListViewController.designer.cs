// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using System.Threading.Tasks;
using UIKit;
using System.CodeDom.Compiler;

namespace MobileAppDocDBOfflineSyncSample.iOS
{
	[Register ("QSTodoListViewController")]
	public partial class QSTodoListViewController
	{
		[Outlet]
		UIKit.UITextField itemText { get; set; }

		[Action("OnAdd:")]
		[GeneratedCode("iOS Designer", "1.0")]
		partial void OnAdd(UIButton sender);

		void ReleaseDesignerOutlets ()
		{
		}
	}
}
