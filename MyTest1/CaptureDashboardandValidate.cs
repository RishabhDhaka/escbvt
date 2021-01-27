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
    ///The CaptureDashboardandValidate recording.
    /// </summary>
    [TestModule("d857f227-a2d9-4b4c-b9e2-47acd2a173da", ModuleType.Recording, 1)]
    public partial class CaptureDashboardandValidate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static CaptureDashboardandValidate instance = new CaptureDashboardandValidate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CaptureDashboardandValidate()
        {
            WaterSensorTile = "Water Sensor1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CaptureDashboardandValidate Instance
        {
            get { return instance; }
        }

#region Variables

        string _WaterSensorTile;

        /// <summary>
        /// Gets or sets the value of variable WaterSensorTile.
        /// </summary>
        [TestVariable("be94518c-3d6b-4513-a71b-1b26847b91c9")]
        public string WaterSensorTile
        {
            get { return _WaterSensorTile; }
            set { _WaterSensorTile = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.AccountSettingBtn' at Center", repo.ComPentairPentairhome.AccountSettingBtnInfo, new RecordItemIndex(0));
                repo.ComPentairPentairhome.AccountSettingBtn.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Log Out'. Associated repository item: 'ComPentairPentairhome.LogOut'", repo.ComPentairPentairhome.LogOutInfo, new RecordItemIndex(2));
                repo.ComPentairPentairhome.LogOutInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Log Out");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.LogOut' at Center", repo.ComPentairPentairhome.LogOutInfo, new RecordItemIndex(3));
                repo.ComPentairPentairhome.LogOut.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(4));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.PopUpLogout' at Center", repo.ComPentairPentairhome.PopUpLogoutInfo, new RecordItemIndex(5));
                repo.ComPentairPentairhome.PopUpLogout.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(6));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set value", "(Optional Action)\r\nSetting attribute Text to 'qatestesc1@mailinator.com' on item 'ComPentairPentairhome.LoginEmailTextField'.", repo.ComPentairPentairhome.LoginEmailTextFieldInfo, new RecordItemIndex(7));
                repo.ComPentairPentairhome.LoginEmailTextField.Element.SetAttributeValue("Text", "qatestesc1@mailinator.com");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch gestures", "(Optional Action)\r\nSwipe gesture with direction 'Up (270°)' starting from 'Center' with distance '250' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.EnterYourEmailToGetStarted'.", repo.ComPentairPentairhome.EnterYourEmailToGetStartedInfo, new RecordItemIndex(8));
                repo.ComPentairPentairhome.EnterYourEmailToGetStarted.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "250"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.GetStartedBtnLogin' at Center", repo.ComPentairPentairhome.GetStartedBtnLoginInfo, new RecordItemIndex(9));
                repo.ComPentairPentairhome.GetStartedBtnLogin.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.GetStartedBtnLogin' at Center", repo.ComPentairPentairhome.GetStartedBtnLoginInfo, new RecordItemIndex(10));
                repo.ComPentairPentairhome.GetStartedBtnLogin.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Password'. Associated repository item: 'ComPentairPentairhome.SignInPasswordField'", repo.ComPentairPentairhome.SignInPasswordFieldInfo, new RecordItemIndex(11));
                repo.ComPentairPentairhome.SignInPasswordFieldInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Password");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set value", "(Optional Action)\r\nSetting attribute Text to 'Pentair123@' on item 'ComPentairPentairhome.SignInPasswordField'.", repo.ComPentairPentairhome.SignInPasswordFieldInfo, new RecordItemIndex(12));
                repo.ComPentairPentairhome.SignInPasswordField.Element.SetAttributeValue("Text", "Pentair123@");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s to exist. Associated repository item: 'ComPentairPentairhome.SignIn'", repo.ComPentairPentairhome.SignInInfo, new ActionTimeout(5000), new RecordItemIndex(13));
                repo.ComPentairPentairhome.SignInInfo.WaitForExists(5000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.SignIn' at Center", repo.ComPentairPentairhome.SignInInfo, new RecordItemIndex(14));
                repo.ComPentairPentairhome.SignIn.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.SignIn' at Center", repo.ComPentairPentairhome.SignInInfo, new RecordItemIndex(15));
                repo.ComPentairPentairhome.SignIn.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 15s.", new RecordItemIndex(16));
                Delay.Duration(15000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value $WaterSensorTile. Associated repository item: 'ComPentairPentairhome.WaterSensor1'", repo.ComPentairPentairhome.WaterSensor1Info, new RecordItemIndex(17));
                repo.ComPentairPentairhome.WaterSensor1Info.WaitForAttributeEqual(5000, "AccessibilityLabel", WaterSensorTile);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.WaterTemp' at Center", repo.ComPentairPentairhome.WaterTempInfo, new RecordItemIndex(18));
            repo.ComPentairPentairhome.WaterTemp.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(19));
            Delay.Duration(3000, false);
            
            try {
                //Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Water Sensor'. Associated repository item: 'ComPentairPentairhome.WaterSensor'", repo.ComPentairPentairhome.WaterSensorInfo, new RecordItemIndex(20));
                //repo.ComPentairPentairhome.WaterSensorInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Water Sensor");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "SensorDashboard", repo.ComPentairPentairhome.SensorDashboard, false, new RecordItemIndex(21));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(22));
            repo.ComPentairPentairhome.HomeIcon.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}