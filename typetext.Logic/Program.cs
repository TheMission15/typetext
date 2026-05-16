using static typetext.Logic.Instructions;
namespace typetext.Logic
{
    public static class Program
    {
        public static string[] CallQueue = []; // every word/token
        public static int acc = 0; // running total
        public static int pc = 0; // current task
        public static Action<string> ir = print; // stored instruction
        public static bool cu = false; // decides to run task
        public static event Action<List<string>> DataBus;
        public static event Action<List<string>> Errors;
        public static string input = ""; // current inputed value
        public static Random r = new Random(); // random number
        public static Dictionary<string, int> memory = new(); // stores the variables
        public static List<string> Output = new(); // stores all outputs
        public static List<string> StackOverflow = new(); // stores every possible error
        public static Dictionary<string, Action<string>> instructions = new() // all general instructions
        {
            {"set", Set},
            {"get", Get},
            {"add", Add},
            {"rand", Rand},
            {"check", Check},
            {"over", Over},
            {"goto", Goto},
            {"send", Send }
        };
        public static void send()
        {
            DataBus?.Invoke([.. Output]);
        }
        public static void newError(string error)
        {
            StackOverflow.Add(error);
            Errors?.Invoke([..StackOverflow]);
        }
        public static async Task Run(string code)
        {
            r = new Random();
            acc = 0;
            pc = 0;
            cu = false;
            memory.Clear();
            Output.Clear();
            StackOverflow.Clear();
            bool run = false;
            int safety = 0;


            code = code.ToLower();
            CallQueue = code.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < CallQueue.Length; i++) 
            {
                if (CallQueue[i] == "label")
                    Label(i);
                if (CallQueue[i] == "close")
                    run = true;
            }

            while (run)
            {
                if (cu)
                {
                    ir(CallQueue[pc]);
                    cu = false;
                }
                else if (CallQueue[pc] == "negate")
                    Negate();
                else if (CallQueue[pc] == "close")
                    run = false;
                else if (CallQueue[pc] == "type")
                    Type(input);
                else if (CallQueue[pc] == "word") { }

                else if (instructions.TryGetValue(CallQueue[pc], out var instruction))
                {
                    ir = instruction;
                    cu = true;
                }
                        
                if (pc<CallQueue.Length)
                    pc++;

                safety++;
                if (safety == 4999)
                    run = false;
            }
        }  
    }
}
