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
    ///The Adverse1_Owner_Personal_Information recording.
    /// </summary>
    [TestModule("69fb4d72-9230-46f6-aee8-8c0d938f7ad1", ModuleType.Recording, 1)]
    public partial class Adverse1_Owner_Personal_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Owner_Personal_Information instance = new Adverse1_Owner_Personal_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Owner_Personal_Information()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Owner_Personal_Information Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AO_PI_FirstName' with focus on 'ApplicationUnderTest.AO_PI_FirstName'.", repo.ApplicationUnderTest.AO_PI_FirstNameInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AO_PI_FirstName.PressKeys("AO_PI_FirstName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AO_PI_LastName' with focus on 'ApplicationUnderTest.AO_PI_LastName'.", repo.ApplicationUnderTest.AO_PI_LastNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AO_PI_LastName.PressKeys("AO_PI_LastName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AO_PI_Address1' with focus on 'ApplicationUnderTest.AO_PI_Address1'.", repo.ApplicationUnderTest.AO_PI_Address1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AO_PI_Address1.PressKeys("AO_PI_Address1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AO_PI_Address2' with focus on 'ApplicationUnderTest.AO_PI_Address2'.", repo.ApplicationUnderTest.AO_PI_Address2Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AO_PI_Address2.PressKeys("AO_PI_Address2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AO_PI_City' with focus on 'ApplicationUnderTest.AO_PI_City'.", repo.ApplicationUnderTest.AO_PI_CityInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.AO_PI_City.PressKeys("AO_PI_City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'ID' on item 'ApplicationUnderTest.AO_PI_USStateCode'.", repo.ApplicationUnderTest.AO_PI_USStateCodeInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.AO_PI_USStateCode.Element.SetAttributeValue("TagValue", "ID");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10001' with focus on 'ApplicationUnderTest.AO_PI_ZipCode'.", repo.ApplicationUnderTest.AO_PI_ZipCodeInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AO_PI_ZipCode.PressKeys("10001");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(8));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(9));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Personal' on item 'ApplicationUnderTest.AO_PI_PhoneUseType'.", repo.ApplicationUnderTest.AO_PI_PhoneUseTypeInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AO_PI_PhoneUseType.Element.SetAttributeValue("TagValue", "Personal");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Land Line' on item 'ApplicationUnderTest.AO_PI_PhoneType'.", repo.ApplicationUnderTest.AO_PI_PhoneTypeInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AO_PI_PhoneType.Element.SetAttributeValue("TagValue", "Land Line");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Direct' on item 'ApplicationUnderTest.AO_PI_PhoneSource'.", repo.ApplicationUnderTest.AO_PI_PhoneSourceInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AO_PI_PhoneSource.Element.SetAttributeValue("TagValue", "Direct");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9500095004' with focus on 'ApplicationUnderTest.AO_PI_PhoneNumber'.", repo.ApplicationUnderTest.AO_PI_PhoneNumberInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.AO_PI_PhoneNumber.PressKeys("9500095004");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(14));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
