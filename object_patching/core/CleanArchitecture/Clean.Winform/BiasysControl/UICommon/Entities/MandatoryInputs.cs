namespace BiasysControl.UICommon.Entities
{
    //this object class will help to verify text input in the commnon TextInput form
    public class MandatoryInputs
    {
        public string FieldName { get; set; }
        public string TagValue { get; set; }
        public string TextValue { get; set; }
        public bool IsRequired { get; set; }
        public string MsgRequiredText { get; set; }
        public bool IsUniqued { get; set; }
        public string MsgUniquedText { get; set; }
        public bool IsAllowedSpecialChars { get; set; }
        public string MsgAllowedSpecialChars { get; set; }
        public bool IsUpperCase { get; set; }
        public int OrderInput { get; set; }
    }
}
