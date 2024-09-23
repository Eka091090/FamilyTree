using HW1;

public class Program
{
    public static void Main()
    {
        Person GrandFather1 = new Person("Max", 50, Gender.man);
        Person GrandFather2 = new Person("Ivan", 60, Gender.man);
        Person GrandMother1 = new Person("Anya", 50, Gender.woman);
        Person GrandMother2 = new Person("Maria", 65, Gender.woman);
        Person Mother = new Person("Natalya", 40, Gender.woman, GrandFather2, GrandMother2);
        Person Father = new Person("Artem", 44, Gender.man, GrandFather1, GrandMother1);
        Person Son = new Person("Anatoly", 25, Gender.man, Father, Mother);

        Son.Print();
        Son.PrintFamilyInfo();
    }
}