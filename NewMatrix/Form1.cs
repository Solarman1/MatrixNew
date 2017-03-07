using System;
using System.Windows.Forms;

namespace NewMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int a, b;


        public void button1_Click(object sender, EventArgs e)
        {
            int a_rows, a_collumns, b_rows, b_collumns, res_rows, res_columns;
            Random r = new Random();
            Multy mult = new Multy(a,b);

            //  int a, b;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            a_rows = a;
            a_collumns = b;
            b_rows = a;
            b_collumns = b;
            res_rows = a;
            res_columns = b;

            dataGridView1.RowCount = a_rows;
            dataGridView1.ColumnCount = a_collumns;
            dataGridView2.RowCount = b_rows;
            dataGridView2.ColumnCount = b_collumns;
            dataGridView3.RowCount = res_rows;
            dataGridView3.ColumnCount = res_columns;


            Multy mat1 = new Multy(a_rows, a_collumns);//FIRST MATRIX
            Multy mat2 = new Multy(b_rows, b_collumns);//SECOND MATRIX
            Multy mat3 = new Multy(a_rows, b_collumns);// RESULT MATRIX


            // create values for matrix
            for (int i = 0; i < a_rows; i++)
                for (int j = 0; j < a_collumns; j++)
                { 
                    mat1[i, j] = r.Next(1, 10000);
                    dataGridView1[i, j].Value = mat1[i, j];
                }

            for (int i = 0; i < b_rows; i++)
                for (int j = 0; j < b_collumns; j++)
                { 
                    mat2[i, j] = r.Next(1, 10000);
                    dataGridView2[i, j].Value = mat2[i, j];                  
                }
            for (int i = 0; i < b_rows; i++)
                for (int j = 0; j < b_collumns; j++)
                {
                    mat3 = mat1 * mat2;
                    dataGridView3[i, j].Value = mat3[i, j];
                }


            //Multy math = new Multy(mas);




            //            for (int i = 0; i < a; i++) // First Matrix
            //              for (int j = 0; j < b; j++)
            //        { 
            //                dataGridView1[i, j].Value = mas[math.i, math.j];
            //          }


            /*           for (int i = 0; i < a; i++) // First Matrix
                            for (int j = 0; j < b; j++)
                            {
                                mas[j, i] = r.Next(1, 100);
                                dataGridView1[j, i].Value = mas[j, i];
                            }

                        for (int i = 0; i < a; i++) // Second Matrix
                            for (int j = 0; j < b; j++)
                            {
                                mas2[j, i] = r.Next(1, 100);
                                dataGridView2[j, i].Value = mas2[j, i];
                            }

                        for (int i = 0; i < a; i++) // result Matrix
                            for (int j = 0; j < b; j++)
                            {
                                //mas3[i, j] = 0;
                                for (int k = 0; k < a; k++)
                                {
                                    mas3[j, i] += ((mas[k, i]) * (mas2[j, k]));
                                    dataGridView3[j, i].Value = mas3[j, i];
                                }
                           }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            




        }
    }
   
   
   
   
   
}
