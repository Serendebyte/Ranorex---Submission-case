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

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Adverse1_Driver_License_Information recording.
    /// </summary>
    [TestModule("34538f6b-3f56-4ad8-b434-13d951522727", ModuleType.Recording, 1)]
    public partial class Adverse1_Driver_License_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Driver_License_Information instance = new Adverse1_Driver_License_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Driver_License_Information()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Driver_License_Information Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LicenseInformation' at 72;22.", repo.ApplicationUnderTest.LicenseInformationInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.LicenseInformation.Click("72;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'LICNO50001' with focus on 'ApplicationUnderTest.AD1_LI_LicenseNumber'.", repo.ApplicationUnderTest.AD1_LI_LicenseNumberInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AD1_LI_LicenseNumber.PressKeys("LICNO50001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'AL' on item 'ApplicationUnderTest.AD1_LI_DriversLicenseState'.", repo.ApplicationUnderTest.AD1_LI_DriversLicenseStateInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AD1_LI_DriversLicenseState.Element.SetAttributeValue("TagValue", "AL");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '400011SSN' with focus on 'ApplicationUnderTest.AD1_LI_SSN'.", repo.ApplicationUnderTest.AD1_LI_SSNInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AD1_LI_SSN.PressKeys("400011SSN");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '02/01/1992' with focus on 'ApplicationUnderTest.AD1_LI_DOB'.", repo.ApplicationUnderTest.AD1_LI_DOBInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD1_LI_DOB.PressKeys("02/01/1992");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
