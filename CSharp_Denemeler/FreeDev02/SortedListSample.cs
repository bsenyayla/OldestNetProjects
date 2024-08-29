using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeDev02
{
    public class SortedListSample
    {
        public SortedListSample(){
            Utils.Msg(@"SortedList Sample ===================================================");

            SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("Bahadir", 1);
            sortedList.Add("Ahmet", 32);
            sortedList.Add("Zeynet", 24);
            sortedList.Add("Murat", 29);

            foreach (var kvp in sortedList) {
                FreeDev02.Utils.Msg($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
            }



            //descanding..
            foreach (var kvp in sortedList.OrderByDescending(kvp => kvp.Key))
            {
                FreeDev02.Utils.Msg($"Anahtar: {kvp.Key}, Değer: {kvp.Value}");
            }
            


        }

    }
}