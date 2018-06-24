using System;
using cometchatui;
using Foundation;
using MessageSDKFramework;
using UIKit;

namespace CometChatSample
{
    public partial class ViewController : UIViewController
    {
        String siteurl = "";
        String licenseKey = "COMETCHAT-XXXXX-XXXXX-XXXXX-XXXXX"; // Replace the value with your CometChat License Key here
        String apiKey = "xxxxxxxxxxxxxxxxxxxxxx"; // Replace the value with your CometChat API Key here
        Boolean isCometOnDemand = true;
        private String UID1 = "SUPERHERO1";
        private String UID2 = "SUPERHERO2";

        CometChat cometchat;
        readyUIFIle readyUIFile;
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BtnInitializeChat_TouchUpInside(UIButton sender)
        {
            cometchat = new CometChat();
            readyUIFile = new readyUIFIle();
            cometchat.InitializeCometChat(siteurl, licenseKey, apiKey, isCometOnDemand, (dict) => InitSuccess(dict),error => InitFail(error));
        }


        private void InitSuccess(NSDictionary dict)
        {
            if (dict != null)
            {
                Console.WriteLine("Init Success " + dict.ToString());
            }
        }

        private void InitFail(NSError error)
        {
            if (error != null)
            {
                Console.WriteLine("Init Fail " + error.ToString());
            }
        }

        partial void BtnLoginSuperHero1_TouchUpInside(UIButton sender)
        {
            login(UID1);
        }

        partial void BtnLoginSuperHero2_TouchUpInside(UIButton sender)
        {
            login(UID2);
        }

        public void login(String UID)
        {
            cometchat.loginWithUID(UID, (nsdictionary)=>loginsuccess(nsdictionary),(nserror)=>loginfailure(nserror));
        }

        private void loginsuccess(NSDictionary nsdictionary)
        {
            if (nsdictionary != null)
            {
                Console.WriteLine("Login Fail " + nsdictionary.ToString());
            }
        }

        private void loginfailure(NSError nserror)
        {
            if (nserror != null)
            {
                Console.WriteLine("Login Fail " + nserror.ToString());
            }
        }

        partial void BtnLaunchChat_TouchUpInside(UIButton sender)
        {
            readyUIFile.LaunchCometChat(true, this, (userInfo) => OnUserInfo(userInfo),groupInfo=> OnGroupInfo(groupInfo),messageRecieve=>OnMessageRecieve(messageRecieve),launchSuccess=>OnLaunchSuccess(launchSuccess),launchFailure => OnLaunchFailure(launchFailure),onLogout => OnLogout(onLogout));
        }

        private void OnUserInfo(NSDictionary userInfo)
        {
            if (userInfo != null)
            {
                Console.WriteLine("Login Fail " + userInfo.ToString());
            }
        }

        private void OnGroupInfo(NSDictionary groupInfo)
        {
            if (groupInfo != null)
            {
                Console.WriteLine("Login Fail " + groupInfo.ToString());
            }
        }

        private void OnMessageRecieve(NSDictionary messageRecieve)
        {
            if (messageRecieve != null)
            {
                Console.WriteLine("Login Fail " + messageRecieve.ToString());
            }
        }

        private void OnLaunchSuccess(NSDictionary launchSuccess)
        {
            if (launchSuccess != null)
            {
                Console.WriteLine("Login Fail " + launchSuccess.ToString());
            }
        }

        private void OnLaunchFailure(NSError launchFailure)
        {
            if (launchFailure != null)
            {
                Console.WriteLine("Login Fail " + launchFailure.ToString());
            }
        }

        private void OnLogout(NSDictionary onLogout)
        {
            if (onLogout != null)
            {
                Console.WriteLine("Login Fail " + onLogout.ToString());
            }
        }
    }
}
