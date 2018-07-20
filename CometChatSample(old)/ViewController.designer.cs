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
        UIKit.UIButton btnInitializeChat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLaunchChat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLoginSuperHero1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLoginSuperHero2 { get; set; }

        [Action ("BtnInitializeChat_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnInitializeChat_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLaunchChat_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLaunchChat_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLoginSuperHero1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLoginSuperHero1_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLoginSuperHero2_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLoginSuperHero2_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnInitializeChat != null) {
                btnInitializeChat.Dispose ();
                btnInitializeChat = null;
            }

            if (btnLaunchChat != null) {
                btnLaunchChat.Dispose ();
                btnLaunchChat = null;
            }

            if (btnLoginSuperHero1 != null) {
                btnLoginSuperHero1.Dispose ();
                btnLoginSuperHero1 = null;
            }

            if (btnLoginSuperHero2 != null) {
                btnLoginSuperHero2.Dispose ();
                btnLoginSuperHero2 = null;
            }
        }
    }
}