using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace undArrWithSumOfZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //путь
            string inputpath = "D:\\solutionsForSpaceApp\\2030\\input.txt";
            string outputpath = "D:\\solutionsForSpaceApp\\2030\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();

            //переменная для обьвления размера массива#1
            string a;
            string secondLine;
            using (var readera = new StreamReader(inputpath))
            {
                a = readera.ReadLine();
                secondLine = readera.ReadLine();

            };
            string[] lineForInt = secondLine.Split(' ');


            int[] A;
            A = new int[Convert.ToInt32(a)];


            int count = 0;
            foreach (var s in lineForInt)
            {
                A[count++] = Convert.ToInt32(s);
            }
            #endregion

            count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for(int j=0;j<A.Length;j++)
                {
                    if ((A[i] + A[j] == 0))
                    {
                        count++;
                    }
                }
            }

            File.WriteAllText(outputpath, count.ToString());

        }
    }
}
