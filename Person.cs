namespace HW1    
{
    public enum Gender {man, woman}
    public class Person 
    {
        public int Age {get; set;}
        public Gender Gender {get; set;}
        public string Name {get; set;}
        public Person Mother {get; set;}
        public Person Father {get; set;}

        public Person[] GetParentsName()
        {
            return new Person[] { Mother, Father};
        }

        public Person(string name, int age, Gender gender)
        {
            Name = name;     
            Age = age;
            Gender = gender;
        }

        public Person(string name, int age, Gender gender, Person father, Person mother)
        {
            Name = name;     
            Age = age;
            Gender = gender;
            Father = father;
            Mother = mother;
        }

        public void Print()
        {
            System.Console.WriteLine($"Ребенок: Name {Name}, Age {Age}");
        }

        public void PrintFamilyInfo()
        {
            if (Father != null)
            {
                System.Console.Write($" |_ Отец: ");
                Father.Print();
                System.Console.WriteLine($"     |_ Дедушка: Name {Father.Father.Name}, Age {Father.Father.Age}");
                System.Console.WriteLine($"     |_ Бабушка: Name {Father.Mother.Name}, Age {Father.Mother.Age}");
            }
            if (Mother != null)
            {
                System.Console.Write($" |_ Мать: ");
                Mother.Print();
                System.Console.WriteLine($"     |_ Дедушка: Name {Mother.Father.Name}, Age {Mother.Father.Age}");
                System.Console.WriteLine($"     |_ Бабушка: Name {Mother.Mother.Name}, Age {Mother.Mother.Age}");
            }
        }

    }

}