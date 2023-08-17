// See https://aka.ms/new-console-template for more information
using Challenges;

//var inputData = ")()()())";
//var result = LongestValidParentheses.FindLength2(inputData);

//Console.WriteLine($"valid parentheses of {inputData} is {result} and it has lenght of {result.Length}");

///insert interval
//var inputData = new List<Interval>()
//{
//    ///[1,2],[3,5],[6,7],[8,10],[12,16]
//    /////[1,3],[6,9],[12,16] Given to merge [2,5]
//    new Interval() { Start = 1, End =2},
//    new Interval() { Start = 3, End = 5},
//    new Interval() { Start = 6, End = 7},
//    new Interval() { Start = 8, End = 10},
//    new Interval() { Start = 12, End = 16},
//    new Interval() { Start = 4, End = 9, isNew = true},

//};
//var intervals = InsertInterval.InsertNewInterval(inputData);
//var givenToMerge = inputData.First(x => x.isNew);
//Console.WriteLine($"Given to merge: [{givenToMerge.Start},{givenToMerge.End}]");
//Console.WriteLine("Output:");
//foreach (var interval in intervals)
//{

//    Console.WriteLine($"[{interval.Start},{interval.End}]");
//}

//Input: start = “hit”  end = “cog”  dict = ["hot", "dot","dog","lot","log"]
//  Input: start = “met”  end = “ced”  dict= ["xet","ten", "cet", "lot","log"]
var diccionaryWord = new List<string>() { "hot", "dot", "dog", "lot", "log" };

 var words = WordLadder.GetShortertLength("hit", "cog", diccionaryWord);

Console.WriteLine($"Input : {string.Join(",", diccionaryWord)}");
Console.WriteLine($"Output : {words.Count}");
Console.WriteLine($"Explanation : {string.Join("-", words)}");

Console.ReadKey();