namespace typetext.Logic
{
    public static class Files
    {

        public static string BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TypeDeck", "Projects");
        public static void SaveFile(string code, string name)
        {
            string path = Path.Combine(BasePath, $"{name}.type");
            if (!Directory.Exists(BasePath))

                Directory.CreateDirectory(path);
            else
            {
                File.WriteAllText(path, code);
            }
        }
        public static string LoadFile(string name)
        {
            string code = "";
            string path = Path.Combine(BasePath, $"{name}.type");
            if (!Directory.Exists(BasePath))
                Directory.CreateDirectory(path);
            else
            {
                code = File.ReadAllText(path);
            }
            return code;
        }

    }
}
