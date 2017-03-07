using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMatrix
{

    class Multy     
    {

       public int[,] array;
       public int rows, collumns;

        public int Rows
        {
            get { return rows;  }
            set
            {
                if (value > 0)
                    rows = value;
            }
        }// rows value
        public int Collumns
        {
            get { return collumns; }
            set
            {
                if (value > 0)
                    collumns = value;
            }
        } // columns value

        public int this[int i, int j] // indexator
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
        public Multy(int countofRows, int countOfColumns)
        {
            Rows = countofRows;
            Collumns = countOfColumns;
            array = new int [Rows, Collumns];
        }
        public static Multy operator * (Multy a , Multy b)
        {
            Multy multy = new Multy(a.Rows, b.Collumns);
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < b.Collumns; j++)
                {                    
                    {
                        for (int k = 0; k < a.Collumns; k++)
                            multy[j, i] += ((a[k, i]) * (b[j, k]));
                    }
                }
            return multy;
        }



      /*  public Multy( int[,] first)
        {

       
            Random r = new Random();
           
            int[,] mas1 = new int[Form1.a,Form1.b];


            for ( i = 0; i < Form1.a; i++) // First Matrix
                for ( j = 0; j < Form1.b; j++)
                {
                    
                    mas1[j, i] = r.Next(1, 100);
                    first[j, i] = mas1[j, i];
                }
           // Console.WriteLine(mas1[i, j]);
          //  return first[i, j];
        }*/
    }
}
