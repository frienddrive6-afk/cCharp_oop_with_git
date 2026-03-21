

#region Intro
// // ExecuteDelegate del = new ExecuteDelegate(f1);
// // del += f1;
// // del += f1;
// // del += f1;

// // // del += f2;                   //ERROR

// // del();
// // System.Console.WriteLine();
// // del?.Invoke();




// ExecuteDelegate del1 = new ExecuteDelegate(f1);
// ExecuteDelegate del2 = new ExecuteDelegate(f1);

// ExecuteDelegate del3 = del1 + del2;
// del3.Invoke();



// void f1()
// {
//     System.Console.WriteLine("f1");
// }

// void f2(int x = 0)
// {
//     System.Console.WriteLine($"x = {0}");
// }


// delegate void ExecuteDelegate();

#endregion





#region Example_1



// User u = new User();
// u.Process("Hello");

// class User
// {
//     private delegate void NotifyHandler(string massege);

//     public void Process(string message)
//     {
//         NotifyHandler handler;

//         handler = Notify;
//         handler += TelegramNotify;
        
        
        
//         handler?.Invoke(message);

//     }

//     private void Notify(string message)
//     {
//         System.Console.WriteLine($"Notify:{message}");
//     }

//     private void TelegramNotify(string message)
//     {
//         Console.ForegroundColor = ConsoleColor.Green;
//         System.Console.WriteLine($"TelegramNotify:{message}");
//         Console.ResetColor();
//     }

// }























// NotifyHandler? notify = SendEmail;
// notify += SendTelegram;
// notify += SendSms;

// notify?.Invoke("Hello");



// void SendEmail(string content) => System.Console.WriteLine($"Email: {content}");

// void SendTelegram(string content) =>System.Console.WriteLine($"Telegram: {content}");

// void SendSms(string content) => System.Console.WriteLine($"Sms: {content}");


// delegate void NotifyHandler(string content);









#endregion



#region Genaric delegates



// string Process(int x, int y) => $"x + y = {x + y}";

// Operation<string, int> op = Process;

// System.Console.WriteLine(op?.Invoke(1, 2));


// delegate T Operation<T,K>(K a, K b);




//--------------------------------------------------

// int? Execute(int a, int b, Operation<int> op)
// {
//     return op?.Invoke(a, b);
// }

// // System.Console.WriteLine(Execute(3,4,Add));
// System.Console.WriteLine(Execute(3,4, new Operation<int>(Mul)));             //Равносильно предыдущеиму примеру



// Operation<int> GetOperation(OpType opType) => opType switch
// {
//     OpType.Add => Add,
//     OpType.Sub => Sub,
//     OpType.Mul => Mul,
//     OpType.Div => Div,
//     _ => throw new NotSupportedException()
// };


// Operation<int> operation = GetOperation(OpType.Mul);
// System.Console.WriteLine(operation?.Invoke(3, 4));


// int Add(int a, int b) => a +b;

// int Sub(int a, int b) => a - b;

// int Mul(int a, int b) => a * b;

// int Div(int a, int b) => a / b;


// enum OpType
// {
//     Add,
//     Sub,
//     Mul,
//     Div
// }

// delegate T Operation<T>(T a, T b);
















#endregion







#region Practice Observer pattern

// //Класическая реализация



// Account acc = new Account(1000);
// acc.AddSubscriber(new Logger("app.log"));
// acc.AddSubscriber(new TelegramNotifier());
// // acc.AddSubscriber(new SmsNotifier());
// acc.AddSubscriber(new EmailNotifier());

// acc.Add(100);
// acc.Withdraw(500);
// acc.Withdraw(1000);



// interface ISubscriber
// {
//     void Update(string message);
// }


// class TelegramNotifier : ISubscriber
// {
//     public void Update(string message)
//     {
//         Console.ForegroundColor = ConsoleColor.Green;
//         System.Console.WriteLine($"Telegram: {message}");
//         Console.ResetColor();
//     }
// }


// class EmailNotifier : ISubscriber
// {
//     public void Update(string message)
//     {
//         Console.ForegroundColor = ConsoleColor.Blue;
//         System.Console.WriteLine($"Email: {message}");
//         Console.ResetColor();
//     }
// }


// class SmsNotifier : ISubscriber
// {
//     public void Update(string message)
//     {
//         Console.ForegroundColor = ConsoleColor.Red;
//         System.Console.WriteLine($"Sms: {message}");
//         Console.ResetColor();
//     }
// }


// class Logger : ISubscriber
// {
//     public string Path { get; set; }
//     public Logger(string path) => Path = path;
//     public void Update(string message)
//     {
//         System.Console.WriteLine($"Logging to {Path}: {message}");
//     }
// }






// class Account
// {
//     private int sum;
//     private List<ISubscriber> subscribers = new List<ISubscriber>();

//     public Account(int sum) => this.sum = sum;

//     public void AddSubscriber(ISubscriber subscriber) => subscribers.Add(subscriber);

//     public void Add(int val)
//     {
//         this.sum += val;

//         Emit($"Added: {val}");
//     }

//     public void Withdraw(int val)
//     {
//         if(sum >= val)
//         {
//             sum -= val;  

//             Emit($"Withdraw: {val} from {sum}");
//         }else
//         {
//             Emit($"Error: {val} > {sum}");
//         }
        
//     }


//     private void Emit(string message)
//     {
//         foreach (ISubscriber subscriber in subscribers)
//         {
//             subscriber.Update(message);
//         }
//     }

// }



















#endregion


















