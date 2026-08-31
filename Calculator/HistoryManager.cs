using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectsBeginer
{
    public class HistoryManager
    {
        private  readonly List<string> History = new List<string>();

        public void AddHistory(double first, string op, double second, double result, ListBox listbox)
        {
            string enty = $"{first} {op} {second} = {result}";
            History.Add(enty);

            if(listbox != null)
            {
                listbox.Items.Add(enty);

                listbox.TopIndex = listbox.Items.Count - 1;
            }
        }

        public void ClearHistory(ListBox listbox)
        {
            History.Clear(); 
            if(listbox != null)
            {
                listbox.Items.Clear();
            }
        }

        public  void ShowHistory()
        {
            Console.WriteLine("\n--- Calculation History ---");
            if (History.Count == 0)
            {
                Console.WriteLine("No calculations recorded yet.");
                return;
            }
            else
            {
                for (int i = 0; i < History.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {History[i]}");
                }
            }
        }
    }
}
