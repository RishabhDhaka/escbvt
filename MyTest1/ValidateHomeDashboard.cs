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
    ///The ValidateHomeDashboard recording.
    /// </summary>
    [TestModule("812a1a96-ace9-4798-b674-dd0c0a011a92", ModuleType.Recording, 1)]
    public partial class ValidateHomeDashboard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static ValidateHomeDashboard instance = new ValidateHomeDashboard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHomeDashboard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateHomeDashboard Instance
        {
            get { return instance; }
        }

#region Variables

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
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Add a Device Status Everything OK intellisync AUTO IntelliFlo VS Pump OFF Water Sensor Water Temp:  -- SuperFlo/Max VS OFF Air Sensor Air Temp:  -- Vertical scroll bar, 2 pages Horizontal scroll bar, 1 page') on item 'ComPentairPentairhome.Validate_IntellisyncAUTO'.", repo.ComPentairPentairhome.Validate_IntellisyncAUTOInfo, new RecordItemIndex(0));
                //Validate.AttributeEqual(repo.ComPentairPentairhome.Validate_IntellisyncAUTOInfo, "AccessibilityLabel", "Add a Device Status Everything OK intellisync AUTO IntelliFlo VS Pump OFF Water Sensor Water Temp:  -- SuperFlo/Max VS OFF Air Sensor Air Temp:  -- Vertical scroll bar, 2 pages Horizontal scroll bar, 1 page", null, false);
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='assets/src/Common_Feature/Images/menu@2x.png') on item 'ComPentairPentairhome.AccountSettingBtn'.", repo.ComPentairPentairhome.AccountSettingBtnInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.ComPentairPentairhome.AccountSettingBtnInfo, "AccessibilityLabel", "assets/src/Common_Feature/Images/menu@2x.png", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='assets/src/Common_Feature/Images/inquiry@2x.png') on item 'ComPentairPentairhome.AssetsSrcCommonFeatureImagesInquiry'.", repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesInquiryInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesInquiryInfo, "AccessibilityLabel", "assets/src/Common_Feature/Images/inquiry@2x.png", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='assets/src/Common_Feature/Images/whiteLogo@2x.png') on item 'ComPentairPentairhome.AssetsSrcCommonFeatureImagesWhiteLo'.", repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesWhiteLoInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.ComPentairPentairhome.AssetsSrcCommonFeatureImagesWhiteLoInfo, "AccessibilityLabel", "assets/src/Common_Feature/Images/whiteLogo@2x.png", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Status Everything OK') on item 'ComPentairPentairhome.StatusEverythingOK'.", repo.ComPentairPentairhome.StatusEverythingOKInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.ComPentairPentairhome.StatusEverythingOKInfo, "AccessibilityLabel", "Status Everything OK", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Add a Device') on item 'ComPentairPentairhome.AddADevice1'.", repo.ComPentairPentairhome.AddADevice1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ComPentairPentairhome.AddADevice1Info, "AccessibilityLabel", "Add a Device", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(6));
            Delay.Duration(4000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Touch gestures", "(Optional Action)\r\nSwipe gesture with direction 'Up (270°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.AddADeviceStatusEverythingOKIntell'.", repo.ComPentairPentairhome.AddADeviceStatusEverythingOKIntellInfo, new RecordItemIndex(7));
                repo.ComPentairPentairhome.AddADeviceStatusEverythingOKIntell.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Schedule') on item 'ComPentairPentairhome.Schedule1'.", repo.ComPentairPentairhome.Schedule1Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.ComPentairPentairhome.Schedule1Info, "AccessibilityLabel", "Schedule", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Alerts') on item 'ComPentairPentairhome.Alerts1'.", repo.ComPentairPentairhome.Alerts1Info, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.ComPentairPentairhome.Alerts1Info, "AccessibilityLabel", "Alerts", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Devices') on item 'ComPentairPentairhome.Devices'.", repo.ComPentairPentairhome.DevicesInfo, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.ComPentairPentairhome.DevicesInfo, "AccessibilityLabel", "Devices", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 2s.", new RecordItemIndex(11));
                Delay.Duration(2000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}