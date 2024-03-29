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
    ///The Adverse2_Driver_Insurance_Information recording.
    /// </summary>
    [TestModule("99c02ef6-aa09-411d-ab89-fc8533803b21", ModuleType.Recording, 1)]
    public partial class Adverse2_Driver_Insurance_Information : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse2_Driver_Insurance_Information instance = new Adverse2_Driver_Insurance_Information();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse2_Driver_Insurance_Information()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse2_Driver_Insurance_Information Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InsuranceInformation' at 52;21.", repo.ApplicationUnderTest.InsuranceInformationInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.InsuranceInformation.Click("52;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'ALLSTATE INS GROUP' on item 'ApplicationUnderTest.AD2_IL_CompanyName'.", repo.ApplicationUnderTest.AD2_IL_CompanyNameInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AD2_IL_CompanyName.Element.SetAttributeValue("TagValue", "ALLSTATE INS GROUP");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_LI_PolicyNumber' with focus on 'ApplicationUnderTest.AD2_IL_PolicyNumber'.", repo.ApplicationUnderTest.AD2_IL_PolicyNumberInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.AD2_IL_PolicyNumber.PressKeys("AD2_LI_PolicyNumber");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AD2_IL_ClaimNumber' at Center.", repo.ApplicationUnderTest.AD2_IL_ClaimNumberInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.AD2_IL_ClaimNumber.Click();
            Delay.Milliseconds(9700);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AD2_IL_ClaimNumber' at Center.", repo.ApplicationUnderTest.AD2_IL_ClaimNumberInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.AD2_IL_ClaimNumber.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_LI_ClaimNumber' with focus on 'ApplicationUnderTest.AD2_IL_ClaimNumber'.", repo.ApplicationUnderTest.AD2_IL_ClaimNumberInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.AD2_IL_ClaimNumber.PressKeys("AD2_LI_ClaimNumber");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(8));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AD2_IL_ContactName' at Center.", repo.ApplicationUnderTest.AD2_IL_ContactNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.AD2_IL_ContactName.Click();
            Delay.Milliseconds(9700);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_IL_ContactName' with focus on 'ApplicationUnderTest.AD2_IL_ContactName'.", repo.ApplicationUnderTest.AD2_IL_ContactNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AD2_IL_ContactName.PressKeys("AD2_IL_ContactName");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'AE' on item 'ApplicationUnderTest.AD2_IL_State'.", repo.ApplicationUnderTest.AD2_IL_StateInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.AD2_IL_State.Element.SetAttributeValue("TagValue", "AE");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_IL_Address1' with focus on 'ApplicationUnderTest.AD2_IL_Address1'.", repo.ApplicationUnderTest.AD2_IL_Address1Info, new RecordItemIndex(12));
            repo.ApplicationUnderTest.AD2_IL_Address1.PressKeys("AD2_IL_Address1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_IL_Address2' with focus on 'ApplicationUnderTest.AD2_IL_Address2'.", repo.ApplicationUnderTest.AD2_IL_Address2Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.AD2_IL_Address2.PressKeys("AD2_IL_Address2");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AD2_IL_City' with focus on 'ApplicationUnderTest.AD2_IL_City'.", repo.ApplicationUnderTest.AD2_IL_CityInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.AD2_IL_City.PressKeys("AD2_IL_City");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '90005' with focus on 'ApplicationUnderTest.AD2_IL_Zipcode'.", repo.ApplicationUnderTest.AD2_IL_ZipcodeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.AD2_IL_Zipcode.PressKeys("90005");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(18));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Personal' on item 'ApplicationUnderTest.AD2_IL_PhoneUseType'.", repo.ApplicationUnderTest.AD2_IL_PhoneUseTypeInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.AD2_IL_PhoneUseType.Element.SetAttributeValue("TagValue", "Personal");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Land Line' on item 'ApplicationUnderTest.AD2_IL_PhoneType'.", repo.ApplicationUnderTest.AD2_IL_PhoneTypeInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.AD2_IL_PhoneType.Element.SetAttributeValue("TagValue", "Land Line");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Direct' on item 'ApplicationUnderTest.AD2_IL_PhoneSource'.", repo.ApplicationUnderTest.AD2_IL_PhoneSourceInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.AD2_IL_PhoneSource.Element.SetAttributeValue("TagValue", "Direct");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9500095004' with focus on 'ApplicationUnderTest.AD2_IL_PhoneNumber'.", repo.ApplicationUnderTest.AD2_IL_PhoneNumberInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.AD2_IL_PhoneNumber.PressKeys("9500095004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(23));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(24));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
