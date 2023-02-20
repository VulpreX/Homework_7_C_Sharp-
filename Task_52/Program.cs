void AddDigitalToArray1 (int[,] digital)
    {
           
        for ( int i=0 ;  i < digital.GetLength(0); i++)
        {
            for (int j = 0; j < digital.GetLength(1); j++)
            {
                digital[i,j] = new Random().Next(-10,100);                                      
            }
                
         }       
          
    }    

void PritnArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            Console.Write($"{array[i,j]}  ");
        }
       
       Console.WriteLine();
        
    }
}
int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        
        Console.WriteLine(" You entered an invalid number, try again!");
    }
    
    return number; 
}

void Search(int[,] array)
{   
        double arg = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        for (int j = 0; j < array.GetLength(0); j++)
        {   
            
          
            arg= arg + array[j,i];
          
                                 
        }
        
        arg = arg /array.GetLength(0);
        Console.Write( $"{Math.Round(arg,2)}  " );
        arg=0;
    }
    
    Console.WriteLine();
      
   
}
int[,] array = new int [ReadInt(" number of lines"), ReadInt( " column number" )];
AddDigitalToArray1(array);
Console.WriteLine();
PritnArray(array);
Console.WriteLine();
Search(array);