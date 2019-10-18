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
    ///The ClaimInformation_Screen_Uninsured recording.
    /// </summary>
    [TestModule("e7489ad3-d1f0-4f60-9c91-af1245a15a19", ModuleType.Recording, 1)]
    public partial class ClaimInformation_Screen_Uninsured : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static ClaimInformation_Screen_Uninsured instance = new ClaimInformation_Screen_Uninsured();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClaimInformation_Screen_Uninsured()
        {
            AccoutType = "";
            ProjectName = "";
            ClaimTypes = "";
            DateOfLoss = "";
            Amount = "";
            StateOfLoss = "";
            DA = "";
            Street = "";
            City = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClaimInformation_Screen_Uninsured Instance
        {
            get { return instance; }
        }

#region Variables

        string _AccoutType;

        /// <summary>
        /// Gets or sets the value of variable AccoutType.
        /// </summary>
        [TestVariable("21991f34-be01-41ae-ad76-c5723308300f")]
        public string AccoutType
        {
            get { return _AccoutType; }
            set { _AccoutType = value; }
        }

        string _ProjectName;

        /// <summary>
        /// Gets or sets the value of variable ProjectName.
        /// </summary>
        [TestVariable("94e34c81-3cfb-488d-ad32-1c4713153786")]
        public string ProjectName
        {
            get { return _ProjectName; }
            set { _ProjectName = value; }
        }

        string _ClaimTypes;

        /// <summary>
        /// Gets or sets the value of variable ClaimTypes.
        /// </summary>
        [TestVariable("1bc1e7aa-dcef-4a18-905b-8c99af73a508")]
        public string ClaimTypes
        {
            get { return _ClaimTypes; }
            set { _ClaimTypes = value; }
        }

        string _DateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable DateOfLoss.
        /// </summary>
        [TestVariable("95ca78ae-12e8-4ac7-bfd3-64f20d1dd203")]
        public string DateOfLoss
        {
            get { return _DateOfLoss; }
            set { _DateOfLoss = value; }
        }

        string _Amount;

        /// <summary>
        /// Gets or sets the value of variable Amount.
        /// </summary>
        [TestVariable("8cbbd62b-8e1f-4c3b-9697-25bb27f07989")]
        public string Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        string _StateOfLoss;

        /// <summary>
        /// Gets or sets the value of variable StateOfLoss.
        /// </summary>
        [TestVariable("408e35b9-05bb-461e-82f3-71cf2db132af")]
        public string StateOfLoss
        {
            get { return _StateOfLoss; }
            set { _StateOfLoss = value; }
        }

        string _DA;

        /// <summary>
        /// Gets or sets the value of variable DA.
        /// </summary>
        [TestVariable("c0724ab8-e2d3-454f-b60e-5fd3bc23ccdd")]
        public string DA
        {
            get { return _DA; }
            set { _DA = value; }
        }

        string _Street;

        /// <summary>
        /// Gets or sets the value of variable Street.
        /// </summary>
        [TestVariable("4aecaef7-52f2-47f3-b934-e14d1e9d2414")]
        public string Street
        {
            get { return _Street; }
            set { _Street = value; }
        }

        string _City;

        /// <summary>
        /// Gets or sets the value of variable City.
        /// </summary>
        [TestVariable("c29a33b9-20b3-42a7-8eef-a08a6e1f6109")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.NewBusinessWB'", repo.ApplicationUnderTest.NewBusinessWBInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.NewBusinessWBInfo.WaitForExists(30000);
            
            // Validation
            Report.Log(ReportLevel.Info, "Section", "Validation", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='NewBusinessWB') on item 'ApplicationUnderTest.NewBusinessWB'.", repo.ApplicationUnderTest.NewBusinessWBInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.NewBusinessWBInfo, "InnerText", "NewBusinessWB");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-AdverseInformation') on item 'ApplicationUnderTest.NewSubmission'.", repo.ApplicationUnderTest.NewSubmissionInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.NewSubmissionInfo, "InnerText", "Pending-AdverseInformation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-AdverseInformation') on item 'ApplicationUnderTest.PendingAdverseInformation'.", repo.ApplicationUnderTest.PendingAdverseInformationInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PendingAdverseInformationInfo, "InnerText", "Pending-AdverseInformation");
            Delay.Milliseconds(100);
            
            // Open case from NewBusinessWB
            Report.Log(ReportLevel.Info, "Section", "Open case from NewBusinessWB", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Dashboard1' at 41;18.", repo.ApplicationUnderTest.Dashboard1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.Dashboard1.Click("41;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CaseManager' at 92;22.", repo.ApplicationUnderTest.CaseManagerInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CaseManager.Click("92;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.NewBusinessWB1' at Center.", repo.ApplicationUnderTest.NewBusinessWB1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.NewBusinessWB1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Created' at 74;14.", repo.ApplicationUnderTest.CreatedInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.Created.Click("74;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Created' at 74;14.", repo.ApplicationUnderTest.CreatedInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.Created.Click("74;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Open_Case' at 40;7.", repo.ApplicationUnderTest.Open_CaseInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Open_Case.Click("40;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            // Claim Information screen
            Report.Log(ReportLevel.Info, "Section", "Claim Information screen", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_AccountType'", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new ActionTimeout(45000), new RecordItemIndex(16));
            repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo.WaitForExists(45000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-ClaimInformation') on item 'ApplicationUnderTest.Pending_ClaimInformation'.", repo.ApplicationUnderTest.Pending_ClaimInformationInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Pending_ClaimInformationInfo, "InnerText", "Pending-ClaimInformation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$AccoutType' on item 'ApplicationUnderTest.ClaimInformation_AccountType'.", repo.ApplicationUnderTest.ClaimInformation_AccountTypeInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.ClaimInformation_AccountType.Element.SetAttributeValue("TagValue", AccoutType);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ProjectName' with focus on 'ApplicationUnderTest.ClaimInformation_ProjectName'.", repo.ApplicationUnderTest.ClaimInformation_ProjectNameInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.ClaimInformation_ProjectName.PressKeys(ProjectName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$ClaimTypes' on item 'ApplicationUnderTest.ClaimInformation_ClaimType'.", repo.ApplicationUnderTest.ClaimInformation_ClaimTypeInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.ClaimInformation_ClaimType.Element.SetAttributeValue("TagValue", ClaimTypes);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_Product'", repo.ApplicationUnderTest.ClaimInformation_ProductInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.ApplicationUnderTest.ClaimInformation_ProductInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Auto UM Collision First (NorthEast)' with focus on 'ApplicationUnderTest.ClaimInformation_Product'.", repo.ApplicationUnderTest.ClaimInformation_ProductInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.ClaimInformation_Product.PressKeys("Auto UM Collision First (NorthEast)");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(23));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$DateOfLoss' on item 'ApplicationUnderTest.ClaimInformation_DateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_DateOfLossInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.ClaimInformation_DateOfLoss.Element.SetAttributeValue("TagValue", DateOfLoss);
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence '{Tab}' with focus on 'ApplicationUnderTest.ClaimInformation_DateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_DateOfLossInfo, new RecordItemIndex(25));
                repo.ApplicationUnderTest.ClaimInformation_DateOfLoss.PressKeys("{Tab}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Amount' on item 'ApplicationUnderTest.ClaimInformation_AmountofLoss'.", repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.ClaimInformation_AmountofLoss.Element.SetAttributeValue("TagValue", Amount);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'ApplicationUnderTest.ClaimInformation_AmountofLoss'.", repo.ApplicationUnderTest.ClaimInformation_AmountofLossInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.ClaimInformation_AmountofLoss.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$StateOfLoss' on item 'ApplicationUnderTest.ClaimInformation_StateOfLoss'.", repo.ApplicationUnderTest.ClaimInformation_StateOfLossInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.ClaimInformation_StateOfLoss.Element.SetAttributeValue("TagValue", StateOfLoss);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(29));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(30));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$DA' on item 'ApplicationUnderTest.ClaimInformation_DeductibleAmount'.", repo.ApplicationUnderTest.ClaimInformation_DeductibleAmountInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.ClaimInformation_DeductibleAmount.Element.SetAttributeValue("TagValue", DA);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$Street' on item 'ApplicationUnderTest.ClaimInformation_Street'.", repo.ApplicationUnderTest.ClaimInformation_StreetInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.ClaimInformation_Street.Element.SetAttributeValue("TagValue", Street);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$City' on item 'ApplicationUnderTest.ClaimInformation_City'.", repo.ApplicationUnderTest.ClaimInformation_CityInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.ClaimInformation_City.Element.SetAttributeValue("TagValue", City);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Rear End' on item 'ApplicationUnderTest.ClaimInformation_AccidentType'.", repo.ApplicationUnderTest.ClaimInformation_AccidentTypeInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.ClaimInformation_AccidentType.Element.SetAttributeValue("TagValue", "Rear End");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(36));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClaimInformation_TotalLoss' at 6;8.", repo.ApplicationUnderTest.ClaimInformation_TotalLossInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.ClaimInformation_TotalLoss.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.ClaimInformation_TotalLoss_True'", repo.ApplicationUnderTest.ClaimInformation_TotalLoss_TrueInfo, new ActionTimeout(30000), new RecordItemIndex(38));
            repo.ApplicationUnderTest.ClaimInformation_TotalLoss_TrueInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.ClaimInformation_TotalLoss, false, new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'ApplicationUnderTest.ClaimInformation_IncidentFacts'.", repo.ApplicationUnderTest.ClaimInformation_IncidentFactsInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.ClaimInformation_IncidentFacts.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(41));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SubmitButton1' at 41;11.", repo.ApplicationUnderTest.SubmitButton1Info, new RecordItemIndex(42));
            repo.ApplicationUnderTest.SubmitButton1.Click("41;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
