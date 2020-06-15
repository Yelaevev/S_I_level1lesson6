using System;
using System.Collections.Generic;
//using System.Text;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] WordSearch(int len, string s, string subs)
        {
            int i = 0;
            char check;
            s = s.Insert(s.Length, " ");
            subs = subs.Insert(0, " ");
            subs = subs.Insert(subs.Length, " ");
            int beg = 0;
            int end = 0;
            //Console.WriteLine(subs);
            //Console.WriteLine(s);
            //Console.WriteLine(" ");
            int leng = s.Length;
            var someList = new List<int>();
            for (var j = len; j < s.Length; j = i + len + 3)
            {

                i = j;
                int count = 0;
                check = s[i];
                while ((count != len) && (check != ' '))
                {
                    i--;
                    count++;          //mesto razdelenia nahodim
                    check = s[i];

                }
                // razdeliem po probely & proizvodim srazy poisk
                if ((check == ' ') && (count != len))
                {
                    // Console.WriteLine(str);
                    s = s.Insert(i, " \n");
                    end = i;
                    int l, ind;
                    int flag = 0;
                    int m = end + 1;// plus 1 i.e. dobavili probel pri razdelenii
                    int p = subs.Length;

                    for (ind = beg; ind <= (m - p); ind++)
                    {
                        l = 0;
                        flag = 1;
                        for (l = 0; (l < p); l++)
                        {
                            if (s[ind + l] != subs[l])
                            {
                                flag = 0;
                                break;
                            }

                        }
                        if (flag == 1)
                            break;
                    }
                    if (flag == 1)
                    {
                        someList.Add(1);
                        beg = end + 2; // plus dva i.e. dobavili pri razdelenin znak slezh &znak n
                    }
                    else
                    {
                        someList.Add(0);
                        beg = end + 2;
                    }
                }

                // razdeliem kogda dlina slova prevyshaet shiriny & proizvodim srazy poisk
                if ((count == len) && (check != ' '))
                {
                    i = j;
                    //Console.WriteLine(i);
                    s = s.Insert(i, " \n");
                    //int temp = i - subs.Length + 2;
                    //s = s.Insert(temp, " "); //nuzhno dobavit probel i.e. granitsy iskomogo slova rashirili probelami
                    //Console.WriteLine(i);
                    end = i + 1;
                    int l, ind;
                    int flag = 0;
                    int m = end + 1;
                    int p = subs.Length;

                    for (ind = beg; ind <= (m - p); ind++)
                    {
                        l = 0;
                        flag = 1;
                        for (l = 0; (l < p); l++)//  12345  на  4567 пример для проверки
                        {
                            //if ((i + l >= m)|| (str_m[i + l] != str_p[l])) 
                            if (s[ind + l] != subs[l])
                            {
                                flag = 0;
                                break;
                            }

                        }
                        if (flag == 1)
                            break;
                    }
                    if (flag == 1)
                    {
                        someList.Add(1);
                        beg = end + 2;
                    }
                    else
                    {
                        someList.Add(0);
                        beg = end + 2;
                    }
                }

            }

            int l1, ind1;
            int flag1 = 0;
            int m1 = s.Length;
            int p1 = subs.Length;
            for (ind1 = beg; ind1 <= (m1 - p1); ind1++)
            {
                l1 = 0;
                flag1 = 1;
                for (l1 = 0; (l1 < p1); l1++)
                {
                  
                    if (s[ind1 + l1] != subs[l1])
                    {
                        flag1 = 0;
                        break;
                    }

                }
                if (flag1 == 1)
                    break;
            }
            if (flag1 == 1)
            {
                someList.Add(1);
                beg = end + 2;
            }
            else
            {
                someList.Add(0);
                beg = end + 2;
            }

          Console.WriteLine(s);
            var t = someList.Count;

            int[] rech = new int[t];
            for (int k = 0; k < t; k++)
            {
                rech[k] = someList[k];
            }



            return rech;
        }



        //static void Main(string[] args)
        //{

        //    string s = " строка разбивается на набор строк через выравнивание по заданной ширине";
        //    string subs = "строка";
        //    int len = 12;
        //    Console.WriteLine(subs);
        //    Console.WriteLine(s);
        //    Console.WriteLine(" ");

        //    int[] rech = WordSearch(len, s, subs);

        //    foreach (var item in rech)
        //    {
        //        Console.WriteLine(item);
        //    }


        //    //Console.WriteLine(s);


        //}
    }
}
