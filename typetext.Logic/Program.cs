namespace typetext.Logic
{
    public static class Program
    {
        public static string[] CallQueue = [];
        public static int acc = 0;
        public static int pc = 0;
        public static Dictionary<string, int> memory = new();
        public static List<string> StackOverflow = new();
        public static void Main()
        {
            string[] instructions = ["type", "set", "get", "add", "negate", "rand", "check", "over", "goto", "send", "close"];
        }  
    }
}
