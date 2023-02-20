void AddDigitalToArray1 (double[,] digital)
    {
           
        for ( int i=0 ;  i < digital.GetLength(0); i++)
            {
                for (int j = 0; j < digital.GetLength(1); j++)
                {
                   digital[i,j] = new Random().Next(-100,100); 
                    if(digital[i,j]>0)
                    {
                     digital[i,j] = digital[i,j] + Math.Round(new Random().NextDouble(), 2);
                    }
                    else
                    {
                      digital[i,j] = digital[i,j] - Math.Round(new Random().NextDouble(), 2);
                    } 
                }
                
            }       
          
    }    

void PritnArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}  ");
        }
       System.Console.WriteLine();
        
    }
}
int ReadInt1(string argument1)
{
    Console.Write($"Enter {argument1} - ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine(" You entered an invalid number, try again!");
    }
    

    return number; 
}
double[,] array = new double [ReadInt1("Enter number of lines"), ReadInt1( "Enter column number" )];
AddDigitalToArray1(array);
Console.WriteLine();
PritnArray(array);