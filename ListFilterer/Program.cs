using System.Collections.Generic;
// ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" }) => { 1, 2}
// ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", 0, 15 }) => { 1, 2, 0, 15}
// ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }) => { 1, 2, 231}


List<Object> list1 = new List<object> { 1, 2, "a", "b", 0, 15 };
List<Object> list2 = new List<object> { 1, 2, "a", "b", "aasf", "1", "123", 231 };
static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
{

  return new List<int>(from isNumber in listOfItems
                       where isNumber is int
                       select (int)isNumber).ToList();
}

Console.WriteLine(GetIntegersFromList(list1));
System.Console.WriteLine(' ');
Console.WriteLine(GetIntegersFromList(list2));
