/* System.Console.InputEncoding = Encoding.GetEncoding(1251);

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
var enc1251 = Encoding.GetEncoding(1251);
 
System.Console.OutputEncoding = System.Text.Encoding.UTF8;
System.Console.InputEncoding = enc1251; 

// https://www.cyberforum.ru/csharp-beginners/thread2388539.html

*/
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");  // РАБОТАЕТ!!!

Console.Write("Введите своё имя: ");
string username = Console.ReadLine();
Console.Write("Привет,  ");
Console.Write(username);