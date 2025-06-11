using Qinshift.AdoNet.Entities;
using Qinshift.AdoNet.Services;

string connectionString = "Server=.;Database=SECD_ACADEMY;Trusted_Connection=True;TrustServerCertificate=True;";
StudentService studentService = new StudentService(connectionString);
SubjectService subjectService = new SubjectService(connectionString);

while (true)
{
    Console.WriteLine("\n === Main menu ===");
    Console.WriteLine("1. List all students");
    Console.WriteLine("2. Insert new student");
    Console.WriteLine("3. Delete student by ID");
    Console.WriteLine("4. Update student's first name");
    Console.WriteLine("5. List all subjects");
    Console.WriteLine("6. Insert new subject");
    Console.WriteLine("7. Delete subject by ID");
    Console.WriteLine("8. Update subject name");
    Console.WriteLine("9. Exit");
    Console.Write("Choose option (1-9): ");
    var option = Console.ReadLine();

    switch (option)
    {
        // STUDENT OPERATIONS
        case "1":
            var students = studentService.GetAllStudents();
            Console.WriteLine("\n--- Students ---");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id}. {s.FirstName} {s.LastName}");
            }
            break;

        case "2":
            Console.WriteLine("\nInsert New Student:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Student newStudent = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = DateTime.Now.AddYears(-20),
                EnrolledDate = DateTime.Now,
                Gender = 'M',
                NationalIdNumber = 1234567890,
                StudentCardNumber = "s" + new Random().Next(10000, 99999)
            };

            studentService.InsertStudent(newStudent);
            Console.WriteLine(" Student successfully added.");
            break;

        case "3":
            Console.Write("\nEnter the ID of the student to delete: ");
            if (int.TryParse(Console.ReadLine(), out int deleteId))
            {
                studentService.DeleteStudentById(deleteId);
                Console.WriteLine("Student deleted successfully.");
            }
            else Console.WriteLine("Invalid ID.");
            break;

        case "4":
            Console.Write("\nEnter the ID of the student to update: ");
            if (int.TryParse(Console.ReadLine(), out int updateId))
            {
                Console.Write("Enter new first name: ");
                string newName = Console.ReadLine();
                studentService.UpdateStudentFirstName(updateId, newName);
                Console.WriteLine("First name updated successfully.");
            }
            else Console.WriteLine("Invalid ID.");
            break;

        // SUBJECT OPERATIONS
        case "5":
            var subjects = subjectService.GetAllSubjects();
            Console.WriteLine("\n--- Subjects ---");
            foreach (var subj in subjects)
            {
                Console.WriteLine($"{subj.Id}. {subj.Name}");
            }
            break;

        case "6":
            Console.Write("Enter subject name: ");
            var subjectName = Console.ReadLine();
            subjectService.InsertSubject(subjectName);
            Console.WriteLine("Subject added.");
            break;

        case "7":
            Console.Write("Enter subject ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int subjIdToDelete))
            {
                subjectService.DeleteSubject(subjIdToDelete);
                Console.WriteLine("Subject deleted.");
            }
            else Console.WriteLine("Invalid ID.");
            break;

        case "8":
            Console.Write("Enter subject ID to update: ");
            if (int.TryParse(Console.ReadLine(), out int subjIdToUpdate))
            {
                Console.Write("Enter new subject name: ");
                var newSubjName = Console.ReadLine();
                subjectService.UpdateSubjectName(subjIdToUpdate, newSubjName);
                Console.WriteLine("Subject updated.");
            }
            else Console.WriteLine("Invalid ID.");
            break;

        case "9":
            Console.WriteLine("Exiting program.");
            return;

        default:
            Console.WriteLine("Invalid option. Please enter a number between 1 and 9.");
            break;
    }
}
