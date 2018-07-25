using System;
using CometChatBinding;
using CometChatUI;
using Firebase.Auth;
using Firebase.Core;
using Firebase.Database;
using Foundation;
using Plugin.FirebasePushNotification;
using UIKit;

namespace CometChatSample
{
    public partial class ViewController : UIViewController
    {
        CometChat cometchat;
        readyUIFIle readyUIFile;
        String siteurl = "";
        String licenseKey = "COMETCHAT-XXXXX-XXXXX-XXXX-XXXXX"; // Replace the value with your CometChat License Key here
        String apiKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxx"; // Replace the value with your CometChat API Key here
        Boolean isCometOnDemand = true;
        private String UID1 = "SUPERHERO1";
        private String UID2 = "SUPERHERO2";

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

        partial void InitializeCometChat_TouchUpInside(UIButton sender)
        {
            cometchat = new CometChat();
            readyUIFile = new readyUIFIle();
            User user = Auth.DefaultInstance.CurrentUser;
            Database database = Database.DefaultInstance;
            CrossFirebasePushNotification.Current.Subscribe("ScaredGames");
            CrossFirebasePushNotification.Current.OnNotificationReceived += (s, p) =>
            {
                

            };
         
            cometchat.InitializeCometChat(siteurl, licenseKey, apiKey, isCometOnDemand, (dict) => InitSuccess(dict),error => InitFail(error));
       
            
        }

        private void InitSuccess(NSDictionary dict)
        {
            if (dict != null)
            {
                Console.WriteLine("Init Success " + dict.ToString());
                superhero01.Hidden = false;
                superhero02.Hidden = false;
                superhero01.Enabled = true;
                superhero02.Enabled = true;
            }
        }

        private void InitFail(NSError error)
        {
            if (error != null)
            {
                Console.WriteLine("Init Fail " + error.ToString());
                superhero01.Enabled = false;
                superhero02.Enabled = false;
            }
        }

        partial void Superhero01_TouchUpInside(UIButton sender)
        {
            login(UID1);
        }

        partial void Superhero02_TouchUpInside(UIButton sender)
        {
            login(UID2);
        }
        public void login(String UID)
        {
            cometchat.LoginWithUID(UID, (nsdictionary) => loginsuccess(nsdictionary), (nserror) => loginfailure(nserror));
        }
        private void loginsuccess(NSDictionary nsdictionary)
        {
            if (nsdictionary != null)
            {
                Console.WriteLine("Login Success " + nsdictionary.ToString());
                BtnLaunchCometChat.Enabled = true;
                BtnLaunchCometChat.Hidden = false;
            }
        }

        private void loginfailure(NSError nserror)
        {
            if (nserror != null)
            {
                Console.WriteLine("Login Fail " + nserror.ToString());
                BtnLaunchCometChat.Enabled = false;
                BtnLaunchCometChat.Hidden = true;
            }
        }

        partial void BtnLaunchCometChat_TouchUpInside(UIButton sender)
        {
            readyUIFile.LaunchCometChat(true, this, (userInfo) => OnUserInfo(userInfo), groupInfo => OnGroupInfo(groupInfo), messageRecieve => OnMessageRecieve(messageRecieve), launchSuccess => OnLaunchSuccess(launchSuccess), launchFailure => OnLaunchFailure(launchFailure), onLogout => OnLogout(onLogout));
        }

        private void OnUserInfo(NSDictionary userInfo)
        {
            if (userInfo != null)
            {
                Console.WriteLine("OnUserInfo " + userInfo.ToString());
                String push_channel = (userInfo["push_channel"] as NSString);
                Console.WriteLine("push_channel "+push_channel);
                CrossFirebasePushNotification.Current.Subscribe(push_channel);
            }
        }

        private void OnGroupInfo(NSDictionary groupInfo)
        {
            if (groupInfo != null)
            {
                Console.WriteLine("OnGroupInfo " + groupInfo.ToString());
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
                Console.WriteLine("OnLaunchSuccess " + launchSuccess.ToString());
            }
        }

        private void OnLaunchFailure(NSError launchFailure)
        {
            if (launchFailure != null)
            {
                Console.WriteLine("OnLaunchFailure " + launchFailure.ToString());
            }
        }

        private void OnLogout(NSDictionary onLogout)
        {
            if (onLogout != null)
            {
                Console.WriteLine("OnLogout " + onLogout.ToString());
            }
        }
    }
}
