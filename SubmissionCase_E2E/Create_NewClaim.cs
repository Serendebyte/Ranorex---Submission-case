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
    ///The Create_NewClaim recording.
    /// </summary>
    [TestModule("1221b873-7998-47e1-a622-90abeb793210", ModuleType.Recording, 1)]
    public partial class Create_NewClaim : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Create_NewClaim instance = new Create_NewClaim();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create_NewClaim()
        {
            ClientName = "";
            ClaimNumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create_NewClaim Instance
        {
            get { return instance; }
        }

#region Variables

        string _ClientName;

        /// <summary>
        /// Gets or sets the value of variable ClientName.
        /// </summary>
        [TestVariable("d8eadf78-4c39-4b4a-b65c-b88bb2baf3f4")]
        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; }
        }

        string _ClaimNumber;

        /// <summary>
        /// Gets or sets the value of variable ClaimNumber.
        /// </summary>
        [TestVariable("125a4a07-4b92-46cf-9c75-5bc0aab3881d")]
        public string ClaimNumber
        {
            get { return _ClaimNumber; }
            set { _ClaimNumber = value; }
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MenuItemIconImageclassPiPiPlus' at 8;6.", repo.ApplicationUnderTest.MenuItemIconImageclassPiPiPlusInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MenuItemIconImageclassPiPiPlus.Click("8;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AutoSubmission' at 46;7.", repo.ApplicationUnderTest.AutoSubmissionInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.AutoSubmission.Click("46;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClaimNumber' at 76;13.", repo.ApplicationUnderTest.ClaimNumberInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ClaimNumber.Click("76;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ClientName' with focus on 'ApplicationUnderTest.ClientName'.", repo.ApplicationUnderTest.ClientNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ClientName.PressKeys(ClientName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimNumber' on item 'ApplicationUnderTest.SubmissionClaimNumber'.", repo.ApplicationUnderTest.SubmissionClaimNumberInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.SubmissionClaimNumber.Element.SetAttributeValue("TagValue", ClaimNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimNumber' on item 'ApplicationUnderTest.ClaimNumber'.", repo.ApplicationUnderTest.ClaimNumberInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ClaimNumber.Element.SetAttributeValue("TagValue", ClaimNumber);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateThisItem' at 55;14.", repo.ApplicationUnderTest.CreateThisItemInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CreateThisItem.Click("55;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
