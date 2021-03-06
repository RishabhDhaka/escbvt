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
    ///The ESC_ProductOverview recording.
    /// </summary>
    [TestModule("ae3b38f4-2e1e-46c7-8943-f0e1f6fdb522", ModuleType.Recording, 1)]
    public partial class ESC_ProductOverview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static ESC_ProductOverview instance = new ESC_ProductOverview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ESC_ProductOverview()
        {
            DeviceId = "Device ID PNR04ESC100002F098";
            CSV_Version = "Controller Software Version 1.17";
            IOT_Software_Version = "IoT Software Version 2.36";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ESC_ProductOverview Instance
        {
            get { return instance; }
        }

#region Variables

        string _DeviceId;

        /// <summary>
        /// Gets or sets the value of variable DeviceId.
        /// </summary>
        [TestVariable("739c99a2-8676-42c2-b259-9e68e57829af")]
        public string DeviceId
        {
            get { return _DeviceId; }
            set { _DeviceId = value; }
        }

        string _CSV_Version;

        /// <summary>
        /// Gets or sets the value of variable CSV_Version.
        /// </summary>
        [TestVariable("864af30a-96f0-400b-a6fb-273a7d1b0183")]
        public string CSV_Version
        {
            get { return _CSV_Version; }
            set { _CSV_Version = value; }
        }

        string _IOT_Software_Version;

        /// <summary>
        /// Gets or sets the value of variable IOT_Software_Version.
        /// </summary>
        [TestVariable("8facdb09-ec35-4a83-be82-c25042949f0d")]
        public string IOT_Software_Version
        {
            get { return _IOT_Software_Version; }
            set { _IOT_Software_Version = value; }
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
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Product Overview'. Associated repository item: 'ComPentairPentairhome.ProductOverview'", repo.ComPentairPentairhome.ProductOverviewInfo, new RecordItemIndex(3));
                repo.ComPentairPentairhome.ProductOverviewInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Product Overview");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.ProductOverview' at Center", repo.ComPentairPentairhome.ProductOverviewInfo, new RecordItemIndex(4));
                repo.ComPentairPentairhome.ProductOverview.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$DeviceId) on item 'ComPentairPentairhome.DeviceIDPNR04ESC100002F098'.", repo.ComPentairPentairhome.DeviceIDPNR04ESC100002F098Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ComPentairPentairhome.DeviceIDPNR04ESC100002F098Info, "AccessibilityLabel", DeviceId, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel=$CSV_Version) on item 'ComPentairPentairhome.ControllerSoftwareVersion117'.", repo.ComPentairPentairhome.ControllerSoftwareVersion117Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.ComPentairPentairhome.ControllerSoftwareVersion117Info, "AccessibilityLabel", CSV_Version, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibilityLabel=$IOT_Software_Version) on item 'ComPentairPentairhome.IoTSoftwareVersion236'.", repo.ComPentairPentairhome.IoTSoftwareVersion236Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ComPentairPentairhome.IoTSoftwareVersion236Info, "AccessibilityLabel", IOT_Software_Version);
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(8));
                repo.ComPentairPentairhome.HomeIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(9));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
