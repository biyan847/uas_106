using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uas_algoritma
{
    class node
    {
        public int NIS;
        public string name;
        public int kelas;
        public node next;
    }
    class list
    {
        node Start;

        public list()
        {
            Start = null;
        }
        public void addnote()
        {
            int NIS;
            String name;
            int kelas;
            Console.Write("\n masukan nomor induk siswa: ");
            NIS = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n masukan nama murid");
            name = Console.ReadLine();
            Console.Write(" masukan kelas");
            kelas = Convert.ToInt32(Console.ReadLine());
            node newnode = new node();
            newnode.NIS = NIS;
            newnode.name = name;
            newnode.kelas = kelas;
            if ((Start == null) || NIS <= Start.NIS)
            {
                if ((Start != null) && (NIS == Start.NIS))
                {
                    Console.WriteLine();
                    return;

            
                }
                newnode.next = Start;
                Start = newnode;
                return;

            }
            node previous, current;
            previous = Start;
            current = Start;

            while ((current != null) && (NIS == current.NIS))
            {
                if (NIS == current.NIS)
                {
                    Console.WriteLine();
                    return ;
                }
                previous.next = current;
                previous.next = current;
            }
            newnode.next = current;
            previous.next= current;
        }

       
        public bool Search(int kelas, ref node previous, ref node current)
        {
            previous = Start;
            current = Start;
            while ((current != null) && (kelas != current.kelas))
            {
                previous = current;
                current = current.next;
            }
            if (current == null)
                return false;
            else
                return true;
        }
        public void Traverse()
        {
            if (listEmpty())
                Console.WriteLine("\n menyimpan lis siswa");
            else
            {
                Console.WriteLine("\n menyimpan list siswa");
                node currentNode;
                for (currentNode = Start; currentNode != null;
                    currentNode = currentNode.next)
                    Console.Write(currentNode.NIS + " " + currentNode.name + " " + currentNode.kelas + "\n");
                Console.WriteLine();

            }

        }
        public bool listEmpty()
        {
            if (Start == null)
                return true;
            else
                return false;
        }




    }





    class Program
    {
        static void Main(string[] args)
        {
            list obj = new list();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. menambahkan siswa ");
                    Console.WriteLine("2. melihat list siswa yangtelah ditambagkan ");
                    Console.WriteLine("3. cari nama siswa");
                    Console.WriteLine("4. EXIT");
                    Console.WriteLine("\nEnter your choice (1-4) : ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.addnote();
                            }
                            break;
                       
                        case '2':
                            {
                                obj.Traverse();
                            }
                            break;
                        case '3':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is Empty");
                                    break;
                                }
                                node previous, current;
                                previous = current = null;
                                Console.Write("\nmasukan kelas "  );
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nrecord not found");
                                else
                                {
                                    Console.WriteLine("\nRecord not found");
                                    Console.WriteLine("\nNIS: " + current.NIS);
                                    Console.WriteLine("\nName: " + current.name);
                                    Console.WriteLine("\nkelas: " + current.kelas);


                                }

                            }
                            break;

                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nCheck for the value");
                }
            }
        }
    }
}




// jawaban soal//
// 2. single linkedlist
// 3. pop dan push
// 4 rear front
// 5.a 5
// 5.b incorder48


