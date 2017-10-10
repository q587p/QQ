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

namespace QQ
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BigOne recording.
    /// </summary>
    [TestModule("e5930ce3-70eb-443a-991d-0e60c2c7e1df", ModuleType.Recording, 1)]
    public partial class BigOne : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QQRepository repository.
        /// </summary>
        public static QQRepository repo = QQRepository.Instance;

        static BigOne instance = new BigOne();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BigOne()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BigOne Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 47;17.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.Next.Click("47;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.GoogleChrome.Endpoint' at 63;15.", repo.NewProtocolWizard.GoogleChrome.EndpointInfo, new RecordItemIndex(1));
            repo.NewProtocolWizard.GoogleChrome.Endpoint.Click("63;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.GoogleChrome.Other' at 29;12.", repo.NewProtocolWizard.GoogleChrome.OtherInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.GoogleChrome.Other.Click("29;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 48;10.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(3));
            repo.NewProtocolWizard.Next.Click("48;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'NewProtocolWizard.GoogleChrome.Custom' at 66;12.", repo.NewProtocolWizard.GoogleChrome.CustomInfo, new RecordItemIndex(4));
            repo.NewProtocolWizard.GoogleChrome.Custom.DoubleClick("66;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.GoogleChrome.Text1' at 20;7.", repo.NewProtocolWizard.GoogleChrome.Text1Info, new RecordItemIndex(5));
            repo.NewProtocolWizard.GoogleChrome.Text1.Click("20;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99'.", new RecordItemIndex(6));
            Keyboard.Press("99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.GoogleChrome.Text1' at 22;14.", repo.NewProtocolWizard.GoogleChrome.Text1Info, new RecordItemIndex(7));
            repo.NewProtocolWizard.GoogleChrome.Text1.Click("22;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99'.", new RecordItemIndex(8));
            Keyboard.Press("99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 45;10.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(9));
            repo.NewProtocolWizard.Next.Click("45;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'True' on item 'NewProtocolWizard.SampleTypesSimplifiedView.SomeCheckBox8'.", repo.NewProtocolWizard.SampleTypesSimplifiedView.SomeCheckBox8Info, new RecordItemIndex(10));
            repo.NewProtocolWizard.SampleTypesSimplifiedView.SomeCheckBox8.Element.SetAttributeValue("Checked", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 25;9.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(11));
            repo.NewProtocolWizard.Next.Click("25;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeListItem2' at 251;45.", repo.NewProtocolWizard.SomeListItem2Info, new RecordItemIndex(12));
            repo.NewProtocolWizard.SomeListItem2.Click("251;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 19;2.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(13));
            repo.NewProtocolWizard.Next.Click("19;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(14));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 44;9.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(15));
            repo.NewProtocolWizard.Next.Click("44;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.GoogleChrome.MyEndpoint99x99Protocol2' at 190;9.", repo.NewProtocolWizard.GoogleChrome.MyEndpoint99x99Protocol2Info, new RecordItemIndex(16));
            repo.NewProtocolWizard.GoogleChrome.MyEndpoint99x99Protocol2.Click("190;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{LShiftKey down}B{LShiftKey up}ig{LShiftKey down}O{LShiftKey up}ne'.", new RecordItemIndex(17));
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}{LShiftKey down}B{LShiftKey up}ig{LShiftKey down}O{LShiftKey up}ne");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Next' at 39;7.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(18));
            repo.NewProtocolWizard.Next.Click("39;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'NewProtocolWizard.LaunchProtocol'", repo.NewProtocolWizard.LaunchProtocolInfo, new ActionTimeout(5000), new RecordItemIndex(19));
            repo.NewProtocolWizard.LaunchProtocolInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.LaunchProtocol'.", repo.NewProtocolWizard.LaunchProtocolInfo, new RecordItemIndex(20));
            repo.NewProtocolWizard.LaunchProtocol.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Finish' at 54;13.", repo.NewProtocolWizard.FinishInfo, new RecordItemIndex(21));
            repo.NewProtocolWizard.Finish.Click("54;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.BigOne' at 53;7.", repo.MyAssaysExplorer.BigOneInfo, new RecordItemIndex(22));
            repo.MyAssaysExplorer.BigOne.Click("53;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.OpenFileRibbonButton' at 25;17.", repo.MyAssaysExplorer.OpenFileRibbonButtonInfo, new RecordItemIndex(23));
            repo.MyAssaysExplorer.OpenFileRibbonButton.Click("25;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InvalidConfiguration' at 276;0.", repo.InvalidConfiguration.SelfInfo, new RecordItemIndex(24));
            repo.InvalidConfiguration.Self.Click("276;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'InvalidConfiguration.ButtonOK' at 49;16.", repo.InvalidConfiguration.ButtonOKInfo, new RecordItemIndex(25));
            repo.InvalidConfiguration.ButtonOK.Click("49;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'MyAssaysExplorer.BigOne' at 63;11.", repo.MyAssaysExplorer.BigOneInfo, new RecordItemIndex(26));
            repo.MyAssaysExplorer.BigOne.MoveTo("63;11");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MyAssaysExplorer.BigOne'.", repo.MyAssaysExplorer.BigOneInfo, new RecordItemIndex(27));
            repo.MyAssaysExplorer.BigOne.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.SomeTabPage1' at 53;71.", repo.MyAssaysExplorer.SomeTabPage1Info, new RecordItemIndex(28));
            repo.MyAssaysExplorer.SomeTabPage1.Click("53;71");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
