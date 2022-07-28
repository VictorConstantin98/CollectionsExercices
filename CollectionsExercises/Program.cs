namespace CollectionsExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = new List<int>();

            Console.WriteLine(list.Count);
            list.Add(5);
            list.Add(8);
            Console.WriteLine(list.Count);

            list.AddRange(list);

            Console.WriteLine(list.Count+"\n");

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\n");
            foreach(int element in list)
            {
                Console.WriteLine(element);
            }

            list.Clear();
            Console.WriteLine(list.Count);

            list.Add(5);
            list.Add(-50);
            list.Add(40);
            list.Add(30);
            list.Add(-100);

            Console.WriteLine(list.Average());

            list.Sort();

            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            //LINQ

            list = list.OrderByDescending(x => x).ToList();

            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            list.Remove(30);

            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            list.RemoveAt(3);

            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            list.Insert(1, 550);

            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }

            bool valueExist = list.Contains(560);
            
            Console.WriteLine("\n");
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }







            List<Dog> dogs = new List<Dog>();

            List<int> listNegative = list.FindAll(element => element < 0);
            List<int> listPozitive = list.FindAll(element => element > 0);

            Console.WriteLine("\n");
            foreach (int element in listNegative)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n");
            foreach (int element in listPozitive)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n");
            List<int> sublist = list.GetRange(list.Count - 3, 3);
            Console.WriteLine(sublist.Max());

            int nextValueAfter550 = list[list.IndexOf(550) + 1];
            Console.WriteLine(nextValueAfter550);

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(49);
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(59);

            Console.WriteLine(queue.Dequeue());

            Stack<int> intStack = new Stack<int>();

            intStack.Push(5);
            intStack.Push(40);
            intStack.Push(-40);

            Console.WriteLine(intStack.Pop());
            intStack.Push(55);
            Console.WriteLine(intStack.Pop());

            Console.WriteLine("\n" + "Dictionar:");
            Dictionary<string, double> bugetPersoane = new Dictionary<string, double>();

            bugetPersoane.Add("Costi", 500);
            bugetPersoane.Add("Alex", 450);
            bugetPersoane.Add("Mihaela", 450);
            bugetPersoane.Add("Andrei", 30);

            foreach (KeyValuePair<string,double> keyValuePair in bugetPersoane)
            {
                Console.WriteLine(keyValuePair.Key +" " + keyValuePair.Value);
            }

            bugetPersoane["Alex"] = 850;

            Console.WriteLine(bugetPersoane["Alex"]);

            bugetPersoane["Alex"] = bugetPersoane["Alex"] + 200;

            Console.WriteLine(bugetPersoane["Alex"]);

            


            Console.WriteLine("\n");
            foreach (KeyValuePair<string, double> keyValuePair in bugetPersoane.OrderBy(element => element.Key).ThenBy(element=>element.Value));
            {
                Console.WriteLine(KeyValuePair.Key + " " + KeyValuePair.Value);
            }




        }
    }
}
