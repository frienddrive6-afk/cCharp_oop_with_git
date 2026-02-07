using homework.src.Account;
using homework.src.User;

Console.WriteLine("--- Создание пользователя ---");
User myUser = new User("Alex");
Console.WriteLine($"Пользователь {myUser.GetName()} создан.");

Console.WriteLine("\n--- Открытие счетов ---");
myUser.AddAccount("pass1"); //ID 1 
myUser.AddAccount("pass2"); //ID 2

myUser.PrintAllAccounts();


Account acc1 = myUser.GetAccountById(1);
Account acc2 = myUser.GetAccountById(2); 

Console.WriteLine("Пополняем Счет #1 на 1000...");
acc1.Deposit(1000);

Console.WriteLine("Снимаем со Счета #1 200 монет...");
acc1.Withdraw(200, "pass1");

Console.WriteLine("Переводим 300 монет со Счета #1 на Счет #2...");
bool transferOk = acc1.Transfer(acc2, 300, "pass1");

if (transferOk) Console.WriteLine("-> Перевод успешен!");
else Console.WriteLine("-> Перевод не удался.");

Console.WriteLine("\n--- Итоговое состояние ---");
myUser.PrintAllAccounts();

Console.WriteLine("\n--- Тест ошибки пароля ---");
acc1.Withdraw(100, "wrong_pass"); 