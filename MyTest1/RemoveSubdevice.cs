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
    ///The RemoveSubdevice recording.
    /// </summary>
    [TestModule("5c425dc1-d7f6-407b-a3c7-a15d7ba4bef0", ModuleType.Recording, 1)]
    public partial class RemoveSubdevice : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static RemoveSubdevice instance = new RemoveSubdevice();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveSubdevice()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveSubdevice Instance
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
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.Validate_IntellisyncAUTO' at Center", repo.ComPentairPentairhome.Validate_IntellisyncAUTOInfo, new RecordItemIndex(0));
                repo.ComPentairPentairhome.Validate_IntellisyncAUTO.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.DeviceImage' at Center", repo.ComPentairPentairhome.DeviceImageInfo, new RecordItemIndex(1));
                repo.ComPentairPentairhome.DeviceImage.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "ESCdashboardWithAllSubdevice", repo.ComPentairPentairhome.IntellisyncModeAutoEquipment1234, false, new RecordItemIndex(3));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Air Sensor'. Associated repository item: 'ComPentairPentairhome.AirSensor1'", repo.ComPentairPentairhome.AirSensor1Info, new RecordItemIndex(4));
                repo.ComPentairPentairhome.AirSensor1Info.WaitForAttributeEqual(5000, "AccessibilityLabel", "Air Sensor");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.AirSensor1' at Center", repo.ComPentairPentairhome.AirSensor1Info, new RecordItemIndex(5));
                repo.ComPentairPentairhome.AirSensor1.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HeaderRightImage' at Center", repo.ComPentairPentairhome.HeaderRightImageInfo, new RecordItemIndex(6));
                repo.ComPentairPentairhome.HeaderRightImage.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Remove Equipment'. Associated repository item: 'ComPentairPentairhome.RemoveEquipment'", repo.ComPentairPentairhome.RemoveEquipmentInfo, new RecordItemIndex(7));
                repo.ComPentairPentairhome.RemoveEquipmentInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Remove Equipment");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibilityLabel='Remove Equipment') on item 'ComPentairPentairhome.RemoveEquipment'.", repo.ComPentairPentairhome.RemoveEquipmentInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.ComPentairPentairhome.RemoveEquipmentInfo, "AccessibilityLabel", "Remove Equipment", null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.RemoveEquipment' at Center", repo.ComPentairPentairhome.RemoveEquipmentInfo, new RecordItemIndex(9));
                repo.ComPentairPentairhome.RemoveEquipment.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'REMOVE'. Associated repository item: 'ComPentairPentairhome.REMOVE'", repo.ComPentairPentairhome.REMOVEInfo, new RecordItemIndex(10));
                repo.ComPentairPentairhome.REMOVEInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "REMOVE");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.REMOVE' at Center", repo.ComPentairPentairhome.REMOVEInfo, new RecordItemIndex(11));
                repo.ComPentairPentairhome.REMOVE.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(12));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Screenshot(ReportLevel.Info, "User", "DeviceRemovedSuccess", repo.ComPentairPentairhome.IntellisyncModeAutoEquipment123In, false, new RecordItemIndex(13));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(14));
                repo.ComPentairPentairhome.HomeIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(15));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}