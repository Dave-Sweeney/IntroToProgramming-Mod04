using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataStructures_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX 2 - Task 1.2:  Create an array of floating point values to represent a series of grades
            // Create an array here called grdsArray
            // EX 2 - Task 1.3:  Add grades to the array
            float[] grdsArray = new float[] { 90, 85, 93, 70, 100 };

            // EX 2 - Task 1.4:  Read grades from the array
            displayGrades(grdsArray);
            
            
            // Call the addGrades method, passing it the grdsArray




            // After adding grades to the array, call the displayGrades method
            // to print out the grades to the console window
            // Use the foreach construct to iterate over the array



            // EX 2 - Task 2.2:  Implement the System.Colections.Stack class
            // Create a new Stack object called myStack
            Stack myStack = new Stack();

            // EX 2 - Task 2.3:  Push values to the stack
            pushStack(grdsArray, myStack);
            

            // EX 2 - Task 2.4:  Pop values from the stack
            myStack.Pop();
            myStack.Pop();



            // Call the pushStack() method passing in the grades array for values
            


            // Call the popStack() method twice to remove the top two items from stack
            // The popStack method will display each popped item to the console window



            // EX 2 - Task 3.2:  Create a new .Net SortedList object called myCourses
            // Create a new SortedList object called myCourses
            SortedList<string, string> myCourses = new SortedList<string, string>();

            // EX 2 - Task 3.3:  Add the following values to the myCourses list
            // CS101 Introduction to Programming
            // CS102 Data Structures and Algorithm Analysis
            // CS201 Introduction to Databases
            // CS301 Introduction to Object-Oriented Programming
            myCourses.Add("CS101", "Introduction to Computer Science");
            myCourses.Add("CS102", "Data Structures and Algorithm Analysis");
            myCourses.Add("CS201", "Introduction to Databases");
            myCourses.Add("CS301", "Introduction to Object-Oriented Programming");

            // EX 2 - Task 3.4:  Read values from the list
            foreach(KeyValuePair<string, string> listItem in myCourses)
            {
                Console.WriteLine($"{ listItem.Key } { listItem.Value }");
            }

            // EX 2 - Task 3.5:  Remove values from the list
            myCourses.Remove("CS101");
            
            // Call the populateList() method




            // display a course in the list by passing a key




            // Remove an item from the myCourses list using the key

            Console.ReadLine();

        }

        static void EnrollInCourse(string courseName, bool isRequired, bool isAvailable, bool isElective)
        {
            if (ValidateCourse(isRequired, isAvailable, isElective))
            {
                Console.WriteLine("Enrolled");
            }
        }

        static bool ValidateCourse(bool isRequired, bool isAvailable, bool isElective)
        {
            return isRequired && isAvailable && isElective;
        }
        static void addGrades(float[] grdArray)
        {

        }

        static void displayGrades(float[] grdArray)
        {
            foreach (float grade in grdArray)
            {
                Console.WriteLine(grade);
            }
        }


        static void pushStack(float[] grdArray, Stack stack)
        {
            
            foreach(float grade in grdArray)
            {
                stack.Push(grade);
            }
        }

        static void popStack(Stack stack)
        {
            Console.WriteLine("Item removed from the stack: ");

        }

        static void populateList(SortedList list)
        {

        }

        static void displayList(SortedList list, string key)
        {

        }

        static void removeListItem(SortedList list, string key)
        {

        }
    }
}
