
#region type casting

// ================ upcasting (восходящее преобразование / "упаковка обьекта" / обобщение)

// Warrior warrior = new Warrior(100, 300);

// Unit unit = warrior;

// object obj = warrior;





// ================ downcasting (нисходящие преобразование / "распаковка обьекта")


// Archer archer = new Archer(100, 30);

// Unit unit = archer;

// Archer archer2 = (Archer)unit;
// System.Console.WriteLine(archer2.ArrCount);


// Unit u = new Archer(120, 30);
// Archer a = (Archer)u;



// object obj = new Warrior(100, 200);
// Unit u = (Unit)obj;
// Warrior w = (Warrior)obj;

// // Archer a = (Archer)obj;                       //ERROR


// Unit a = new Unit(100);





// ================ is / as

// Unit u = new Archer(130, 20);

// Archer? a = u as Archer;
// a?.Render();

// if(u is Archer)
// {
//     u.Render();
// }

// if(u is Archer archer)
// {
//     archer.ArrCount = 50;
// }






// class Unit
// {
//     public int Hp {get; set; }
//     public Unit(int hp)
//     {
//         Hp = hp;
//     }

//     public void Render() => System.Console.WriteLine($"{Hp}");


// }


// class Archer : Unit
// {

//     public int ArrCount {get; set; }
//     public Archer(int hp, int arrCount) : 
//         base(hp)
//     {
//         ArrCount = arrCount;
//     }


// }



// class Warrior : Unit
// {

//     public int Force {get; set; }
//     public Warrior(int hp, int force) : 
//         base(hp)
//     {
//         Force = force;
//     }


// }





#endregion




#region vitual and override


// Student a = new Student(101);
// a.Show();
// User b = a;
// b.Show();



// Student a = new Student(101, 23);
// a.Age = 34;
// a.Show();
// a.Age = 15;
// a.Show();




using System.Runtime.InteropServices.Marshalling;

User b = new Student(101, 23);
b.Age = 34;
b.Show();
b.Age = 15;
b.Show();





class User
{
    public int Id {get; set; }
    public virtual int Age {get; set; }

    public User(int id, int age)
    {
        Id = id;
        Age = age;
    }

    public virtual void Show()
    {   System.Console.WriteLine("User");
        System.Console.WriteLine($"id: {Id} age: {Age}");
    }


    // public static VirtualMethodTableInfo void Method() {}      //Не имеет смысла

}

class Student : User
{
    // public override int Age {get; set; }                  //дублируется поле Age

    public override int Age
    { 
        get => base.Age; 
        set
        {
            base.Age = value >= 18 ? value : 18;
        }
    }
    
    public Student(int id, int age) :
        base(id,age)
    {
        
    }

    public override sealed void Show()
    {
        System.Console.WriteLine("Student");
        System.Console.WriteLine($"id: {Id} age: {Age}");
    }

}










#endregion









