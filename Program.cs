double dividendo, divisor, quociente;

Console.WriteLine("*** DIVISÃO ***");

Console.WriteLine("Digite o dividendo:");
dividendo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o divisor:");

divisor = Convert.ToDouble(Console.ReadLine());


bool ehInvalido = divisor == 0;


//*Se* (condicional)
//*Então* (para condicional verdadeira)
//*Senão* (para condicional falsa)

//*If* ... *then* ... *else* ...

if(ehInvalido)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Não é possível dividir por 0");
    Console.ResetColor();
}
else
{
quociente = dividendo / divisor;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"A divisão de {dividendo:N1} por {divisor:N1} é {quociente:N1}.");
Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(" DE NADA !!!!");
Console.ResetColor();
