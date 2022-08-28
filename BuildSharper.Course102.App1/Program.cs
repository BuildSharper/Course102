////////////////////////////////////////////////////////
///My Quiz Grades
////////////////////////////////////////////////////////
int[] quizGrades = new int[5];
quizGrades[0] = 87;
quizGrades[1] = 94;
quizGrades[2] = 75;
quizGrades[3] = 88;
quizGrades[4] = 100;

Console.WriteLine("My Quiz Grades:");

//let's create a variable to total up all of the quiz grades
int quizTotal = 0;

for (int i = 0; i < 5; i++)
{
    //display the quiz grade
    Console.WriteLine(quizGrades[i] + "%");
    
    //add this quiz grade to the quizTotal variable
    quizTotal += quizGrades[i];
}

//calculate the average quiz grade
double quizAverage = quizTotal / (double)5;

Console.WriteLine("Average Quiz Grade: " + quizAverage + "%");
Console.ReadLine();

////////////////////////////////////////////////////////
///My Test Grades
////////////////////////////////////////////////////////
int[] testGrades = { 95, 79, 87, 89, 98 };

Console.WriteLine("My Test Grades:");

//let's create a variable to total up all of the test grades
int testTotal = 0;

foreach (int testGrade in testGrades)
{
    //display the test grade
    Console.WriteLine($"{testGrade}%");

    //add the test grade to the testTotal variable
    testTotal += testGrade;
}

//calculate the average test grade
double testAverage = testTotal / (double)5;

Console.WriteLine($"Average Test Grade: {testAverage}%");
Console.WriteLine("Press any key to continue.");
Console.ReadLine();