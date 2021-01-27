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
    ///The CreatePool recording.
    /// </summary>
    [TestModule("5b6dfed3-eeab-4b5e-9d30-d4324a3b4b99", ModuleType.Recording, 1)]
    public partial class CreatePool : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static CreatePool instance = new CreatePool();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreatePool()
        {
            PoolName = "TestPoolEsc";
            PoolVolume = "123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreatePool Instance
        {
            get { return instance; }
        }

#region Variables

        string _PoolName;

        /// <summary>
        /// Gets or sets the value of variable PoolName.
        /// </summary>
        [TestVariable("7cb0aeef-ba78-47de-bdc3-da15543dc851")]
        public string PoolName
        {
            get { return _PoolName; }
            set { _PoolName = value; }
        }

        string _PoolVolume;

        /// <summary>
        /// Gets or sets the value of variable PoolVolume.
        /// </summary>
        [TestVariable("c7dec234-a171-4bd9-bfc0-ef6a984c312e")]
        public string PoolVolume
        {
            get { return _PoolVolume; }
            set { _PoolVolume = value; }
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
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Pool Info'. Associated repository item: 'ComPentairPentairhome.PoolInfoTile'", repo.ComPentairPentairhome.PoolInfoTileInfo, new RecordItemIndex(1));
                repo.ComPentairPentairhome.PoolInfoTileInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Pool Info");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.PoolInfoTile' at Center", repo.ComPentairPentairhome.PoolInfoTileInfo, new RecordItemIndex(2));
                repo.ComPentairPentairhome.PoolInfoTile.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'ADD A NEW POOL'. Associated repository item: 'ComPentairPentairhome.AddaNewPoolBtn'", repo.ComPentairPentairhome.AddaNewPoolBtnInfo, new RecordItemIndex(3));
                repo.ComPentairPentairhome.AddaNewPoolBtnInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "ADD A NEW POOL");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.AddaNewPoolBtn' at Center", repo.ComPentairPentairhome.AddaNewPoolBtnInfo, new RecordItemIndex(4));
                repo.ComPentairPentairhome.AddaNewPoolBtn.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Outdoor'. Associated repository item: 'ComPentairPentairhome.Outdoor'", repo.ComPentairPentairhome.OutdoorInfo, new RecordItemIndex(5));
                repo.ComPentairPentairhome.OutdoorInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Outdoor");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.Outdoor' at Center", repo.ComPentairPentairhome.OutdoorInfo, new RecordItemIndex(6));
                repo.ComPentairPentairhome.Outdoor.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set value", "(Optional Action)\r\nSetting attribute Text to '$PoolName' on item 'ComPentairPentairhome.PoolName'.", repo.ComPentairPentairhome.PoolNameInfo, new RecordItemIndex(7));
                repo.ComPentairPentairhome.PoolName.Element.SetAttributeValue("Text", PoolName);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Set value", "(Optional Action)\r\nSetting attribute Text to '$PoolVolume' on item 'ComPentairPentairhome.PoolVolume'.", repo.ComPentairPentairhome.PoolVolumeInfo, new RecordItemIndex(8));
                repo.ComPentairPentairhome.PoolVolume.Element.SetAttributeValue("Text", PoolVolume);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.Done' at Center", repo.ComPentairPentairhome.DoneInfo, new RecordItemIndex(9));
                repo.ComPentairPentairhome.Done.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch gestures", "(Optional Action)\r\nSwipe gesture with direction 'Up (270°)' starting from 'Center' with distance '250' with swipe duration'500ms' and step count '0' on item 'ComPentairPentairhome.PoolVolume'.", repo.ComPentairPentairhome.PoolVolumeInfo, new RecordItemIndex(10));
                repo.ComPentairPentairhome.PoolVolume.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "250"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
                Delay.Milliseconds(500);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.AddressDropDownOnPoolCreation' at Center", repo.ComPentairPentairhome.AddressDropDownOnPoolCreationInfo, new RecordItemIndex(11));
                repo.ComPentairPentairhome.AddressDropDownOnPoolCreation.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComPentairPentairhome.Container53DiamondStSanFrancisco' at Center", repo.ComPentairPentairhome.Container53DiamondStSanFranciscoInfo, new RecordItemIndex(13));
            repo.ComPentairPentairhome.Container53DiamondStSanFrancisco.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.SavePool' at Center", repo.ComPentairPentairhome.SavePoolInfo, new RecordItemIndex(15));
                repo.ComPentairPentairhome.SavePool.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 10s.", new RecordItemIndex(16));
                Delay.Duration(10000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(17));
                repo.ComPentairPentairhome.HomeIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 3s.", new RecordItemIndex(18));
                Delay.Duration(3000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}