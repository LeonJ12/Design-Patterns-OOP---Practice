using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_JL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zd4();
            Console.ReadLine();
        }
        public static void Zd1()
        {
            Notebook notebook = new Notebook();
            Note noteA = new Note("First", "aa");
            Note noteB = new Note("Second", "bb");
            Note noteC = new Note("Third", "cc");
            notebook.AddNote(noteA);
            notebook.AddNote(noteB);
            notebook.AddNote(noteC);
            var iterator = notebook.GetIterator();
            for (Note n = iterator.First(); !iterator.IsDone; n = iterator.Next())
            {
                n.Show();
                Console.WriteLine();
            }

        }
        public static void zd2()
        {
            Box box = new Box();
            Product Apple = new Product("Apple", 5.2);
            Product Banana = new Product("Banana", 3.1);
            Product Milk = new Product("Milk", 2.7);
            box.AddProduct(Apple);
            box.AddProduct(Banana);
            box.AddProduct(Milk);
            var iterator = box.GetIterator();
            for(Product p =  iterator.First(); !iterator.IsDone; p = iterator.Next())
            {
               Console.WriteLine(p.ToString());
            }
        }
        public static void zd3()
        {
            ToDoItem toDoItem = new ToDoItem("Item", "items", DateTime.Now);
            CareTaker caretaker  = new CareTaker();
            caretaker.AddMemento(toDoItem.StoreState());
            toDoItem.ChangeTask("new task");
            caretaker.AddMemento(toDoItem.StoreState());
            toDoItem.RestoreState(caretaker.GetMemento(0));
            Console.WriteLine(toDoItem);

        }
        public static void zd4()
        {
            
            BankAccount bankAccount = new BankAccount("Leon", "Osijek", 12.2m);
            BankMemento mementoFirst = bankAccount.StoreState();
            bankAccount.ChangeOwnerAddress("Zagreb");
            BankMemento mementoSecond = bankAccount.StoreState();
            bankAccount.RestoreState(mementoSecond);
            Console.WriteLine(bankAccount);
        }

    }
}
