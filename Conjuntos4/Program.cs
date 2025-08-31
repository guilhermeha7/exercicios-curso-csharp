using Conjuntos4.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course A = new Course("A");
            Course B = new Course("B");
            Course C = new Course("C");

            HashSet<Student> students = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int numberOfStudentsA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfStudentsA; i++)
            {
                int id = int.Parse(Console.ReadLine());
                // Procura se já existe o estudante com esse id
                Student existingStudent = students.FirstOrDefault(s => s.Id == id);

                if (existingStudent != null)
                {
                    // Já existe, então adiciona o curso diretamente nele
                    existingStudent.Courses.Add(A);
                }
                else
                {
                    // Não existe, então cria novo com o curso e adiciona
                    Student student = new Student(id);
                    student.Courses.Add(A);
                    students.Add(student);
                }

            }
            Console.WriteLine("");

            Console.Write("How many students for course B? ");
            int numberOfStudentsB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfStudentsB; i++)
            {
                int id = int.Parse(Console.ReadLine());
                
                // Procura se já existe o estudante com esse id
                Student existingStudent = students.FirstOrDefault(s => s.Id == id);

                if (existingStudent != null)
                {
                    // Já existe, então adiciona o curso diretamente nele
                    existingStudent.Courses.Add(B);
                }
                else
                {
                    // Não existe, então cria novo com o curso e adiciona
                    Student student = new Student(id);
                    student.Courses.Add(B);
                    students.Add(student);
                }

            }
            Console.WriteLine("");

            Console.Write("How many students for course C? ");
            int numberOfStudentsC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfStudentsC; i++)
            {
                int id = int.Parse(Console.ReadLine());
                // Procura se já existe o estudante com esse id
                Student existingStudent = students.FirstOrDefault(s => s.Id == id);

                if (existingStudent != null)
                {
                    // Já existe, então adiciona o curso diretamente nele
                    existingStudent.Courses.Add(C);
                }
                else
                {
                    // Não existe, então cria novo com o curso e adiciona
                    Student student = new Student(id);
                    student.Courses.Add(C);
                    students.Add(student);
                }

            }

            Console.WriteLine("Total students: " + students.Count);

        }
    }
}
