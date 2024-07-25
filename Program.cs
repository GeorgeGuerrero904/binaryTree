using ConsoleApp1.Models;

bool executingStatus = true;
Node masterNode = new Node()
{
    id = 0,
    name = "Master",
    role = "Master"
};

do
{
    MenuController.mainMenu(ref executingStatus, ref masterNode);
    MenuController.finalMenu(ref executingStatus);

} while (executingStatus);

Console.WriteLine("Hello, World!");
