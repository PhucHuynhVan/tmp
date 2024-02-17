using Clean.WinF.Common.Enum;

namespace BiasysControl.UICommon.Entities
{
    //this object class will help to verify text input in the commnon TextInput form
    public class InputDataStep
    {
        public string PropertyName { get; set; }
        public EInputDataType ControllType { get; set; }
        public object ExtraData { get; set; }
    }
}
