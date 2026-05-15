namespace typetext.Logic
{
    public class Variable
    {
        public string Type { get; set; }
        public int Value { get; set; }
        public Variable(string type, int value)
        {
            Type = type; Value = value;
        }

    }
}
