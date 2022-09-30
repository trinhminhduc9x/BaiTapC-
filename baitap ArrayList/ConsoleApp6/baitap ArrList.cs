using System;
using System.Collections;

namespace ConsoleApp6
{
    /*nhập vào mảng 1 chiều số nguyên gồm n phần tử. 
       1.Xuất các phần tử vừa nhập
      2. Đếm có bao nhiêu số chẵn
      3. Tính tổng các số âm trong mảng
      4.tính trung bình cộng các số lẻ
      5. kiểm tra có tồn tại số bội của 5 
      6. liệt kê các số chẵn*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trịnh Minh Đức");
            int n;
            nhapn(out n);
            ArrayList arrayList = new ArrayList();
            input(arrayList, n);
            Console.WriteLine("Mang vừa nhập là ");
            output(arrayList);
            Console.WriteLine("\n 2.Mang co {0} so chan", demchan(arrayList));
            if (boicua5(arrayList))
                Console.WriteLine("Mang co ton tai so ...");
            else
                Console.WriteLine("Mang khong co ton tai so ...");
            Console.WriteLine("\n 3.Co tong trung binh cong la {0} ", trungbinhcong(arrayList));
            lietkesochan(arrayList);

        }

        static void input(ArrayList arrayList, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap Phan tu thu {0}:",i);
                arrayList.Add(Console.ReadLine());
            }
        }
        static void output(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i] + "\t");   
            }
        }
        static void nhapn(out int n)
        {
            Console.Write("Input n:");
            n = int.Parse(Console.ReadLine());
        }
        static int demchan(ArrayList arrayList)
        {
            int d = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (int.Parse(arrayList[i].ToString())%2==0)
                {
                    d++;
                }
            }
            return d;
        }
        static int tongam(ArrayList arrayList)
        {
            int s = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (int.Parse(arrayList[i].ToString())  < 0)
                {
                    s = s + int.Parse(arrayList[i].ToString());
                }
            }
            return s;
        }
        static bool boicua5(ArrayList arrayList)
        {

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (int.Parse(arrayList[i].ToString()) % 5 == 0)
                    return true;
            }
            return false;
        }
        static int trungbinhcong(ArrayList arrayList)
        {
            int s = 0;
            int d;
            int c = 0;
            
            for (int i = 0; i < arrayList.Count; i++)
            {
            
                    s = s + int.Parse(arrayList[i].ToString());
                c++;
            }
            d = s / c;
            return d;
        }
        static void lietkesochan(ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (int.Parse(arrayList[i].ToString()) %2 == 0)
                {
                    Console.WriteLine("so chan la {0}:", arrayList[i]);
                }
            }
        }
    }
}
