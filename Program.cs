// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = { 90, 86, 87, 98, 100 };
int[] andrewScores =  { 92, 89, 81, 96, 90 };
int[] emmaScores = { 90, 85, 87, 98, 68 };
int[] loganScores =  { 90, 95, 87, 88, 96 };

// Student names
string[] studentNames = {"sophia", "andrew", "emma", "logan"};

//student scores
int[] studentScores = new int[studentNames.Length];

string currentStudentLetterGrade = "";

//write report header
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "sophia")
    studentScores = sophiaScores;

    else if (currentStudent == "andrew")
    studentScores = andrewScores;

    else if (currentStudent == "emma")
    studentScores = emmaScores;

    else if (currentStudent == "logan")
    studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
    // initialize/reset the sum of scored assignments
      sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;
    if (currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }
    else{
        currentStudentLetterGrade = "F";
    }
   

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();