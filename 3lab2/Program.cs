using System.Collections;
using System.Security.Principal;
using System.Xml.Linq;
using binary_tree;
using rectangle;
namespace lab3_2
{
    class Program
    {
        static public void postOrder<T>(BinaryTreeNode<T>? current) where T : IComparable<T>
        {
            if (current == null)
            {
                return;
            }
            postOrder(current.Left);
            postOrder(current.Right);
            Console.WriteLine(current.Data.ToString());
        }
        static public void InOrder<T>(BinaryTreeNode<T>? current) where T : IComparable<T>
        {
            if (current == null)
            {
                return;
            }
            InOrder(current?.Left);
            Console.WriteLine(current!.Data);
            InOrder(current?.Right);
        }
        static void Main(string[] args)
        {
            //Simple array
            Console.WriteLine("Simple array------------------------------------------------------");

            Rectangle?[] rectangleArray = new Rectangle[5];
            rectangleArray[0] = new Rectangle("blue", "white", 5, 4);
            rectangleArray[1] = new Rectangle("green", "red", 9, 9);
            rectangleArray[2] = new Rectangle("black", "white", 1, 8);
            rectangleArray[3] = new Rectangle("yellow", "orange", 2, 6);
            rectangleArray[4] = new Rectangle("pink", "black", 12, 3);

            if (rectangleArray[0] != null) {
                Console.WriteLine("First rectangle: " + rectangleArray[0].ToString());
                Console.WriteLine("Square:" + rectangleArray[0].Square());
                Console.WriteLine("Perimeter:" + rectangleArray[0].Perimeter());
            }
            //deleting the rectagle
            rectangleArray[0] = null;
            //searching for green rectangle
            Rectangle? rectangleToFind = Array.Find(rectangleArray, r => r != null && r.FillColour == "green");
            Console.WriteLine("Search result: " + (rectangleToFind == null ? "null" : rectangleToFind.ToString()));
            //iterating
            Console.WriteLine("All elements of array:");
            foreach (Rectangle? rectangle in rectangleArray)
            {
                if (rectangle != null)
                {
                    Console.WriteLine(rectangle.ToString());
                }
            }
            //generic collecton
            Console.WriteLine("Generic List---------------------------------------------");
            List<Rectangle> rectangleList = new List<Rectangle>
            {
                new Rectangle("blue", "white", 5, 4),
                new Rectangle("green", "red", 9, 9),
                new Rectangle("black", "white", 1, 8),
                new Rectangle("yellow", "orange", 2, 6),
            };
            //Add new rectangle
            rectangleList.Add(new Rectangle("pink", "black", 12, 3));

            if (rectangleList[0] != null)
            {
                Console.WriteLine("First rectangle: " + rectangleList[0].ToString());
                Console.WriteLine("Square:" + rectangleList[0].Square());
                Console.WriteLine("Perimeter:" + rectangleList[0].Perimeter());
            }
            //Find and remove the rectangle by colour
            rectangleList.Remove(rectangleList.FirstOrDefault(r => r.FillColour == "blue"));


            // Iterate all rectangles in array
            Console.WriteLine("All elements of list:");
            foreach (Rectangle rectangle in rectangleList)
            {
                Console.WriteLine(rectangle.ToString());
            }
            //non-generic
            Console.WriteLine("Array list----------------------------------------------------------------------------");
            ArrayList rectangleArrayList = new ArrayList
            {
                new Rectangle("blue", "white", 5, 4),
                new Rectangle("green", "red", 9, 9),
                new Rectangle("black", "white", 1, 8),
                new Rectangle("yellow", "orange", 2, 6),
            };
           
            rectangleArrayList.Add(new Rectangle("pink", "black", 12, 3));

            rectangleArrayList.Remove(rectangleArrayList.OfType<Rectangle>().FirstOrDefault(r => r.FillColour == "blue"));

            // Iterate all rectangles
            Console.WriteLine("All rectangles:");
            foreach (var obj in rectangleArrayList)
            {
                if (obj is Rectangle rectangle)
                {
                    Console.WriteLine(rectangle.ToString());
                }
            }
            //binary tree
            Console.WriteLine("Binary tree-----------------------------------------------");
            Console.WriteLine("Binary tree foreach (enumerator):");
            BinaryTree<Rectangle> BinaryTree = new();
            BinaryTree.Insert(new Rectangle("blue", "white", 5, 4));
            BinaryTree.Insert(new Rectangle("green", "red", 9, 9));
            BinaryTree.Insert(new Rectangle("black", "white", 1, 8));
            BinaryTree.Insert(new Rectangle("yellow", "orange", 2, 6));
            BinaryTree.Insert(new Rectangle("pink", "black", 12, 3));
            foreach (Rectangle Rectangle in BinaryTree)
            {
                if (Rectangle != null)
                {
                    Console.WriteLine(Rectangle);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Binary tree postOrder:");
            postOrder(BinaryTree.Root);
            //порівняння по площі
            //            20
            //     8               81
            //       12         26
        }
    }
}