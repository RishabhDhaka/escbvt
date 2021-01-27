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
    ///The ProductSupportESC recording.
    /// </summary>
    [TestModule("74315b7b-e22a-409d-b206-93c7be873e30", ModuleType.Recording, 1)]
    public partial class ProductSupportESC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static ProductSupportESC instance = new ProductSupportESC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ProductSupportESC()
        {
            ESCProductSupport = "IntelliSync Support";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ProductSupportESC Instance
        {
            get { return instance; }
        }

#region Variables

        string _ESCProductSupport;

        /// <summary>
        /// Gets or sets the value of variable ESCProductSupport.
        /// </summary>
        [TestVariable("38569e38-9fc5-4aa6-9dc7-38f1502b1a21")]
        public string ESCProductSupport
        {
            get { return _ESCProductSupport; }
            set { _ESCProductSupport = value; }
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
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 5s for the attribute 'AccessibilityLabel' to equal the specified value 'Product Support'. Associated repository item: 'ComPentairPentairhome.ProductSupport'", repo.ComPentairPentairhome.ProductSupportInfo, new RecordItemIndex(2));
                repo.ComPentairPentairhome.ProductSupportInfo.WaitForAttributeEqual(5000, "AccessibilityLabel", "Product Support");
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.ProductSupport' at Center", repo.ComPentairPentairhome.ProductSupportInfo, new RecordItemIndex(3));
                repo.ComPentairPentairhome.ProductSupport.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 10s.", new RecordItemIndex(4));
                Delay.Duration(10000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$ESCProductSupport) on item 'ComPentairPentairhome.IntelliSyncSupport'.", repo.ComPentairPentairhome.IntelliSyncSupportInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ComPentairPentairhome.IntelliSyncSupportInfo, "InnerText", ESCProductSupport, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.RCTUIImageViewAnimated' at Center", repo.ComPentairPentairhome.RCTUIImageViewAnimatedInfo, new RecordItemIndex(6));
                repo.ComPentairPentairhome.RCTUIImageViewAnimated.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Touch", "(Optional Action)\r\nTouch item 'ComPentairPentairhome.HomeIcon' at Center", repo.ComPentairPentairhome.HomeIconInfo, new RecordItemIndex(7));
                repo.ComPentairPentairhome.HomeIcon.Touch();
                Delay.Milliseconds(300);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Delay", "(Optional Action)\r\nWaiting for 5s.", new RecordItemIndex(8));
                Delay.Duration(5000, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
