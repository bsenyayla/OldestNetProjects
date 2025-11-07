using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace AppLearn.AlgoTmp
{
    class AlgoQ1
    {
        private string tmpWord = "bir gun bir yer bir cocuk varmis, daha once kimsenin gitmegi yerlere gidermis. onun annesi onu cok severmis ama , uzaklara gittigi icin korkarmis.";
        public AlgoQ1()
        {
            string result = "";
            result=SolveWithHashTable(this.tmpWord);
            //result= GetMostRepeatedWord(this.tmpWord);
        }




        //Hashtable ht = new Hashtable();
        private string SolveWithHashTable(string strWord)
        {
            string[] strArry = strWord.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            if (strArry.Count() == 0) return "";

            Dictionary<string, int> dictionary = new Dictionary<string, int>();


            foreach (string str in strArry)
            {
                if (dictionary.ContainsKey(str)) {
                    dictionary[str]++;
                }
                else
                {
                    dictionary[str]=1;
                }
            }

            var maxEntry = dictionary.Aggregate((x, y) => x.Value > y.Value ? x : y);


            var maxPair = dictionary.OrderByDescending(kv => kv.Value).First();

            var deere = (from c in dictionary
                         orderby c.Value descending 
                         select new { c.Key, c.Value }
             ).First();

            var ttt = (from c in strArry
                       group c by c into g
                       orderby g.Count() descending
                       select new { g.Key, T = g.Count() }
                     ).FirstOrDefault();

            return "";
        }



        //en cok tekrar eden kelimeyi bulun
        private string GetMostRepeatedWord(string strWord) {

            string[] words = strWord.ToLower().Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var result = (
                            from c in words
                            group c by c into g
                            orderby   g.Count() descending
                            select new { g.Key , V = g.Count()}
                         ).Take(1);

            var rr = String.Join(" ,", result);

            return rr;
        }











    }
}
