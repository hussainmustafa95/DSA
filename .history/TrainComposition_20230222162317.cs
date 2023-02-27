// using System.Collections;
// using System.Collections.Generic;

// namespace DSA
// {

//     public class TrainComposition
//     {

//         private LinkedList<int> list = new LinkedList<int>();
//         public void AttachWagonFromLeft(int wagonId)
//         {
                
//             list.AddFirst(wagonId);
//         }

//         public void AttachWagonFromRight(int wagonId)
//         {
//             list.AddLast(wagonId);
//         }

//         public int DetachWagonFromLeft()
//         {
//             var result = list.First.Value;
//             list.RemoveFirst();
//             return result;
//         }

//         public int DetachWagonFromRight()
//         {
//              var result = list.Last();
//             list.RemoveLast();
//             return result;
//         }

//         public static void Main()
//         {
//             TrainComposition train = new TrainComposition();
//             train.AttachWagonFromLeft(7);
//             train.AttachWagonFromLeft(13);
//             Console.WriteLine(train.DetachWagonFromRight()); // 7 
//             Console.WriteLine(train.DetachWagonFromLeft()); // 13
//         }
//     }
// }