namespace AnimalHierarchy
{
    using System;

   public abstract class Animals : ISound
    {
        private int age;
      
        private string name;

        public Gender Sex { get; set; }


        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("The Age can not be less tha 0");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value=="")
                {
                    throw new ArgumentException("The name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Animals(string name,int age,Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }


        public abstract string ProduceSound();
    

        public override string ToString()
        {
            return String.Format("I am {0} and I am {1} and I am {2} {3}", Name, Age, Sex, this.ProduceSound());
        }


    }


}
