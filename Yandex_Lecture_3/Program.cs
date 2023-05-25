using System.Net.Mail;

namespace Yandex_Lecture_3
{

    internal class Program //Множество
    {
        const int setSize = 10;
        List<List<int>> mySet = new List<List<int>>();

       void Add_1(int x)
       {
            mySet[x %setSize].Add(x);
       }

      
        

        bool Find(int x)
        {
            foreach(int now in mySet[x% setSize])
            {
                if(now==x)
                {
                    return true;
                }
            }
            return false;
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        void Delete(int x)
        {
            List<int> xList=mySet[x% setSize];

            for (int i= 0;i<xList.Count;i++)
            {
                if(xList[i]==x)
                {
                    xList.RemoveAt(i);
                    
                    
                }
            }
        }


       
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            Program program =new Program();
            
            Console.WriteLine(String.Join(", ", list));
            program.Add_1(1);
            Console.WriteLine(String.Join(", ", list));
        }
    }
}