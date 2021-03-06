
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Dover.Framework.Form;

namespace TestApplication
{

    [Form("UDO_FT_TestUDO", "TestApplication.UDOFormTest.srf")]
    public class UDOFormTest : DoverUDOFormBase
    {
        public UDOFormTest()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_1").Specific));
            this.OptionBtn0 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_2").Specific));
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_3").Specific));
            this.ButtonCombo0 = ((SAPbouiCOM.ButtonCombo)(this.GetItem("Item_5").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_6").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_8").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.ComboBox ComboBox0;

        private void OnCustomInitialize()
        {

        }

        private SAPbouiCOM.OptionBtn OptionBtn0;
        private SAPbouiCOM.CheckBox CheckBox0;
        private SAPbouiCOM.ButtonCombo ButtonCombo0;
        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.Matrix Matrix0;
    }
}
