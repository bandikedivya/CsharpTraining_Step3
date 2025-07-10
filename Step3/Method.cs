using System;
using System.Data;

namespace Method1_Advanced
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
    }


    class StudentOperations
    {
        //public static Student GetStudent()
        // {
        //     Student student = new Student();
        //     student.Name = "Peter";
        //     student.Age = 21;
        //     student.Subject = "Javascript";
        //     return student;
        // }

        //public static Student GetStudent()
        //{
        //    Student student = new Student()
        //    {
        //        Name = "Peter",
        //        Age = 21,
        //        Subject = "Javascript"
        //    };
        //    return student;
        //}
        public static Student GetStudent()
        {
            return new Student()
            {
                Name = "Peter",
                Age = 21,
                Subject = "Javascript"
            };
        }
        public static Student UpdateStudent(Student student)
        {
            student.Subject = student.Subject + " - Advanced";
            return student;
        }
        //public static Student[] GetStudents()
        //{

        //    Student student1 = new Student();
        //    student1.Name = "Peter";
        //    student1.Age = 21;
        //    student1.Subject = "Javascript";

        //    Student student2 = new Student();
        //    student2.Name = "Mohan";
        //    student2.Age = 22;
        //    student2.Subject = "Typescript";


        //    Student student3 = new Student();
        //    student3.Name = "Chandra";
        //    student3.Age = 23;
        //    student3.Subject = "HTML";

        //    //string[] str = new string[] {  "abc" , "def" , "gf"  };

        //    Student[] students = new Student[] { student1, student2, student3 };
        //    return students;


        //}


        //public static Student[] GetStudents()
        //{
        //    Student[] students = new Student[] {

        //    new Student(){
        //        Name = "Peter",
        //        Age = 21,
        //        Subject = "Javascript"
        //    },
        //    new Student(){
        //        Name = "Mohan",
        //        Age = 22,
        //        Subject = "Typescript"
        //    },
        //    new Student(){
        //        Name = "Chandra",
        //        Age = 23,
        //        Subject = "HTML"
        //    },

        //    };
        //    return students;


        //}

        public static Student[] GetStudents()
        {
            return new Student[] {
                    new Student(){
                        Name = "Peter",
                        Age = 21,
                        Subject = "Javascript"
                    },
                    new Student(){
                        Name = "Mohan",
                        Age = 22,
                        Subject = "Typescript"
                    },
                    new Student(){
                        Name = "Chandra",
                        Age = 23,
                        Subject = "HTML"
                    },
            };
        }

        public static Student[] UpdateStudnetsWithSubject(Student[] students)
        {
            foreach (Student student in students)
            {
                student.Subject = student.Subject + " - Advanced";
            }

            return students;
        }




    }



    class Program
    {
        static void Main()
        {
            Student singleStudent = StudentOperations.GetStudent();
            Console.WriteLine($"Single Student: {singleStudent.Name}, {singleStudent.Age}, {singleStudent.Subject}");


            var studentsList = StudentOperations.GetStudents();
            Console.WriteLine("List of Students:");

            foreach (Student student in studentsList)
            {
                Console.WriteLine($"{student.Name} , {student.Age} , {student.Subject}");
            }

            Student peter = StudentOperations.UpdateStudent(new Student()
            {
                Name = "Peter",
                Age = 21,
                Subject = "Javascript"
            });

            Student anotherpeter = StudentOperations.UpdateStudent(singleStudent);
            //foreach (Student student in )
            //{
            //    Console.WriteLine($"{student.Name}'s updated subject: {student.Subject}");
            //}

            

            Console.WriteLine($" Now Peter subject is after updateStudent Method is {peter.Subject}");

            StudentOperations.UpdateStudnetsWithSubject(studentsList);


        }
    }
}