using static typetext.Logic.Program;
namespace typetext.Logic
{
    public static class Instructions
    {
        #region Checks
        public static BoolInt GetValue(string variable)
        {
            BoolInt result = new(false, 0);
            int value = 0;
            if (int.TryParse(variable, out value)) // Will return number entered
            {
                result = new(true, value);
            }
            else if (memory.TryGetValue(variable, out value)) // Otherwise return value at that location in memory[]
            {
                result = new(true, value);
            }
            return result; // If all fail return 0 and provide error to the stack
        }
        public static BoolInt CheckInt(string variable) // Checks if number is entered
        {
            BoolInt result = new(false, 0);
            if (int.TryParse(variable, out int value)) // return the value
            {
                result = new(true, value); 
            }
            return result; // Otherwise return 0 and provide error to stack
        }
        public static void NewLocation(string variable)
        {
            if (!memory.ContainsKey(variable))
            {
                memory.Add(variable, 0);
            }
        }
        #endregion
        public static void Type() // Stores the value to the accumulator
        {
            var result = CheckInt(input);
            acc = result.Value;
            if (!result.Result)
                newError($"{input} is not an integer"); // stores 0 if input was not integer and gives error
        }
        public static void Set(string variable) // Stores the value from accumulator to a specified location in memory
        {
            NewLocation(variable);
            memory[variable] = acc;
            if (CheckInt(variable).Result)
                newError($"variable {variable} cannot be accessed because it is an integer");
        }
        public static void Get(string variable)
        {
            BoolInt result = GetValue(variable);
            acc = result.Value;
            if (!result.Result)
                newError($"{variable} does not exist in the memory");
        }
        public static void Add(string variable)
        {
            BoolInt result = GetValue(variable);
            acc += result.Value;
            if (!result.Result)
                newError($"{variable} does not exist in the memory");
        }
        public static void Negate()
        {
            acc = -acc;
        }
        public static void Over(string variable)
        {
            var result = GetValue(variable);
            if ((acc - result.Value) > 0)
                acc = 1;
            else if ((acc - result.Value) < 0)
                acc = -1;
            else acc = 0;
        }
        public static void Check(string variable)
        {
            var result = GetValue(variable);
            if (!(acc - (result.Value) == 0))
                pc++;
        }
        public static void Label(int i)
        {
            int index = i + 1;
            NewLocation(CallQueue[index]);
            memory[CallQueue[index]] = index;
        }
        public static void Goto(string variable)
        {
            var result = GetValue(variable);
            if (result.Result)
                pc = result.Value;
        }
        public static void Rand(string variable)
        {
            var result = GetValue(variable);
            acc = r.Next(0, result.Value + 1);
        }
        public static void Line()
        {
            acc = pc;
        }
        public static void Send(string variable)
        {
            var result = GetValue(variable);
            Output.Add($"{result.Value}");
            send();
        }
        public static void Clear()
        {
            Output.Clear();
        }
        public static void print(string variable)
        {
            var print = $"{variable}";
        }
    }
}
