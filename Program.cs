
//Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.
Console.WriteLine("Welcome to the GC Student Database. \n");

//Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
string[] name = { "Tolu", "Olukayode", "Gbemi", "Olumide", "Tayo" };
string[] hometown = { "Washington, DC", "Lagos", "Nigeria", "College Park, MD", "Gainsville, FL" };
string[] favoriteFood = { "Amala and Gbegiri", "Pounded Yam", "Moimoi and Gari", "Eba and Okra", "Jollof Rice" };

//Program Loop
bool runProgram = true;
while (runProgram == true)
{
    //List Student IDs and Names
    ListIDAndNames(name);

    //Prompt the user to ask about a particular student by number.Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
    Console.WriteLine("Please enter a student ID number to learn about that student: ");

    //Validate user entry: range and type
    if (int.TryParse(Console.ReadLine(), out int studentID) == true && Validator.Validator.InRange(studentID, 1, name.Count() + 1) == true)
        {
            //Display Student name and ID per user input
            Console.WriteLine($"\nStudent ID: {studentID} || Name: {name[studentID-1]}");

            //loop to get selected student's information
            while (true)
            {
                //Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
                Console.Write($"\nWhat would you like to know about {name[studentID - 1]}? Hometown or Favorite Food? ");
                string category = Console.ReadLine().ToLower().Trim();

                //Validate category selected and display info based on user input
                if (category == "hometown" || category == "town" || category == "home")
                 {
                    Console.WriteLine($"\n{name[studentID - 1]}'s is from {hometown[studentID - 1]}");
                   
                 }
                else if (category == "favorite food" || category == "food" || category == "favorite")
                 {
                    Console.WriteLine($"\n{name[studentID - 1]}'s favorite food is {favoriteFood[studentID - 1]}");
                   

                 }
                else { Console.WriteLine("Invalid entry. Please try again."); }

            //Get user choice more information on selected student
            if (Validator.Validator.GetContinue($"\nWould you like to know more about {name[studentID - 1]}? ") == false) { break; }

            }
        //Get user choice to continue to another student or leave program
        runProgram = Validator.Validator.GetContinueFinal("\nWould you like to learn about another student?");
        }

        //Error message for invalid student ID number entry
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

    //Method to print index and student names
    static void ListIDAndNames(string[] studentList)
    {
        int index = 1;
        foreach (string student in studentList)
        {
            Console.WriteLine($"Student ID: {index} || Name: {student}");
            index++;
        }
    }

}




