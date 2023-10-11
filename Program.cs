// deklarasi pustaka
using System;

// bagian class
namespace HelloWorld
{
    class Program
    {
        // bagian fungsi
        static void Main(string[] args)
        {
            string hw;
            hw = "Hello String!"; // variable
            
            /*
            Komentar
            */

            Console.WriteLine(hw);

            string txt = "ini adalah manipulasi string";
            Console.WriteLine(txt.ToUpper()); //menjadikan semua huruf menjadi uppercase

            // operator aritmatika
            var hasilarit = 5+2;
            Console.WriteLine(hasilarit);

            int num = 5; // operator penegasan
            Console.WriteLine(++num);
            Console.WriteLine(--num);

            // array
            string[] iniadalah = {"ini", "adalah", "array"}; // dari kiri: 0, 1, 2
            Console.WriteLine(iniadalah[0]);
            Console.WriteLine(iniadalah[1]);
            Console.WriteLine(iniadalah[2]);

            // list
            var listname = new List<string> {"dan ini", "namanya", "list"};
            for (int i = 0; i < listname.Count; i++)
            {
                Console.Write(listname[i] + " ");
            }

            // pengkondisian
            int tiga = 3;
            if (tiga == 3)
            {
                Console.WriteLine("tiga");
            }

            // ternary operator
            int angkatenop = 10;
            string hasiltenop = (angkatenop % 2==0)?"Genap":"Ganjil";
            Console.WriteLine(hasiltenop);

            // perulangan
            int x = 1;

            while (x < 5)
            {
                x += 1; // jangan lupa ininya :D
                Console.WriteLine("ini akan tampil 5 kali");
            }

            // function

            Tampil();

            
        }
     public static void Tampil()
         {
            Console.WriteLine("ini akan ditampilkan lewat function");
        }
    }
}

//A11.2023.15044
