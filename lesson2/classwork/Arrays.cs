#region 1D Arrays

// int[] arr1;                     //Array<int> arr1;

// int[] arr2 = new int[10];       //Array<int> arr2 = new Array<int>(10);


// int[] arr3 = new int[3] { 1, 2, 3 };

// int[] arr4 = new int[] { 1, 2, 3 };

// int[] arr5 = new[] { 1, 2, 3 };

// int[] arr6 = { 3, 4, 5 };

// // FRPM C#12 !!!!
// int[] arr7 = [ 3, 4, 5 ];         //:-)))))



// int[] arr8 = [];



// string[] planets = ["Меркурий","Венера","Земля","Марс"];

// System.Console.WriteLine(planets.Length);

// // System.Console.WriteLine(planets.Length -1);
// System.Console.WriteLine(planets[^1]);






// string[] planets = ["Меркурий","Венера","Земля","Марс"];

// foreach (string planet in planets)               // foreach (var planet in planets)
// {
//     System.Console.WriteLine(planet);
// }
// System.Console.WriteLine("-------------------");

// for(int i = 0; i < planets.Length; i++)
// {
//     System.Console.WriteLine(planets[i]);
// }


#endregion




#region nD Arrays

// ранг (rank) масива ---> количесво измерений


// int[] arr1 = [ 4, 5, 6];

// int[,] arr2 = {
//     {3, 4, 5},
//     {5, 6, 3},
// };



// int[,] arr1;

// int[,] arr2 = new int[2, 3];

// int[,] arr3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

// int[,] arr4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

// int[,] arr5 = new[,] { { 1, 2, 3 }, { 4, 5, 6 } };

// int[,] arr6 = { { 1, 2, 3 }, { 4, 5, 6 } };








// int[,] arr2 = {
//     {3, 4, 5},
//     {5, 6, 3},
// };


// // int row = arr2.GetUpperBound(0) + 1;
// // int col = arr2.GetUpperBound(1) + 1;

// int row = arr2.GetLength(0);
// int col = arr2.GetLength(1);

// // int col = arr2.Length / row;

// for(int i = 0; i < row ;++i)
// {
//     for(int j = 0; j < col; ++j)
//     {

//         System.Console.Write($"{arr2[i, j]} ");

//     }
//     System.Console.WriteLine();
// }



#endregion



#region Зубчастый масив

// int[][] arr = new int[3][];       //new Array<Array<int>>()

// arr[0] = new int[2] { 3, 4};
// arr[1] = new int[3] { 5, 6, 7};
// arr[2] = new int[4] { 8, 9, 10, 11};

// foreach(int[] row in arr)
// {
//     foreach(int n in row)
//     {
//         System.Console.Write($"{n} ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine(arr[1][2]);

#endregion




