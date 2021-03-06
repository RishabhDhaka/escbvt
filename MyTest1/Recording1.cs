﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("8411d2a9-c9ff-4b56-9bd5-a6ef48f53663", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            Endpoint = "shaliniâ€™s iPhone";
            Startup_argum = "com.pentair.pentairhome";
            Email = "qatestesc2@mailinator.com";
            Password = "Pentair@123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Endpoint;

        /// <summary>
        /// Gets or sets the value of variable Endpoint.
        /// </summary>
        [TestVariable("893e2a53-6ac3-46aa-851f-3aa2a33d479c")]
        public string Endpoint
        {
            get { return _Endpoint; }
            set { _Endpoint = value; }
        }

        string _Startup_argum;

        /// <summary>
        /// Gets or sets the value of variable Startup_argum.
        /// </summary>
        [TestVariable("9bcd30fd-d84c-4a78-b741-4d0c25c2562a")]
        public string Startup_argum
        {
            get { return _Startup_argum; }
            set { _Startup_argum = value; }
        }

        string _Email;

        /// <summary>
        /// Gets or sets the value of variable Email.
        /// </summary>
        [TestVariable("55c0cc50-a809-456b-86b5-c37b4dcc880c")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _Password;

        /// <summary>
        /// Gets or sets the value of variable Password.
        /// </summary>
        [TestVariable("5604995b-cdc7-415b-84f9-617d39e5c1f1")]
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app from variable $Startup_argum on device from variable $Endpoint.", new RecordItemIndex(0));
            Host.Local.RunMobileApp(Endpoint, Startup_argum, false);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SkipafterLaunch' at Center", repo.ComPentairPentairhome.SkipafterLaunchInfo, new RecordItemIndex(2));
            repo.ComPentairPentairhome.SkipafterLaunch.Touch();
            Delay.Milliseconds(300);
            
            //Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SkipafterLaunch' at Center", repo.ComPentairPentairhome.SkipafterLaunchInfo, new RecordItemIndex(3));
            //repo.ComPentairPentairhome.SkipafterLaunch.Touch();
            //Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Email' on item 'ComPentairPentairhome.LoginEmailTextField'.", repo.ComPentairPentairhome.LoginEmailTextFieldInfo, new RecordItemIndex(4));
            repo.ComPentairPentairhome.LoginEmailTextField.Element.SetAttributeValue("Text", Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Get Started'. Associated repository item: 'ComPentairPentairhome.LoginEmailNextButton'", repo.ComPentairPentairhome.LoginEmailNextButtonInfo, new RecordItemIndex(5));
            repo.ComPentairPentairhome.LoginEmailNextButtonInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Get Started");
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.GetStartedBtnLogin' at Center", repo.ComPentairPentairhome.GetStartedBtnLoginInfo, new RecordItemIndex(6));
            repo.ComPentairPentairhome.GetStartedBtnLogin.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.GetStartedBtnLogin' at Center", repo.ComPentairPentairhome.GetStartedBtnLoginInfo, new RecordItemIndex(7));
            repo.ComPentairPentairhome.GetStartedBtnLogin.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Password'. Associated repository item: 'ComPentairPentairhome.SignInPasswordField'", repo.ComPentairPentairhome.SignInPasswordFieldInfo, new RecordItemIndex(8));
            repo.ComPentairPentairhome.SignInPasswordFieldInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Password");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Password' on item 'ComPentairPentairhome.SignInPasswordField'.", repo.ComPentairPentairhome.SignInPasswordFieldInfo, new RecordItemIndex(9));
            repo.ComPentairPentairhome.SignInPasswordField.Element.SetAttributeValue("Text", Password);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ComPentairPentairhome.SignIn'", repo.ComPentairPentairhome.SignInInfo, new ActionTimeout(5000), new RecordItemIndex(10));
            repo.ComPentairPentairhome.SignInInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SignIn' at Center", repo.ComPentairPentairhome.SignInInfo, new RecordItemIndex(11));
            repo.ComPentairPentairhome.SignIn.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.SignIn' at Center", repo.ComPentairPentairhome.SignInInfo, new RecordItemIndex(12));
            repo.ComPentairPentairhome.SignIn.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(13));
            Delay.Duration(15000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
