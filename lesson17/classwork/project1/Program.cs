#region *** invariance / covariance / contravariance

// ===== invariance =====

//List<Animal> animals = new List<Animal>();
//List<Dog> dogs = new List<Dog>();

//// animals = dogs;    ERROR
//// dogs = animals;    ERROR

//class Animal { }
//class Dog : Animal { }
//class Cat : Animal { }



//--------------------




// MySqlManeger manager = new MySqlManeger();
// IConnectionManeger<MySqlConnection> manager_0 = manager;

// IConnectionManeger<MySqlConnection> manager_1 = new MySqlManeger();

// // IConnectionManeger<Connection> maneger_2 = new MySqlManeger();                   //ERROR

// // List<IConnectionManeger<Connection>> list = new List<IConnectionManeger<Connection>>()            //ERROR
// // {
// //     new MySqlManeger(),
// // };




// class Connection
// {
//     public string? Config {get; set;}

//     public Connection(string? config) => Config = config;
// }


// class MySqlConnection : Connection
// {
//     public MySqlConnection(string? config) :
//         base(config)
//     {
        
//     }
// }


// interface IConnectionManeger<T>
//     where T : Connection
// {
//     public T CreateConnection(string? congig);
// }

// class MySqlManeger : IConnectionManeger<MySqlConnection>
// {

//     public MySqlConnection CreateConnection(string? config) 
//     {
//         return new MySqlConnection(config);
//     }

// }




// ====== covariance =====


// Animal[] animals = new Dog[10];    //:-|
// // animals[0] = new Cat();            //RUNTIME ERROR


// class Animal { }
// class Dog : Animal { }
// class Cat : Animal { }




//--------


// MySqlManager manager_0 = new MySqlManager();

// IConnectionManager<MySqlConnection> manager_1 = new MySqlManager();

// IConnectionManager<Connection> manager_2 = new MySqlManager();
// Connection conn_1 = manager_2.CreateConnection("config 1 string");
// System.Console.WriteLine(conn_1.Config);

// IConnectionManager<Connection> manager_3 = new SqlServerManager();
// Connection conn_2 = manager_2.CreateConnection("config 1 string");
// System.Console.WriteLine(conn_2.Config);


// List<IConnectionManager<Connection>> list = new List<IConnectionManager<Connection>>()
// {
//     new MySqlManager(),
//     new SqlServerManager(),
// };

// foreach( ICollection<Connection> conn in list)
// {
//     // System.Console.WriteLine(conn.);
// }


// class Connection
// {
//     public string? Config { get; set; }
//     public Connection(string? config) => Config = config;
// }
// class MySqlConnection : Connection
// {
//     public MySqlConnection(string? config) : base(config)
//     { }
// }
// class SqlServerConnection: Connection
// {
//     public SqlServerConnection(string? config) : base(config)
//     { }
// }


// interface IConnectionManager<out T>
//     where T : Connection
// {
//     public T CreateConnection(string? config);
// }

// class MySqlManager : IConnectionManager<MySqlConnection>
// {
//     public MySqlConnection CreateConnection(string? config)
//     {
//         return new MySqlConnection(config);
//     }
// }

// class SqlServerManager : IConnectionManager<SqlServerConnection>
// {
//     public SqlServerConnection CreateConnection(string? config)
//     {
//         return new SqlServerConnection(config);
//     }
// }




/// -------------------


// IUnitBuilder<Unit> a = new ArcherBuilder();
// IUnitBuilder<Unit> c = new WarriorBuilder();
// IUnitBuilder<Unit> b = new AssasinBuilder();




// class Unit
// {
//     public string Title { get; set;}

//     public int Hp { get; set; }

//     public Unit(string title, int hp)
//     {
//         Title = title;
//         Hp = hp;
//     }
// }


// class Archer : Unit
// {
//     public Archer(string title, int hp) :
//          base(title, hp)
//     { }
// }

// class Assasin : Unit
// {
//     public Assasin(string title, int hp) :
//          base(title, hp)
//     { }
// }

// class Warrior : Unit
// {
//     public Warrior(string title, int hp) :
//          base(title, hp)
//     { }
// }


// interface IUnitBuilder<out T>
// {
//     public T Build(string title, int hp);
// }


// class ArcherBuilder : IUnitBuilder<Archer>
// {
    
//     public Archer Build(string title, int hp)
//     {
//         return new Archer(title,hp);
//     }

// }

// class AssasinBuilder : IUnitBuilder<Assasin>
// {
    
//     public Assasin Build(string title, int hp)
//     {
//         return new Assasin(title,hp);
//     }

// }


// class WarriorBuilder : IUnitBuilder<Warrior>
// {
    
//     public Warrior Build(string title, int hp)
//     {
//         return new Warrior(title,hp);
//     }

// }





#endregion
