using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace MarshallMidTerm
{
    public delegate bool MyDelegate1<T1, T2>(T1 x, T2 y);
    public delegate double MyDelegate2<T1, T2>(T1 x, T2 y);

    public partial class Form1 : Form
    { //4.
        List<int> numberList = new List<int>();

        List<Student> students;

        string studentListFile = "stud_data.dat";

        string studentListSoapFile = "studentlistsoapfile.dat";

        Random rand = new Random();

        MyDelegate1<int, int> d1;

        MyDelegate2<int, int> d2;

        Action<List<int>> d3;

        public Form1()
        {
            InitializeComponent();
            PopulateStudents();
            /*
             1.	Use a .Net delegate type to create a delegate object and assign it to 
             * reference* an anonymous method that returns true when the 
             * first parameter is greater than twice the second parameter.
             */

            d1 = delegate(int x, int y)
              {
                  if (x > (2 * y))
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
              };

            /*
             2.	Same question as Q1, but this time replace the anonymous method 
             *  with a lambda expression.Write code that invokes the delegate 
             *  object created in Q1. Pass to it any values you choose, and display 
             *  result.
             */

            d1 = (x, y) => x % 2 == 0 && y % 2 != 0;

            /*
             3.	Use a .Net  delegate type to create a delegate object to reference a 
             * lambda expression that takes 2 ints and returns a double. The expression 
             * is to return the square root of the first parameter times the log of the 
             * second parameter.  
             
             */
            d2 = (x, y) => (Math.Sqrt(x)) * (Math.Log(y));
            /*
             *
             * 5. Using one of the class List<T> method, Write a method to get all the 
             * students, from the students list, whose first name and last nam (both), 
             * contain the character e. 
             * 
             * 
             * 9.	Write code to serialize and deserialze the list of student using 
             * BinaryFormatter
             * 
             */
        }

        private void PopulateStudents()
        {
            students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };
            tempStudent = students.ToArray();
     }

        Student[] tempStudent;

        private void bttnFunc1_Click(object sender, EventArgs e)
        {
            int x = rand.Next(-10, 10);
            int y = rand.Next(-10, 10);
            bool result1 = d1(x, y);

            richTextBoxResults.AppendText("  Result 1:  x > 2 * y  " + " " + x + " , " + y + " , " + result1 + "\n\n");
        }

        private void bttnFunc2_Click(object sender, EventArgs e)
        {
            int x = rand.Next(-10, 10);
            int y = rand.Next(-10, 10);
            bool result2 = d1(x, y);

            richTextBoxResults.AppendText(" Result 2: x is Even, y is Odd " + " " + x + " , " + y + " , " + result2 + "\n\n");
        }

        private void bttnFunc3_Click(object sender, EventArgs e)
        {
            int x = rand.Next(-10, 10);
            int y = rand.Next(-10, 10);
            double result3 = d2(x, y);

            richTextBoxResults.AppendText(" Result 3: SqRt x * Log y =  " + " " + x + " , " + y + " , " + result3 + "\n\n");
        }
        /*
                     4.	Assume you have a List of ints, intList, populated with random integers.
                     * Write a statement using one of the method defined in the List<T> class to 
                     * remove all the values that are divisible by 5    
         */

        private void DisplayList(List<int> list, ListBox listBoxDisp)
        {
            listBoxDisp.Items.Clear();
            foreach (int num in list)
            {
                if (num % 5 != 0)
                {
                    listBoxDisp.Items.Add(num);
                }
            }
        }

        private void bttnPopNumList_Click(object sender, EventArgs e)
        {
            numberList.Clear();
            for (int i = 1; i <= 100; i++)
            {
                numberList.Add(rand.Next(-1000, 1001));
            }
            DisplayList(numberList, listBoxDisp);
        }
     
        Action<Student[], ListView> DisplayStudents = delegate(Student[] list, ListView listViewStudents)
            {
                listViewStudents.Items.Clear();

                foreach (Student student in list)
                    {
                    ListViewItem lvItem = new ListViewItem(student.GetType().Name);
                    lvItem.SubItems.Add(student.First);
                    lvItem.SubItems.Add(student.Last);
                    lvItem.SubItems.Add(student.ID.ToString());
                    listViewStudents.Items.Add(lvItem);
                    }
            };
        
        //9.	Write code to serialize and deserialze the list of student using 
        // BinaryFormatter           
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(txtBoxsStudData.Text, FileMode.Append, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, students);
                MessageBox.Show("Task completed, data saved!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ae) { MessageBox.Show(ae.Message); }
            catch (IOException io) { MessageBox.Show(io.Message); }
            finally { if (fs != null) fs.Close(); if (bf != null); }
        }
        private void bttnSerializeDat_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream fs = new FileStream(studentListFile, FileMode.OpenOrCreate, FileAccess.Write);
                formatter.Serialize(fs, students);
                MessageBox.Show("Student list has been serialized.");
            }
            catch (SerializationException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void bttnDeserializeData_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(studentListFile, FileMode.Open, FileAccess.Read))
                {

                    List<Student> list = (List<Student>)formatter.Deserialize(fs);
                    richTextBoxResults.Clear();
                    foreach (Student student in list)
                    {
                        richTextBoxResults.AppendText(" First Name:  \n" + student.First + " Last Name: \n" +
                        student.Last + " SudentID: \n" + student.ID);
                    }
                }
            }
            catch (SerializationException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
        }
        private void buttonSOAPSerialize_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream(studentListSoapFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                formatter.Serialize(fs, students.ToArray());
                MessageBox.Show("Student list has been serialized to file:  " + studentListSoapFile);
            }
        }
        private void buttonSOAPDeSerialize_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream(studentListSoapFile, FileMode.Open, FileAccess.Read))
            {
                List<Student> list = (List<Student>)formatter.Deserialize(fs);
                richTextBoxResults.Clear();
                foreach (Student student in list)
                {
                    richTextBoxResults.AppendText(" First Name:  \n" + student.First + " Last Name: \n" +
                    student.Last + " SudentID: \n" + student.ID);
                }
            }
        }
        //5.	Using one of the class List<T> method, Write a method to 
        //get all the students, from the students list, whose first 
        //name and last nam (both), contain the character e.

        Func<List<Student>, List<Student>> Q5 = delegate(List<Student> listViewStudents)
            {
                return listViewStudents.Where(x => x.First.ToLower().Contains("e") && x.Last.ToLower().Contains("e")).ToList();
            };
        private void bttnDispStudents_Click(object sender, EventArgs e)
        {
        tempStudent = Q5(students).ToArray(); DisplayStudents(tempStudent, listViewStudents);
        }
        //6.	Using one of the class List<T> methods,Get all the students whose 
        //last name has 8 or more characters

        Func<List<Student>, List<Student>> Q6 = delegate(List<Student>listViewStudents)
            {
            return listViewStudents.Where(x => x.Last.Length >= 8).ToList(); 
            };
        private void bttn8ormorCharsinNames_Click(object sender, EventArgs e)
            {
            tempStudent = Q6(students).ToArray(); DisplayStudents(tempStudent, listViewStudents);
            }
        //7.	Get/display all the students whose last grade is 70 or below

        Func<List<Student>, List<Student>> Q7 = delegate(List<Student>listViewStudent)
            {
            return listViewStudent.FindAll(x => x.Scores[x.Scores.Count - 1] <= 70);
            };
        private void bttnLSLT70_Click(object sender, EventArgs e)
            {
            tempStudent = Q7(students).ToArray(); DisplayStudents(tempStudent, listViewStudents);
            }
        //8.	Using class List<T> methods, Get/Display all the 
        //students whose average grade is 89 or better
        Func<List<Student>, List<Student>> Q8 = delegate(List<Student> listViewStudent)
            {
            return listViewStudent.FindAll(x => x.Scores.Average() >= 89);
            };
        private void bttnAvgSGTE89_Click(object sender, EventArgs e)
            {
            tempStudent = Q8(students).ToArray(); DisplayStudents(tempStudent, listViewStudents);
            }      
    }
 }

