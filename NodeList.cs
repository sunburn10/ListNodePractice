using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    class NodeList
    {
        // היפוך רשימה
        public static Node<int> revlist(Node<int> lst)
        {
            Node<int> lstn = null;
            Node<int> pos = lst;
            while (pos != null)
            {
                lstn = new Node<int>(pos.GetValue(), lstn);
                pos = pos.GetNext();
            }
            return lstn;
        }

        // דף עבודה תרגיל 1
        // יצירת סדרה חשבונית שמנתה 1
        public static Node<int> ProgressionD1(int num)
        {
            Node<int> lst = null;
            int beginner = 1;
            for (int i = 0; i < num; i++)
            {
                lst = new Node<int>(beginner, lst);
                beginner++;
            }
            return revlist(lst);
        }

        // דף עבודה תרגיל 2
        // הדפסת רשימה גנרית
        public static void Print<T>(Node<T> L)
        {
            Node<T> pos = L;
            while (pos != null)
            {
                Console.Write(pos + " ");
                pos = pos.GetNext();
            }
            Console.WriteLine();
        }

        // דף עבודה תרגיל 3
        // בניית רשימה רנדומלית של מספרים שלמים
        public static Node<int> BuildRandoms(int n, int low, int high)
        {
            Random r = new Random();
            Node<int> lst = null;
            for (int i = 0; i < n; i++)
            {
                int ran = r.Next(low, high + 1);
                lst = new Node<int>(ran, lst);
            }

            return lst;
        }

        // דף עבודה תרגיל 4
        // יצירת רשימה באורך 100 עם מספרים שמתקבלים מהמשתמש
        public static Node<int> Create()
        {
            Node<int> L = null;
            for (int i = 0; i < 99; i++)
            {
                int x = int.Parse(Console.ReadLine());
                L = new Node<int>(x, L);
            }
            return L;
        }

        // דף עבודה תרגיל 5
        // ספירת מספר איברים ברשימה
        public static int Count(Node<int> lst)
        {
            Node<int> pos = lst;
            int count = 0;
            while (pos != null)
            {
                count++;
                pos = pos.GetNext();
            }
            return count;
        }

        // Recursive
        public static int CountR(Node<int> lst)
        {
            Node<int> pos = lst;
            if (pos == null)
                return 0;
            return CountR(pos.GetNext()) + 1;
        }

        // דף עבודה תרגיל 6
        // חישוב סכום כל האיברים ברשימה
        public static int Sum(Node<int> list)
        {
            int sum = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                sum += pos.GetValue();
                pos = pos.GetNext();
            }
            return sum;
        }

        //Recursive
        public static int SumR(Node<int> list)
        {
            Node<int> pos = list;
            if (pos == null)
                return 0;
            return SumR(pos.GetNext()) + pos.GetValue();
        }

        //דף עבודה תרגיל 7
        // חישוב ממוצע איברי הרשימה
        public static double Avg(Node<int> list)
        {
            if (list == null)
                return 0;
            int sum = Sum(list);
            int count = Count(list);
            return sum / count + sum % count;
        }

        // Recursive
        public static double AvgR(Node<int> list)
        {
            return SumR(list) / CountR(list) + SumR(list) % CountR(list);
        }

        // דף עבודה תרגיל 8
        // חישוב מכפלת כל האיברים ברשימה
        public static int Product(Node<int> list)
        {

            int Mult = 1;
            Node<int> pos = list;
            if (pos == null)
                return 0;
            while (pos != null)
            {
                Mult += pos.GetValue();
                pos = pos.GetNext();
            }
            return Mult;
        }

        // Recursive
        public static int ProductR(Node<int> list)
        {
            Node<int> pos = list;
            if (pos == null)
                return 0;
            if (pos.hasNext())
            {
                return ProductR(pos.GetNext()) * pos.GetValue();
            }
            return 1;
        }

        // דף עבודה שאלה 9
        // מציאת איבר מקסימלי ברשימה
        public static int FindMax(Node<int> list)
        {
            Node<int> pos = list;
            int max = pos.GetValue();
            while (pos != null)
            {
                if (max < pos.GetValue())
                    max = pos.GetValue();
                pos = pos.GetNext();
            }
            return max;
        }

        // Recursive
        public static int FindMaxR(Node<int> list, int max)
        {
            Node<int> pos = list;
            if (pos == null)
                return max;
            if (pos.GetValue() > max)
                max = pos.GetValue();
            return FindMaxR(pos.GetNext(), max);
        }

        // דף עבודה שאלה 10
        // מציאת איבר מינימלי ברשימה
        public static int FindMin(Node<int> list)
        {
            Node<int> pos = list;
            int min = pos.GetValue();
            while (pos != null)
            {
                if (min > pos.GetValue())
                    min = pos.GetValue();
                pos = pos.GetNext();
            }
            return min;
        }

        // Recursive
        public static int FindMinR(Node<int> list, int min)
        {
            Node<int> pos = list;
            if (pos == null)
                return min;
            if (pos.GetValue() < min)
                min = pos.GetValue();
            return FindMaxR(pos.GetNext(), min);
        }

        // דף עבודה תרגיל 11
        // חישוב סכום כל האברים שערכם זוגי במערך
        public static int EvenSum(Node<int> list)
        {
            int sum = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                if (pos.GetValue() % 2 == 0)
                {
                    sum += pos.GetValue();
                    pos = pos.GetNext();
                }
            }
            return sum;
        }

        //Recursive
        public static int EvenSumR(Node<int> list)
        {
            Node<int> pos = list;
            if (pos == null)
                return 0;
            if (pos.GetValue() % 2 == 0)
                return EvenSumR(pos.GetNext()) + pos.GetValue();
            return SumR(pos.GetNext());
        }

        // דף עבודה תרגיל 12
        // חישוב סכום כל האברים שערכם אי זוגי במערך
        public static int OddSum(Node<int> list)
        {
            int sum = 0;
            Node<int> pos = list;
            while (pos != null)
            {
                sum += pos.GetValue();
                pos = pos.GetNext().GetNext();
            }
            return sum;
        }

        //Recursive
        public static int OddSumR(Node<int> list)
        {
            Node<int> pos = list;
            if (pos == null)
                return 0;
            return SumR(pos.GetNext().GetNext()) + pos.GetValue();
        }

        // דף עבודה תרגיל 13
        // מציאת מספר הפעמים שאיקס מופיע ברשימה
        public static int NumRepeats(Node<int> lst, int x)
        {
            int count = 0;
            Node<int> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue() == x)
                    count++;
                pos = pos.GetNext();
            }
            return count;
        }

        // Recursive
        public static int NumRepeatsR(Node<int> lst, int x)
        {
            Node<int> pos = lst;
            if (pos == null)
                return 0;
            if (pos.GetValue() == x)
                return NumRepeatsR(pos.GetNext(), x) + 1;
            return NumRepeatsR(pos.GetNext(), x);
        }

        public static Node<int> RemoveLst(Node<int> lst, int num)
        {// הפעולה מסירה את כל המופיעים של המספר מהרשימה
            Node<int> pos1 = lst; // רשימה מקורית 
            Node<int> pos3 = null; //  האיבר הקודם
            while (pos1 != null)
            {
                if (pos1.GetValue() == num)
                {
                    if (pos1 == lst) // מחיקה איבר ראשון 
                    {
                        Node<int> temp = pos1;
                        pos1 = pos1.GetNext();
                        lst = lst.GetNext();
                        temp.SetNext(null);
                    }
                    else
                    {
                        Node<int> temp = pos1;
                        pos3.SetNext(pos1.GetNext());
                        pos1 = pos1.GetNext();
                        temp.SetNext(null);
                    }
                }
                else
                {
                    pos3 = pos1;
                    pos1 = pos1.GetNext();
                }
            }
            return lst;
        }

        public static Node<int> ex13page76(Node<int> lst)
        {
            Node<int> pos = lst;
            if (lst == null)
                return lst;
            if (Count(lst) % 2 == 0 && lst != null)
            {
                for (int i = 1; i < Count(lst) / 2; i++)
                {
                    pos = pos.GetNext();
                }
                if (pos.GetValue() > pos.GetNext().GetValue())
                    pos.SetValue(pos.GetNext().GetValue());
                // ביטול 
                Node<int> temp = pos.GetNext();
                pos.SetNext(pos.GetNext().GetNext());
                temp.SetNext(null);
            }
            else// אי זוגי
            {
                Node<int> temp = lst;
                lst = lst.GetNext();// ביטול איבר ראשון 
                temp.SetNext(null);// ניתוק איבר שבוטל
                if (lst != null)
                { // ביטול  ואחרון    
                    pos = lst;
                    // אחד לפני האחרון
                    while (pos.GetNext().GetNext() != null)
                    {
                        pos = pos.GetNext();
                    }
                    pos.SetNext(null);
                }
            }
            return lst;

        }


        // דף עבודה תרגיל 14
        // בודק האם הרשימה בסדר עולה
        public static bool GoesUp(Node<int> lst)
        {
            Node<int> pos = lst;
            while (pos.GetNext().GetNext() != null)
            {
                if (pos.GetValue() > pos.GetNext().GetValue())
                    return false;
                pos = pos.GetNext();
            }
            return true;
        }

        // Recursive
        public static bool GoesUpR(Node<int> lst)
        {
            Node<int> pos = lst;
            if (pos.GetNext().GetNext() == null)
                return true;
            if (pos.GetValue() > pos.GetNext().GetValue())
                return false;
            return GoesUpR(pos.GetNext());
        }

        // דף עבודה תרגיל 15
        // בודק האם איקס נמצא ברשימה
        public static bool IsXInList(Node<int> lst, int x)
        {
            Node<int> pos = lst;
            while (pos != null)
            {
                if (pos.GetValue() == x)
                    return true;
                pos = pos.GetNext();
            }
            return false;
        }

        // Recursive
        public static bool IsXInListR(Node<int> lst, int x)
        {
            Node<int> pos = lst;
            if (pos == null)
                return false;
            if (pos.GetValue() == x)
                return true;
            return IsXInListR(pos.GetNext(), x);
        }

        // דף עבודה תרגיל 16
        // בודק האם הרשימה היא סדרה חשבונית
        public static bool IsProgression(Node<int> lst)
        {
            Node<int> pos = lst;
            while (pos.GetNext().GetNext() != null)
            {
                if (pos.GetNext().GetValue() - pos.GetValue() != pos.GetNext().GetNext().GetValue() - pos.GetNext().GetValue())
                    return false;
                pos = pos.GetNext();
            }
            return true;
        }

        // Recursive
        public static bool IsProgressionR(Node<int> lst)
        {
            Node<int> pos = lst;
            if (pos.GetNext().GetNext() == null)
                return true;
            if (pos.GetNext().GetValue() - pos.GetValue() != pos.GetNext().GetNext().GetValue() - pos.GetNext().GetValue())
                return false;
            return IsProgressionR(pos.GetNext());
        }

        // דף עבודה שאלה 17
        // מקדם את הרשימה מספר צעדים שניתן
        public static Node<int> GoTo(Node<int> lst, int steps)
        {
            Node<int> pos = lst;
            if (steps > Count(pos))
                return null;
            for (int i = 0; i < steps; i++)
            {
                pos = pos.GetNext();
            }
            return pos;
        }

        // Recursive
        public static Node<int> GoToR(Node<int> lst, int steps)
        {
            Node<int> pos = lst;
            if (steps > Count(pos))
                return null;
            if (steps == 0)
                return pos;
            return GoToR(pos.GetNext(), steps - 1);
        }

        // דף עבודה שאלה 18
        // מקדם את הרשימה לאיבר אחרון
        public static Node<int> GoToLast(Node<int> lst)
        {
            Node<int> pos = lst;
            if (pos == null)
                return null;
            else
            {
                while (pos.hasNext())
                    pos = pos.GetNext();
            }
            return pos;
        }

        // דף עבודה שאלה 19
        // מוצא איפה איקס ברשימה
        public static Node<int> FindX(Node<int> lst, int x)
        {
            Node<int> pos = lst;

            while (pos != null)
            {
                if (pos.GetValue() == x)
                    return pos;
                pos = pos.GetNext();
            }
            return pos;
        }

        // Recursive
        public static Node<int> FindXR(Node<int> lst, int x)
        {
            Node<int> pos = lst;
            if (pos == null)
                return null;
            if (pos.GetValue() == x)
                return pos;
            return FindXR(pos.GetNext(), x);
        }

        // דף עבודה שאלה 20
        // מוצא איפה האיבר המינימלי ברשימה
        public static Node<int> FindMinLst(Node<int> lst)
        {
            int min = FindMin(lst);
            return FindX(lst, min);
        }

        //דף עבודה שאלה 21
        // מכניס איבר לרשימה במקום הנתון
        public static Node<int> Insert(Node<int> lst, int x, Node<int> pos)
        {
            Node<int> temp = new Node<int>(x);
            if (pos == null)
            {
                temp.SetNext(lst);
                lst = temp;
            }
            else
            {
                Node<int> p = lst;
                while (p != pos)
                {
                    p = p.GetNext();
                }
                temp.SetNext(p.GetNext());
                p.SetNext(temp);
            }
            return lst;
        }

        //דף עבודה שאלה 26
        // יוצר רשימה שמכילה איברים של שתי רשימות בצורה ממויינת
        public static Node<int> Mergeex26(Node<int> list1, Node<int> list2)
        {
            Node<int> lstm = null;// רשימה המכילה את האיברים של שתי רשימות וגם ממוינת
            Node<int> pos1 = list1;
            Node<int> pos2 = list2;
            while (pos1 != null && pos2 != null)
            {
                if (pos1.GetValue() > pos2.GetValue())
                {
                    lstm = new Node<int>(pos2.GetValue(), lstm);
                    pos2 = pos2.GetNext();
                }
                else// גדול שווה 
                {
                    lstm = new Node<int>(pos1.GetValue(), lstm);

                    if (pos1.GetValue() == pos2.GetValue())
                    {
                        pos2 = pos2.GetNext();
                    }
                    pos1 = pos1.GetNext();
                }
            }


            while (pos1 != null)// שאריות מרשימה 1 
            {
                lstm = new Node<int>(pos1.GetValue(), lstm);
                pos1 = pos1.GetNext();
            }
            while (pos2 != null)// שאריות מרשימה 2 
            {
                lstm = new Node<int>(pos2.GetValue(), lstm);
                pos2 = pos2.GetNext();
            }

            return revlist(lstm);
        }

        // דף עבודה שאלה 27
        // יוצר רשימה משתי רשימות רק עם האיברים המשותפים
        public static Node<int> BothLists(Node<int> list1, Node<int> list2)
        {
            Node<int> lstm = null;
            Node<int> pos1 = list1;
            Node<int> pos2 = list2;
            while (pos1 != null && pos2 != null)
            {

                if (pos1.GetValue() == pos2.GetValue())
                {

                    lstm = new Node<int>(pos1.GetValue(), lstm);
                    pos1 = pos1.GetNext();
                    pos2 = pos2.GetNext();
                }
                else
                {
                    if (pos1.GetValue() > pos2.GetValue())
                    {
                        pos2 = pos2.GetNext();
                    }
                    if (pos2.GetValue() > pos1.GetValue())
                    {
                        pos1 = pos1.GetNext();
                    }
                }

            }
            return revlist(lstm);
        }

        // דף עבודה שאלה 23
        // מוחק איבר ברשימה לפי האיבר שלפניו
        public static Node<int> Delete(Node<int> list, Node<int> prev)
        {
            if (prev == null)
            {
                Node<int> temp = list;
                list = list.GetNext();
                temp.SetNext(null);
            }
            else
            {
                Node<int> temp = prev.GetNext();
                if (temp != null)
                {
                    prev.SetNext(temp.GetNext());
                    temp.SetNext(null);
                }
            }
            return list;
        }

        // דף עבודה שאלה 24
        // מוחק איבר ברשימה לפי מיקומו ברשימה
        public static Node<int> DeleteV2(Node<int> list, int step)
        {
            Node<int> pos = list;
            if (step == 0)
                return list;
            for (int i = 0; i < step - 1; i++)
            {
                if (pos != null)
                    pos = pos.GetNext();
            }
            if (pos == null)
                return list;
            return Delete(list, pos);
        }

        // מכניסה איבר לרשימה במקום ממויין
        public static Node<int> InsertSort(Node<int> lst, int x)
        {
            // not empty list
            Node<int> pos = lst;
            Node<int> temp = new Node<int>(x);
            if (lst == null || pos.GetValue() > x)// adding to the head
            {
                temp.SetNext(lst);
                lst = temp;
            }
            else
            {
                while (pos.GetNext() != null && x > pos.GetNext().GetValue()) // adding mid-list
                    pos = pos.GetNext();
                temp.SetNext(pos.GetNext()); // last list-part
                pos.SetNext(temp);
            }
            return lst;
        }

        // דף עבודה רשימה משולשת
        // בודק האם רשימה היא רשימה משולשת- רשימה שכל שני איברים בה זהים
        public static bool IsTre(Node<int> L)
        {
            Node<int> pos = L;
            Node<int> pos1 = L;
            if (pos == null)
            {
                return false;
            }
            if (Count(L) % 3 != 0)
            {
                return false;
            }
            for (int i = 0; i < Count(L) / 3; i++)
            {
                pos = pos.GetNext();
                pos1 = pos1.GetNext().GetNext();
            }
            while (pos1 != null)
            {
                if (L.GetValue() != pos.GetValue() || L.GetValue() != pos1.GetValue())
                {
                    return false;
                }
                else
                {
                    L = L.GetNext();
                    pos = pos.GetNext();
                    pos1 = pos1.GetNext();
                }
            }
            return true;
        }

        // דף עבודה בגרות קיץ תשסו
        public static Node<int> L3List(Node<int> L1, Node<int> L2)
        {
            Node<int> pos1 = L1;
            Node<int> pos2 = L2;
            Node<int> pos3 = null;
            while (pos1 != null)
            {

                if (pos1.GetValue() % 2 == 1)
                {
                    if (GetPos(pos2, pos1.GetValue()) != null)
                    {
                        int num = GetPos(pos2, pos1.GetValue()).GetValue();
                        pos3 = new Node<int>(num, pos3);
                    }
                }
                if (pos1.GetValue() % 2 == 0)
                {
                    if (GetPos(pos2, pos1.GetValue()) != null)
                    {
                        Delete(pos2, GetPos(pos2, pos1.GetValue()));
                    }
                }
                pos1 = pos1.GetNext();
            }
            return pos3;
        }

        // פעולות עזר
        // מחזירה את האיבר שערכו שווה למספר הנתון
        public static Node<int> GetPos(Node<int> lst, int num)
        {
            Node<int> pos = lst;
            if (Count(pos) < num)
                return null;
            for (int i = 0; i < num - 1; i++)
            {
                if (pos.hasNext())
                    pos = pos.GetNext();
            }
            return pos;
        }

        // דף עבודה חזרה למבחן
        // שאלה 1
        // מחזיר רשימה עם כל המספרים שאין ברשימה וקטנים מהמספר הנתון
        public static Node<int> SmallerThanNum(Node<int> lst, int num)
        {
            Node<int> pos = lst;
            Node<int> res = null;
            int i = 0;
            while (i < num)
            {
                if (FindX(pos, i) == null)
                    res = new Node<int>(i, res);
                i += 1;
            }
            return res;
        }

        // שאלה 2
        // מוצא את הרצף הכי גדול ברשימה
        public static int FindBiggestRezef(Node<int> lst)
        {
            Node<int> pos = lst;
            int count = 1;
            int max = 1;
            for (int i = 0; i < Count(lst) - 1; i++)
            {
                if (pos.GetValue() == pos.GetNext().GetValue())
                {
                    count++;
                }

                if (count >= max)
                {
                    max = count;
                }
                if (pos.GetValue() != pos.GetNext().GetValue())
                {
                    count = 1;
                }

                pos = pos.GetNext();
            }
            return max;
        }

        // שאלה 3
        // בודקת האם המספר זהה עבור מספר האיברים אחרי ששוה לספרת היחידות
        // בודקת האם הרשימה מסודרת כך שספרת היחידות אצל כל איבר מייצגת מספר איברים קטן מהמספר שיש אחריה בפועל
        public static bool IsSeder(Node<int> lst)
        {
            Node<int> pos = lst;
            while (pos != null)
            {
                int checkseder = pos.GetValue() % 10;
                for (int i = 0; i <= checkseder - 1; i++)
                {
                    if (pos.GetNext() == null && i != checkseder)
                        return false;
                    if (pos.GetValue() != pos.GetNext().GetValue())
                        return false;
                    pos = pos.GetNext();
                }
                pos = pos.GetNext();
            }
            return true;
        }

        // שאלה 4
        // מוחק את מחצית האיברים הקטנים ברשימה
        public static Node<int> BiggerHalf(Node<int> lst)
        {
            Node<int> pos = lst;
            int half = Count(lst) / 2;
            for (int i = 0; i < half; i++)
            {
                int min = FindMin(pos);
                Node<int> Current = FindXR(pos, min);
                Node<int> Dlt = GetPrev(pos, Current);
                pos = Delete(pos, Dlt);

            }
            return pos;
        }

        // פעולת עזר
        // פעולה המוצאת את האיבר הקודם של איבר מסוים
        public static Node<int> GetPrev(Node<int> lst, Node<int> pos)
        {
            if (pos == lst)
                return null;
            Node<int> prev = lst;
            while (prev.GetNext() != pos)
            {
                prev = prev.GetNext();
            }
            return prev;
        }

        // שאלה 5
        // סעיף א
        // מוצא מיקום של איבר פרח - מספר שחוזר על עצמו מספר הפעמים של האיבר הקודם לו
        public static Node<int> FlowerPos(Node<int> lst)
        {
            Node<int> pos = lst;
            while (pos.GetNext() != null)
            {
                Node<int> pos1 = pos.GetNext();
                int count = NumRepeats(pos1, pos.GetValue());

                if (count >= pos.GetValue())
                {
                    return pos;
                }
                pos = pos.GetNext();
            }
            return null;
        }

        // סעיף ב
        //public static Node<int> OnlyFlowers(Node<int> lst)
        //{
        //    Node<int> pos = lst;
        //    Node<int> newlst = null;
        //    while (pos != null)
        //    {
        //        int flower = FlowerPos(pos).GetValue();
        //        int index = Count(pos) - Count(FlowerPos(pos));
        //        newlst = new Node<int>(flower, newlst);
        //        DeleteV2(pos, index);
        //        pos = pos.GetNext();
        //    }
        //    return newlst;
        //}


        // עמוד 93 תרגיל 18
        // מחזירה כמה פעמים תו מופיע ברשימה
        public static int CountChar(Node<string> lst, char c)
        {
            Node<string> pos = lst;
            int count = 0;
            while (pos != null)
            {
                string str = pos.GetValue();
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str);
                    if (str[i] == c)
                    {
                        count++;
                    }
                    Console.WriteLine("count:  " + count);
                }
                pos = pos.GetNext();
            }
            return count;
        }
        static void Main(string[] args)
        {
            //Print(BuildRandoms(5, 1, 25));
            //Print(Create());
            Node<int> list = new Node<int>(6);
            list = new Node<int>(1, list);
            list = new Node<int>(2, list);
            list = new Node<int>(1, list);
            list = new Node<int>(2, list);
            list = new Node<int>(1, list);
            Node<int> p1 = list;
            p1 = p1.GetNext();
            p1 = p1.GetNext();
            //Node<int> list2 = new Node<int>(6);
            //list2 = new Node<int>(5, list);
            //list2 = new Node<int>(4, list);
            //list2 = new Node<int>(1, list);
            //list2 = new Node<int>(15, list2);
            //list2 = new Node<int>(12, list2);
            //list2 = new Node<int>(10, list2);
            //list2 = new Node<int>(4, list2);
            //list2 = new Node<int>(3, list2);
            //list2 = new Node<int>(2, list2);
            //list2 = new Node<int>(1, list2);
            //Console.WriteLine(ProductR(list));
            //Print<int>(RemoveLst(list, 5);
            //Node<int> list5 = ex13page76(list);
            //Print<int>(list5);
            //Console.WriteLine(GoesUpR(list));
            //Console.WriteLine(IsXInListR(list,6));
            //Console.WriteLine(IsProgressionR(list));
            //Console.WriteLine(GoToR(list,23));
            //Console.WriteLine(GoToLast(list));
            //Console.WriteLine(FindX(list,7));
            //Console.WriteLine(FindMinLst(list));
            //Print<int>(Insert(list, 14, list2));
            //Print<int>(Mergeex26(list, list2));
            //Print<int>(BothLists(list, list2));
            //Print<int>(DeleteV2(list, 0));
            //list = InsertSort(list, 6543);
            //Print<int>(list);
            Node<int> list2 = new Node<int>(2);
            list2 = new Node<int>(5, list2);
            list2 = new Node<int>(3, list2);
            list2 = new Node<int>(7, list2);
            //list2 = revlist(list2);
            //Console.WriteLine(IsTre(list2));
            Node<int> l1 = new Node<int>(6);
            l1 = new Node<int>(2, l1);
            l1 = new Node<int>(3, l1);
            l1 = new Node<int>(4, l1);


            Node<int> l2 = new Node<int>(1);
            l2 = new Node<int>(4, l2);
            l2 = new Node<int>(4, l2);
            l2 = new Node<int>(1, l2);
            l2 = new Node<int>(1, l2);
            l2 = new Node<int>(4, l2);
            l2 = new Node<int>(4, l2);
            l2 = new Node<int>(1, l2);
            l2 = revlist(l2);
            //Print<int>(L3List(l1, l2));
            //Print<int>(SmallerThanNum(l2, 22));
            //Console.WriteLine(FindBiggestRezef(l2));
            //Console.WriteLine(IsSeder(l2));
            //Print<int>(BiggerHalf(l2));
            //Console.WriteLine(FlowerPos(l2));
            // Console.WriteLine(NumRepeats(l2,l2.GetValue()));
            //Print<int>(OnlyFlowers(l2));
            Node<string> lsts = new Node<string>("xxxxx");
            lsts = new Node<string>("mara", lsts);
            lsts = new Node<string>("xa", lsts);
            lsts = new Node<string>("xialing", lsts);
            lsts = new Node<string>("lxlz", lsts);
            Console.WriteLine(CountChar(lsts, 'x'));

        }
    }
}
