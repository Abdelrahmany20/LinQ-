using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static LinQ_1.ListGenerator;
namespace LinQ_1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators
            #region 1

            //var Instock = ProductsList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in Instock)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 2
            //var check = ProductsList.Where(p => p.UnitPrice > 0 && p.UnitPrice > 3.00m);


            //foreach (var item in check)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((name, index) => name.Length < index);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion


            #endregion



            #region  LINQ - Element Operators

            #region 1
            //Console.WriteLine(ListGenerator.ProductsList.FirstOrDefault(p => p.UnitsInStock == 0)?.ToString()
            //     ?? "No products found."); 
            #endregion



            #region 2
            //var product = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(product);

            #endregion


            #region 3

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(x => x > 5).Skip(1).FirstOrDefault();

            //Console.WriteLine(result);
            #endregion

            #endregion


            #region LINQ - Aggregate Operators


            #region 1

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int odd = Arr.Count(x => x % 2 == 1);

            //Console.WriteLine(odd);

            #endregion



            #region 2
            //var Count = from customer in CustomersList
            //                          select new
            //                          {
            //                              Name = customer.CustomerName,
            //                              OrderCount = customer.Orders.Count()
            //                          };

            //foreach (var item in Count)
            //{
            //    Console.WriteLine($"{item.Name}                Orders: {item.OrderCount}");
            //}


            #endregion


            #region 3

            //var cat = ProductsList.GroupBy(c => c.Category).Select(p => new
            //{
            //    CatName = p.Key,
            //    Count = p.Count()


            //});

            //foreach (var item in cat)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion



            #region 4
            //    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //int sum = Arr.Sum();

            //Console.WriteLine(sum);

            #endregion


            string[] words = File.ReadAllLines("dictionary_english.txt");


            #region 5
            //int charcount = words.SelectMany(word => word).Count();

            //Console.WriteLine(charcount);

            #endregion

            #region 6
            //int shortestWord = words.Min(word => word.Length);
            //Console.WriteLine(shortestWord);


            #endregion

            #region 7
            //int longestWord = words.Max(word => word.Length);
            //Console.WriteLine(longestWord);

            #endregion

            #region 8
            //double AvgWord = words.Average(word => word.Length);
            //Console.WriteLine(AvgWord);

            #endregion

            #region 9

            //var catstock = ProductsList.GroupBy(p => p.Category).Select(n => new
            //{
            //    cat = n.Key,
            //    totalunits = n.Sum(p => p.UnitsInStock)
            //});
            //foreach (var cat in catstock)
            //{

            //    Console.WriteLine($"category : {cat.cat}\n total units :{cat.totalunits}");
            //}

            #endregion

            #region 10
            //var cheapestproduct = ProductsList.GroupBy(p => p.Category).Select(n => new
            //{
            //    cat = n.Key,
            //    CheapestPrice = n.Min(p => p.UnitPrice)

            //});

            //foreach (var cat in cheapestproduct)
            //{
            //    Console.WriteLine($"Category: {cat.cat}\n  Cheapest Price: {cat.CheapestPrice}");
            //}

            #endregion

            #region 11
            //var cheapestProducts = from product in ProductsList
            //                       group product by product.Category into categoryGroup
            //                       let minPrice = categoryGroup.Min(p => p.UnitPrice)
            //                       from p in categoryGroup
            //                       where p.UnitPrice == minPrice
            //                       select new
            //                       {
            //                           ProductName = p.ProductName,
            //                           Price = p.UnitPrice
            //                       };

            //foreach (var item in cheapestProducts)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}\n Price: {item.Price}");
            //}

            #endregion

            #region 12
            //var mostexpensive = ProductsList.GroupBy(p => p.Category).Select(n => new 
            //{
            //    Cat=n.Key,
            //    Max = n.Max(P => P.UnitPrice)

            //});

            //foreach (var item in mostexpensive)
            //{
            //    Console.WriteLine($"{item.Cat}\n {item.Max}" );


            //}

            #endregion

            #region 13

            //var ExpensiveProducts = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(n => n.OrderByDescending(p => p.UnitPrice).FirstOrDefault())
            //    .Select(p => new
            //    {
            //        ProductName = p.ProductName,
            //        Price = p.UnitPrice
            //    });

            //foreach (var item in ExpensiveProducts)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}\n Price: {item.Price}");
            //}


            #endregion


            #region 14

            //var avgPrices = ProductsList.GroupBy(p => p.Category)
            //                                    .Select(p => new
            //                                    {
            //                                        Category = p.Key,
            //                                        AveragePrice = p.Average(p => p.UnitPrice)
            //                                    });

            //foreach (var item in avgPrices)
            //{
            //    Console.WriteLine($"Category: {item.Category}\n  Price: {item.AveragePrice}");
            //}

            #endregion


            #endregion



            #region  LINQ - Ordering Operators



            #region 1
            //var sortedProducts = ProductsList.OrderBy(p => p.ProductName);

            //foreach (var item in sortedProducts)
            //{
            //    Console.WriteLine(item);        
            //}

            #endregion

            #region 2

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedarray = Arr.OrderBy(w => w.ToLower());

            //foreach (var w in sortedarray)
            //{
            //    Console.WriteLine(w);
            //}

            #endregion

            #region 3
            //var sortdesc = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortdesc)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}\n Units: {product.UnitsInStock}");
            //}

            #endregion

            #region 4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortDigits = Arr.OrderBy(a=> a.Length).ThenBy(a => a);

            //foreach (var digit in sortDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            #endregion

            #region 5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var sortedWords = Arr.OrderBy(w => w.Length).ThenBy(w => w.ToLower());

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region 6
            //var sortproduct = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in sortproduct)
            //{
            //    Console.WriteLine(product);   

            //}

            #endregion

            #region 7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word.Length).ThenByDescending(word => word.ToLower());

            //foreach (var item in sortedWords)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 8
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};


            //var result = Arr.Where(word => word.Skip(1).FirstOrDefault() == 'i').Reverse();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion





            #endregion


            #region LINQ – Transformation Operators


            #region 1
            //var productNames = from product in ProductsList
            //                   select product.ProductName;

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}


            #endregion

            #region 2

            //String[] list = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordCases = list.Select(word => new
            //{
            //    Upper = word.ToUpper(),
            //    Lower = word.ToLower()
            //});

            //foreach (var item in wordCases)
            //{
            //    Console.WriteLine($"Upper: {item.Upper}, Lower: {item.Lower}");
            //}

            #endregion

            #region 3

            //var productDetails = ProductsList.Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitPrice , //as price  
            //    p.Category
            //});

            //foreach (var item in productDetails)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}\n  Price: {item.UnitPrice}\n  Category: {item.Category}");
            //}

            #endregion

            #region 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //var result = Arr.Select((value, index) => new { Number = value, InPlace  = index });

            //Console.WriteLine("Number:   In-place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}:   {item.InPlace}");
            //}



            //foreach (var (value, index) in Arr.Select((value, index) => (value, index)))
            //{
            //    bool inPlace;
            //    if (value == index)
            //        inPlace = true;
            //    else
            //        inPlace = false;

            //    Console.WriteLine($"{value}  :   {inPlace}");
            //}


            #endregion


            #region 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var pairs = from a in numbersA 
            //            from b in numbersB
            //            where a < b
            //            select (a, b);

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            #endregion

            string[] customers = File.ReadAllLines("Customers.xml");

            #region 6




            //var result = from C in CustomersList
            //             from O in C.Orders
            //             .Where(o => o.Total > 500)
            //             select O;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7



            //var result = from C in CustomersList
            //               from O in C.Orders.Where(o => o.OrderDate.Year >= 1998)
            //               select O;
            //   foreach (var item in result)
            //   {
            //       Console.WriteLine(item);
            //   }
            #endregion
            #endregion


            #region LINQ - Set Operators




            #region 1
            //var unique = ProductsList.Select(p => p.Category).Distinct();

            //foreach (var item in unique)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 2
            //var unionUnique = ProductsList.Select(p => p.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0]).Distinct());



            //foreach (var item in unionUnique)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 3
            //var unionUnique = ProductsList.Select(p => p.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0]).Distinct());


            //foreach (var item in unionUnique)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region 4
            //var unionUnique = ProductsList.Select(p => p.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0]).Distinct());



            //foreach (var item in unionUnique)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #region 5

            // var last = ProductsList.Select(p => new string(p.ProductName.TakeLast(3).ToArray()));
            //var all=last.Concat(CustomersList.Select(c=>new string(c.CustomerName.TakeLast(3).ToArray())));



            // foreach (var item in all)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion


            #endregion


            #region LINQ - Quantifiers




            #region 1
            //bool ei = words.Any(word => word.Contains("ei"));

            //// Output result
            //Console.WriteLine(ei ? "There are words containing ei " : "No words contain ei");


            #endregion


            #region 2
            //var result = ProductsList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}

            #endregion


            #region 3
            //var result = ProductsList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //}

            #endregion



            #endregion


            #region LINQ - Partitioning Operators


            #region 1
            //var firstThreeOrders = CustomersList
            //    .Where(c => c.City == "Washington")
            //    .Select(c => new
            //    {
            //        FirstThreeOrders = c.Orders.Take(3)
            //    })
            //    .ToList();


            //foreach (var item in firstThreeOrders)
            //{

            //    Console.WriteLine(item);

            //}


            #endregion

            #region 2
            //var skip2orders = CustomersList
            //    .Where(c => c.City == "London")
            //    .Select(c => new
            //    {
            //        FirstThreeOrders = c.Orders.Skip(2)
            //    })
            //    .ToList();


            //foreach (var item in skip2orders)
            //{

            //    Console.WriteLine(item);

            //}

            #endregion


            #region 3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int index = 0;

            //while (index < numbers.Length && numbers[index] > index)
            //{
            //    Console.Write(numbers[index] + " ");
            //    index++;
            //}

            #endregion


            #region 4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int index = 0;

            //while (index < numbers.Length && numbers[index] % 3 != 0)
            //{
            //    index++;
            //}

            //for (int i = index; i < numbers.Length; i++)
            //{
            //    Console.WriteLine( i);
            //}

            #endregion


            #endregion


            #region LINQ – Grouping Operators



            #region 1
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var groupedNumbers = numbers.GroupBy(n => n % 5);

            //foreach (var group in groupedNumbers)
            //{
            //    Console.WriteLine($"Numbers with remainder {group.Key} When divided by 5 : {string.Join (", ", group)}");
            //}

            #endregion

            #region 2
            //var s = words.GroupBy(word => char.ToUpper(word[0])).OrderBy(n => n.Key);

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item.Key);

            #endregion


            #region 3

            //   String[] Arr = { "from", "salt", "earn", " last", "near", "form" };


            //   var same = Arr
            //.GroupBy(word => new string(word.OrderBy(c => c).ToArray()));

            //   foreach (var item in same)
            //   {
            //       Console.WriteLine(item.Key);
            //   }

            #endregion
            #endregion





        }
    }
    
}
