namespace typetext.Logic
{
    public class BoolStr
    {
        public bool Result { get; set; }
        public string Value { get; set; }
        public BoolStr(bool result, string value)
        {
            Result = result; Value = value;
        }
    }
}
