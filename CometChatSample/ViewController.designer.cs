// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CometChatSample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BtnLaunchCometChat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton InitializeCometChat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton superhero01 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton superhero02 { get; set; }

        [Action ("BtnLaunchCometChat_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLaunchCometChat_TouchUpInside (UIKit.UIButton sender);

        [Action ("InitializeCometChat_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void InitializeCometChat_TouchUpInside (UIKit.UIButton sender);

        [Action ("Superhero01_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Superhero01_TouchUpInside (UIKit.UIButton sender);

        [Action ("Superhero02_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Superhero02_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (BtnLaunchCometChat != null) {
                BtnLaunchCometChat.Dispose ();
                BtnLaunchCometChat = null;
            }

            if (InitializeCometChat != null) {
                InitializeCometChat.Dispose ();
                InitializeCometChat = null;
            }

            if (superhero01 != null) {
                superhero01.Dispose ();
                superhero01 = null;
            }

            if (superhero02 != null) {
                superhero02.Dispose ();
                superhero02 = null;
            }
        }
    }
}