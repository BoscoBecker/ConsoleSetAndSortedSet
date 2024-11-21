
namespace ConsoleSetAndSortedSet {
    internal abstract class Program {
        private static void Main() {
            var a = new SortedSet<int>() { 0, 1, 2, 3, 4, 5, 6 ,7};
            var b = new SortedSet<int>() { 7, 8, 9, 10, 10, 12, 11 };
            PrintCollection(a);
            
            // UNION 🧑‍🤝‍🧑
            var c = new SortedSet<int>(a);
                c.UnionWith(b);
            PrintCollection(c);
            
            //  INTERSECTION 🤝
            var d = new SortedSet<int>(a);
                d.IntersectWith(b);
            PrintCollection(d);
            
            // EXCEPT WITH⛔
            var e = new SortedSet<int>(a);
               e.ExceptWith(b);
            PrintCollection(e);
        }

        private static void PrintCollection<T>(IEnumerable<T> Collection) {
            foreach (var Obj in Collection) {
                Console.WriteLine($"{Obj} ");
            }
            Console.WriteLine();
        }
    }
}