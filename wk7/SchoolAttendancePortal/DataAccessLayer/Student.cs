using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Student
    {
        public enum Nationality
        {
            BD, //Bangladesh
            CA, //Canada
            CN, //China
            HK, //Hong Kong
            ID, //Indonesia
            JP, //Japan
            MY, //Malaysia
            SG, //Singapore
        }

        public static Nationality strToNat(string s)
        {
            Nationality citizenship = Nationality.SG;
            switch (s)
            {
                case "BD":
                    citizenship = Nationality.BD;
                    break;
                case "CA":
                    citizenship = Nationality.CA;
                    break;
                case "CN":
                    citizenship = Nationality.CN;
                    break;
                case "HK":
                    citizenship = Nationality.HK;
                    break;
                case "ID":
                    citizenship = Nationality.ID;
                    break;
                case "JP":
                    citizenship = Nationality.JP;
                    break;
                case "MY":
                    citizenship = Nationality.MY;
                    break;
                case "SG":
                    citizenship = Nationality.SG;
                    break;
            }
            return citizenship;
        }
        
        public static string natToStr(Nationality nat)
        {
            string citizenship = "SG";
            switch (nat)
            {
                case Nationality.BD:
                    citizenship = "BD";
                    break;
                case Nationality.CA:
                    citizenship = "CA";
                    break;
                case Nationality.CN:
                    citizenship = "CN";
                    break;
                case Nationality.HK:
                    citizenship = "HK";
                    break;
                case Nationality.ID:
                    citizenship = "ID";
                    break;
                case Nationality.JP:
                    citizenship = "JP";
                    break;
                case Nationality.MY:
                    citizenship = "MY";
                    break;
                case Nationality.SG:
                    citizenship = "SG";
                    break;
            }
            return citizenship;
        }

        private readonly String CONNECTION_STRING = Properties.Settings.Default.DBConnStr;
        public String AdminNumber { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public Nationality CitizenShip { get; set; }
        public String MobileNumber { get; set; }
        public String SchoolEmail { get; set; }
        public String ImageURL { get; set; }
        public int Insert(out String error)
        {
            int result = 0;
            error = String.Empty;
            String query = "INSERT INTO Student(AdminNumber, Name, Gender, DOB, Address, Citizenship, Mobile, Email, ImageURL) values (@AdminNumber, @Name, @Gender, @DOB, @Address, @Citizenship, @Mobile, @Email, @ImageURL)";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminNumber", this.AdminNumber);
                    command.Parameters.AddWithValue("@Name", this.Name);
                    command.Parameters.AddWithValue("@Gender", this.Gender);
                    command.Parameters.AddWithValue("@DOB", this.DateOfBirth);
                    command.Parameters.AddWithValue("@Address", this.Address);
                    command.Parameters.AddWithValue("@Citizenship", this.CitizenShip.ToString());
                    command.Parameters.AddWithValue("@Mobile", this.MobileNumber);
                    command.Parameters.AddWithValue("@Email", this.SchoolEmail);
                    command.Parameters.AddWithValue("@ImageURL", this.ImageURL);

                    try
                    {
                        connection.Open();
                        result += command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (System.Exception exception)
                    {
                        error = exception.Message;
                    }
                }
            }

            return result;
        }
        public int Delete(String adminNumber)
        {
            //Delete the following and add your implementation here
            String query = "DELETE FROM Student WHERE AdminNumber =@AdminNumber";
            int rows = 0;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminNumber", adminNumber);
                    connection.Open();
                    rows = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return rows;
        }

        public Student GetStudent(String adminNumber)
        {
            Student student = new Student();
            String query = "SELECT * FROM Student WHERE AdminNumber = @AdminNumber";

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminNumber", adminNumber);

                    connection.Open();

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            student.AdminNumber = adminNumber;
                            student.Name = dataReader["Name"].ToString();
                            student.Gender = dataReader["Gender"].ToString();
                            student.DateOfBirth = DateTime.Parse(dataReader["DOB"].ToString());
                            student.Address = dataReader["Address"].ToString();
                            student.CitizenShip = strToNat(dataReader["CitizenShip"].ToString());
                            student.MobileNumber = dataReader["Mobile"].ToString();
                            student.SchoolEmail = dataReader["Email"].ToString();
                            student.ImageURL = dataReader["ImageURL"].ToString();
                        }

                        dataReader.Close();
                        dataReader.Dispose();
                    }

                    connection.Close();
                }
            }

            return student;
        }

        public List<Student> GetAllStudents()
        {
            //Delete the following and add your implementation here
            string query = "SELECT * FROM Student";
            List<Student> students = new List<Student>();
            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand comm = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.AdminNumber = reader["AdminNumber"].ToString();
                        student.Name = reader["Name"].ToString();
                        student.Gender = reader["Gender"].ToString();
                        student.DateOfBirth = Convert.ToDateTime(reader["dob"].ToString());
                        student.CitizenShip = strToNat(reader["CitizenShip"].ToString());
                        student.Address = reader["Address"].ToString();
                        student.MobileNumber = reader["Mobile"].ToString();
                        student.SchoolEmail = reader["Email"].ToString();
                        student.ImageURL = reader["ImageUrl"].ToString();
                        students.Add(student);
                    }
                    conn.Close();
                    reader.Close();
                }
            }
            return students;
        }
    }
}
