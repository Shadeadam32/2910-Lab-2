using ConsoleTables;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please input a number.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input a second number.");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1 + num2;
Console.Write(num3);

Console.WriteLine("\n Type a number to multiply.");
int multnub1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the number you want to multiply by.");
int multnub2 = Convert.ToInt32(Console.ReadLine());
int prod = multnub1 * multnub2;
Console.Write(multnub1 + " * " + multnub2 + " = " + prod + "\n");


//Console.write(sizeof(decimal);
//decimal.MinValue;
//decimal.MaxValue;
ConsoleTable table = new ConsoleTable("Type", "Byte(s) of memory", "Minimum", "Maximum");
table.AddRow("Sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
table.AddRow("Byte", sizeof(byte), byte.MinValue, byte.MaxValue);
table.AddRow("Short", sizeof(short), short.MinValue, short.MaxValue);
table.AddRow("Ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
table.AddRow("Int", sizeof(int), int.MinValue, int.MaxValue);
table.AddRow("Uint", sizeof(uint), uint.MinValue, uint.MaxValue);
table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
table.AddRow("Ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
table.AddRow("Float", sizeof(float), float.MinValue, float.MaxValue);
table.AddRow("Double", sizeof(double), double.MinValue, double.MaxValue);
table.AddRow("Decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
table.Write();

bool exit = false;
 
do
{
    Console.WriteLine("Enter what operation you wish to perform");
    string res = Console.ReadLine();
    switch (res)
    {
        case "+":
        case "add":
        case "addition":
            Console.WriteLine("Select the first number to add");
            int addnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the second number to add");
            int addnum2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = addnum1 + addnum2;
            Console.WriteLine(addnum1 + " + " + addnum2 + " = " + sum1);
            break;
        case "-":
        case "subtraction":
        case "minus":
            Console.WriteLine("Select the first number to subtract");
            int subnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the second number to subtract");
            int subnum2 = Convert.ToInt32(Console.ReadLine());
            int dif1 = subnum1 - subnum2;
            Console.WriteLine(subnum1 + " - " + subnum2 + " = " + dif1);
            break;
        case "*":
        case "Multiply":
        case "multipy":
            Console.WriteLine("Select the first number to multiply");
            int multnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select the second number to multiply");
            int multnum2 = Convert.ToInt32(Console.ReadLine());
            int prod1 = multnum1 * multnum2;
            Console.WriteLine(multnum1 + " * " + multnum2 + " = " + prod1);
            break;
        case "/":
        case "divide":
        case "division":
            Console.WriteLine("Select the first number to divide");
            double divnum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select the second number to divide");
            double divnum2 = Convert.ToDouble(Console.ReadLine());
            double div1 = divnum1 / divnum2;
            Console.WriteLine(divnum1 + " / " + divnum2 + " = " + div1);
            break;
        case "%":
        case "mod":
        case "Modulus":
            Console.WriteLine("Enter the first number");
            double modnum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double modnum2 = Convert.ToDouble(Console.ReadLine());
            double modres1 = modnum1 % modnum2;
            Console.WriteLine(modnum1 + " is " + modres1 + "% percent of " + modnum2);
            break;
        case "esc":
            return;
            break;
    }
}
while (exit = true);
//Console.WriteLine("Type"