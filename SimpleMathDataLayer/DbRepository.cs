namespace SimpleMathDataLayer
{
    public class DbRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <param name="result"></param>
        public void SaveData(int input1, int input2, int result)
        {
            StreamWriter writer = new StreamWriter("x://abc.txt", true);
            writer.WriteLine($"{input1} + {input2} = {result}");
            writer.Close();
        }
    }
}