

using AppHW01_Tree;

internal class Program
{
    static void Main(string[] args)
    {
        var grad_father = new AdultFamilyMember() { Mother = null, Name = "Ded-Bill", Sex = Gender.Female };
        grad_father.Children = new FamilyMember[] { grad_father };
        var father = new AdultFamilyMember() { Father = grad_father, Name = "Ded", Sex = Gender.Male };
        var mother = new AdultFamilyMember() { Mother = null, Father = null, Name = "Mam-Suzi", Sex = Gender.Male };
        var son = new FamilyMember() { Mother = mother, Father = father, Name = "Son1", Sex = Gender.Female };
        var son2 = new FamilyMember() { Mother = mother, Father = father, Name = "Son2", Sex = Gender.Female };
        var son3 = new FamilyMember() { Mother = mother, Father = father, Name = "Son3", Sex = Gender.Male };

        grad_father.Children = new FamilyMember[] { father };

        mother.Children = new FamilyMember[] { son, son2, son3 };
        father.Children = new FamilyMember[] { son };

        grad_father.Print(4);
        Console.ReadLine();

    }
}