namespace JaggedArrayMultiplication
{
    internal class Determinant
    {
        static void Main(string[] args)
        {
            int det = 0;
            int[][,] thisArray = new int[4][,]
            {
            new int[,] { { 5, 7, 2 }, { 3, 5, 4 }, { 8, 3, 5 }, { 5, 5, 2} } ,
            new int[,] { { 5, 7, 2 }, { 3, 5, 4 }, { 8, 3, 5 }, { 5, 5, 2 } } ,
            new int[,] { { 5, 7, 2 }, { 3, 5, 4 }, { 8, 3, 5 }, { 5, 5, 2 } } ,
            new int[,] { { 5, 7, 2 }, { 3, 5, 4 }, { 8, 3, 5 }, { 5, 5, 2 } } 

            }
            ;
            
            for (int i = 0; i < thisArray.Length; i++)
            {
                for (int j = 0; j < thisArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < thisArray[i].GetLength(1); k++)
                    {
                        for (int l = 0; l < thisArray[i].GetLength(2);)
                        {

                        }
                    }
                }
            }
           
                      
        }
    }
}