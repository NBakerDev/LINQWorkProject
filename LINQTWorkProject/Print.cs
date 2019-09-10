using System;
using System.Collections.Generic;
using System.Text;
using CSharptoSQLProjectLibrary;

namespace ExtensionMethods {

  static class MyExtensionMethods {

        public static void PrintBrief(this Products product) {
            Console.WriteLine($"Product Name is {product.Name}");
        }

        public static void Print(this List<Products> products) {

            foreach (var product in products)
                Console.WriteLine(product);

        }
    }
}
