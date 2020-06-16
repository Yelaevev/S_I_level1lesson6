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
            int lengs = s.Length;
            int lengsubs = subs.Length;
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
                    if (s[0] != ' ')
                    {
                        s = s.Insert(0, " ");
                        end = end + 1;
                    }
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
                 
                    //Console.WriteLine(i);
                    end = i + 2;
                    int l, ind;
                    int flag = 0;
                    int p = subs.Length;

                    if (s[0] != ' ')
                    {
                        s = s.Insert(0, " ");
                        end = end + 1;
                    }
                    else
                    {
                        int temp = i - len;
                        s = s.Insert(temp, " "); //nuzhno dobavit probel i.e. granitsy iskomogo slova rashirili probelami
                        beg = beg - 2;
                    }
                    int m = end+1;
                    for (ind = beg; ind <= (m - p); ind++)
                    {
                        l = 0;
                        flag = 1;
                        for (l = 0; (l < p); l++)//  12345  на  4567 пример для проверки
                        {
                            //if ((i + l >= m)|| (str_m[i + l] != str_p[l])) 
                            if (s[ind + l] != subs[l])
                            {
                                char t11 = s[ind + l];
                                char t1213 = s[7];
                                char t21 = subs[l];
                                string test1 = t11.ToString();
                                string test2 = t21.ToString();
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
            s = s.Insert(beg - 1, " ");
            int m1 = s.Length + 1;
            int p1 = subs.Length;
            char t1;
            char t2;
            beg = beg - 1;
            for (ind1 = beg; ind1 <= (m1 - p1); ind1++)
            {
                l1 = 0;
                flag1 = 1;
                for (l1 = 0; (l1 < p1); l1++)
                {

                    if (s[ind1 + l1] != subs[l1])
                    {
                        t1 = s[ind1 + l1];
                        t2 = subs[l1];
                        string test1 = t1.ToString();
                        string test2 = t2.ToString();
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
                //beg = end + 2;
            }
            else
            {
                someList.Add(0);
                // beg = end + 2;
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

        //    string s = "строка разбивается на набор строк через выравнивание по заданной ширине";
        //    string subs = "ширине";
        //    int len = 12;
        //    Console.WriteLine(subs);
        //    Console.WriteLine(s);
        //    Console.WriteLine(" ");

        //    int[] rech = WordSearch( len,  s,  subs);


        //    foreach (var item in rech)
        //    {
        //        Console.WriteLine(item);
        //    }


        //    //Console.WriteLine(s);


        //}
    }
}
