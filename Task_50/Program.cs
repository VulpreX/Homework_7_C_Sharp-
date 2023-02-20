void AddDigitalToArray1 (int[,] digital)
    {
           
        for ( int i=0 ;  i < digital.GetLength(0); i++)
        {
            for (int j = 0; j < digital.GetLength(1); j++)
            {
                digital[i,j] = new Random().Next(-100,1000);                                      
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

int Search(int[,] array,int argument)
{   
     
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if ( argument == array[i,j])
            {
               
               Console.WriteLine($" {argument} found in lines № - {i+1} column № - {j+1}");                            
               
            }
            
                          
        }  
    }
    Console.WriteLine();
    return argument;    
   
}
void Search1(int[,] array,int argument)
{   
    int r = 0; 
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            if ( argument == array[i,j])
            {
               
               r++;
                              
               
            }
             
                          
        } 
         
    }
    Console.WriteLine($"your number met {r} times");
    Console.WriteLine();
        
   
}
int[,] array = new int [ReadInt(" number of lines"), ReadInt( " column number" )];
AddDigitalToArray1(array);
Console.WriteLine();
PritnArray(array);
int number = ReadInt(" number to search");
Console.WriteLine();
Search(array,number);
Search1(array, number);