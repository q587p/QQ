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
    ///The ShallNotPass recording.
    /// </summary>
    [TestModule("b2556214-b67d-49d3-ac50-91a62877b455", ModuleType.Recording, 1)]
    public partial class ShallNotPass : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QQRepository repository.
        /// </summary>
        public static QQRepository repo = QQRepository.Instance;

        static ShallNotPass instance = new ShallNotPass();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ShallNotPass()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ShallNotPass Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'NewProtocolWizard.GoogleChrome.SomeText' at 371;14.", repo.NewProtocolWizard.GoogleChrome.SomeTextInfo, new RecordItemIndex(0));
            repo.NewProtocolWizard.GoogleChrome.SomeText.MoveTo("371;14");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}Q{LShiftKey up}'.", new RecordItemIndex(1));
            Keyboard.Press("{LShiftKey down}Q{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Enabled' to equal the specified value 'True'. Associated repository item: 'NewProtocolWizard.Next'", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(2));
            repo.NewProtocolWizard.NextInfo.WaitForAttributeEqual(5000, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Focus() on item 'NewProtocolWizard'.", repo.NewProtocolWizard.SelfInfo, new RecordItemIndex(3));
            repo.NewProtocolWizard.Self.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'NewProtocolWizard.Next' at 44;13.", repo.NewProtocolWizard.NextInfo, new RecordItemIndex(4));
            repo.NewProtocolWizard.Next.DoubleClick("44;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'NewProtocolWizard.LaunchProtocol'", repo.NewProtocolWizard.LaunchProtocolInfo, new ActionTimeout(5000), new RecordItemIndex(5));
            repo.NewProtocolWizard.LaunchProtocolInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Checked to 'False' on item 'NewProtocolWizard.LaunchProtocol'.", repo.NewProtocolWizard.LaunchProtocolInfo, new RecordItemIndex(6));
            repo.NewProtocolWizard.LaunchProtocol.Element.SetAttributeValue("Checked", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.Finish' at 13;8.", repo.NewProtocolWizard.FinishInfo, new RecordItemIndex(7));
            repo.NewProtocolWizard.Finish.Click("13;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyAssaysExplorer.ListItemQ' at 29;3.", repo.MyAssaysExplorer.ListItemQInfo, new RecordItemIndex(8));
            repo.MyAssaysExplorer.ListItemQ.Click("29;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MyAssaysExplorer.ListItemQ'.", repo.MyAssaysExplorer.ListItemQInfo, new RecordItemIndex(9));
            repo.MyAssaysExplorer.ListItemQ.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
