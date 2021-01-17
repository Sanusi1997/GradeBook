using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
                
            Book  book = new Book("Ade");
        
            while(true){

            Console.WriteLine("Please enter grade or 'q' to quit: ");
            var gradeInput = Console.ReadLine();
            try{
            var gradeInt = double.Parse(gradeInput); 
            book.AddGrades(gradeInt);    
            }catch(Exception FormatException){
                   Console.WriteLine(FormatException.Message);
            }
                if(gradeInput == "q" ){
                    break;
                }                
            }
            
            book.DisplayStatisticsSummary();       
        }
    
    }        
}   