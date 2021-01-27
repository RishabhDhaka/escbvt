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
    ///The ESC_Setting recording.
    /// </summary>
    [TestModule("4256b6ce-2aaf-4063-b2a2-e8765dc64721", ModuleType.Recording, 1)]
    public partial class ESC_Setting : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static ESC_Setting instance = new ESC_Setting();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ESC_Setting()
        {
            ESCSettingTile1 = "Product Overview";
            ESCSettingTile2 = "Notifications";
            ESCSettingTile3 = "Product Support";
            ESCSettingTile4 = "Contact a Professional";
            ESCSettingTile5 = "Remote Monitoring";
            ESCSettingTile6 = "WiFi";
            ESCSettingTile7 = "Remove Device";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ESC_Setting Instance
        {
            get { return instance; }
        }

#region Variables

        string _ESCSettingTile1;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile1.
        /// </summary>
        [TestVariable("1360e867-9dd9-4d7e-9963-56e9318b77e2")]
        public string ESCSettingTile1
        {
            get { return _ESCSettingTile1; }
            set { _ESCSettingTile1 = value; }
        }

        string _ESCSettingTile2;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile2.
        /// </summary>
        [TestVariable("7c2439de-2905-43e0-9622-0dbfcebab538")]
        public string ESCSettingTile2
        {
            get { return _ESCSettingTile2; }
            set { _ESCSettingTile2 = value; }
        }

        string _ESCSettingTile3;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile3.
        /// </summary>
        [TestVariable("ec51c30a-c006-4fc0-9b68-f286be8da2db")]
        public string ESCSettingTile3
        {
            get { return _ESCSettingTile3; }
            set { _ESCSettingTile3 = value; }
        }

        string _ESCSettingTile4;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile4.
        /// </summary>
        [TestVariable("5fde7828-4528-4fa8-8f30-8b865e393c0b")]
        public string ESCSettingTile4
        {
            get { return _ESCSettingTile4; }
            set { _ESCSettingTile4 = value; }
        }

        string _ESCSettingTile5;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile5.
        /// </summary>
        [TestVariable("5f3fb49e-2486-48d9-890a-addc79b82c13")]
        public string ESCSettingTile5
        {
            get { return _ESCSettingTile5; }
            set { _ESCSettingTile5 = value; }
        }

        string _ESCSettingTile6;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile6.
        /// </summary>
        [TestVariable("a88564dc-af65-40ad-84db-92caada4db0a")]
        public string ESCSettingTile6
        {
            get { return _ESCSettingTile6; }
            set { _ESCSettingTile6 = value; }
        }

        string _ESCSettingTile7;

        /// <summary>
        /// Gets or sets the value of variable ESCSettingTile7.
        /// </summary>
        [TestVariable("ca107a4e-d8d4-472e-ae77-a6c25936c765")]
        public string ESCSettingTile7
        {
            get { return _ESCSettingTile7; }
            set { _ESCSettingTile7 = value; }
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
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.Validate_IntellisyncAUTO' at Center", repo.ComPentairPentairhome.Validate_IntellisyncAUTOInfo, new RecordItemIndex(0));
                repo.ComPentairPentairhome.Validate_IntellisyncAUTO.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.ESCsettingGearIcon' at Center", repo.ComPentairPentairhome.ESCsettingGearIconInfo, new RecordItemIndex(1));
                repo.ComPentairPentairhome.ESCsettingGearIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(2));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "ESCsetting", repo.ComPentairPentairhome.IntellisyncProductOverviewNotificatio, false, new RecordItemIndex(3));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile1) on item 'ComPentairPentairhome.ProductOverview'.", repo.ComPentairPentairhome.ProductOverviewInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.ComPentairPentairhome.ProductOverviewInfo, "AccessibilityLabel", ESCSettingTile1, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile2) on item 'ComPentairPentairhome.Notifications'.", repo.ComPentairPentairhome.NotificationsInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ComPentairPentairhome.NotificationsInfo, "AccessibilityLabel", ESCSettingTile2, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile3) on item 'ComPentairPentairhome.ProductSupport'.", repo.ComPentairPentairhome.ProductSupportInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.ComPentairPentairhome.ProductSupportInfo, "AccessibilityLabel", ESCSettingTile3, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile4) on item 'ComPentairPentairhome.ContactAProfessional'.", repo.ComPentairPentairhome.ContactAProfessionalInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.ComPentairPentairhome.ContactAProfessionalInfo, "AccessibilityLabel", ESCSettingTile4, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile5) on item 'ComPentairPentairhome.RemoteMonitoring'.", repo.ComPentairPentairhome.RemoteMonitoringInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.ComPentairPentairhome.RemoteMonitoringInfo, "AccessibilityLabel", ESCSettingTile5, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile6) on item 'ComPentairPentairhome.WiFi'.", repo.ComPentairPentairhome.WiFiInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.ComPentairPentairhome.WiFiInfo, "AccessibilityLabel", ESCSettingTile6, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$ESCSettingTile7) on item 'ComPentairPentairhome.RemoveDevice'.", repo.ComPentairPentairhome.RemoveDeviceInfo, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.ComPentairPentairhome.RemoveDeviceInfo, "AccessibilityLabel", ESCSettingTile7, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(11));
                repo.ComPentairPentairhome.HomeIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(12));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
