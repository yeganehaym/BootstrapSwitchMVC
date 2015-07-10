using System.ComponentModel;

namespace BootstrapSwitchModel.Models
{
    public class BootstrapSwitchModel
    {
        [DisplayName("data-size")]
        public BootstrapSwitchSize Size { get; set; }

        [DisplayName("checked")]
        public bool Checked { get; set; }

        [DisplayName("data-animate")]
        public bool Animate { get; set; }

        [DisplayName("readonly")]
        public bool ReadOnly { get; set; }

        [DisplayName("data-on-color")]
        public BootstrapColor OnColor { get; set; }

        [DisplayName("data-off-color")]
        public BootstrapColor OffColor { get; set; }

        [DisplayName("data-on-text")]
        public string OnText { get; set; }

        [DisplayName("data-off-text")]
        public string OffText { get; set; }

        [DisplayName("data-label-text")]
        public string LabelText { get; set; }

        [DisplayName("data-label-width")]
        public int LabelWidth { get; set; }


        [DisplayName("data-base-class")]
        public string BaseClass { get; set; }

        [DisplayName("data-wrapper-class")]
        public string WrapperClass { get; set; }

        [DisplayName("data-radio-all-off")]
        public bool RadioAllOff { get; set; }

        [DisplayName("inverse")]
        public bool Inverse { get; set; }

        [DisplayName("data-indeterminate")]
        public bool Indeterminate { get; set; }

        [DisplayName("disabled")]
        public bool Disabled { get; set; }

        [DisplayName("data-handle-width")]
        public bool HandleWidth { get; set; }
    }

    public enum BootstrapSwitchSize
    {
        Mini=0,
        Small=1,
        Normal=2,
        Large=3
    }

    public enum BootstrapColor
    {
        Default,
        Primary,
        Info,
        Success,
        Danger,
        Warning   
    }


}
