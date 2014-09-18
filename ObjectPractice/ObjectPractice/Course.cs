using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Course
    {
        //Step 1: Declare Properties
        public string Name { get; set;}
        public int GradePoints { get; set; }
        
        // Declare a custom property for letter grade
        private string _letterGrade;

        public string LetterGrade
        {
            get { return _letterGrade; }
            set 
            {
                _letterGrade = value.ToUpper();
                //letter Grade grade was set, update the grade points
                if (_letterGrade == "A") 
                {
                    this.GradePoints = 4;
                }
                else if (_letterGrade == "B") 
                {
                    this.GradePoints = 3;
                }
                else if (_letterGrade == "C") 
                {
                    this.GradePoints = 2;
                }
                else if (_letterGrade == "D")
                {
                    this.GradePoints = 1;
                }
                else 
                {
                    this.GradePoints = 0;
                }

            
            }
        }

        // Step 2. Constructors
        public Course(string name, string grade) 
        {
        // set the name of the course
            this.Name = name;
            //set the letter grade
            this.LetterGrade = grade;
            //the setter fir letterGrade, will automatically set the GradePoints

        }
        //Step 3. Methods &/|| Function
        
        
        public string GetCourseInfo()
        {
            return this.Name + " " + this.LetterGrade + " " + this.GradePoints;
        }
        
    }
    
}

