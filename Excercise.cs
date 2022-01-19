using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtClass
{
    internal class Excercise
    {
        public void Ex1()
        {
            List<int> listInt = new List<int> { 5, 4, 2, 1, 1, 4 };
            
            int i = 0;
            while (i < listInt.Count-1)
            {
                if (listInt[i] == listInt[i + 1])
                {
                    listInt[i] += listInt[i + 1];
                    listInt.RemoveAt(i + 1);
                    if (i > 0) i--;
                    else i = 0;
                }
                else i++;
            }
            
            foreach(var item in listInt)
            {
                Console.Write(item+" ");
            }
            
            
        }
        public void Ex2()
        {
            List<int> listInt = new List<int> { 1, 2, 3 ,4};
            for (int i = 0; i < listInt.Count / 2; i++)
            {
                Console.Write((listInt[i]+listInt[listInt.Count-i-1])+" ");
            }
            if (listInt.Count % 2 != 0) Console.Write(listInt[listInt.Count/2]);
            Console.WriteLine();
        }
        public void Ex3()
        {
            List<Student> listStudent = new List<Student>
            {
                new Student("DE150056", "Nguyen Loc Tan", 21),
                new Student("DE150055","Do Huu Tuan", 21),
                new Student("DE150321", "Phan Van Anh Khoa", 21)
            };
            listStudent.Sort((s1, s2) => string.Compare(s1.Name, s2.Name));
            foreach (var item in listStudent)
            {
                Console.Write(item);
            }
        }
        public void Ex4()
        {
            ICar seat = new Seat("Lenon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 3);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
