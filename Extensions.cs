namespace TTSlotMaker
{
    public static class Extensions
    {
        public static string CodeToString(this int code)
        {
            return code switch
            {
                > 1000 => code.ToString(),
                > 100 => $"0{code.ToString()}",
                > 10 => $"00{code.ToString()}",
                _ => $"000{code.ToString()}"
            };
        }
    }
}