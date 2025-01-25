
namespace Tyuiu.KolesnikovMN.Sprint6.Task6.V12.Lib
{
    public class DataService
    {
        public string CollectTextFromFile(string path)
        {
            string[] words = File.ReadAllText(path).Split(' ');
            string res = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == 'w')
                    {
                        res += word + ' ';
                        continue;
                    }
                    else
                        j++;
                }
            }
            return res.Trim();
        }
    }
}
