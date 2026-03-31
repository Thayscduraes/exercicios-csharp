// Exercício: Calcular quantos salários mínimos uma pessoa recebe
// Entrada: salário do funcionário e salário mínimo
// Saída: quantidade de salários mínimos

class Program
{
    static void Main()
    {
        double salario;
        double salariominimo;
        double resultado;
        Console.WriteLine("Digite seu salario");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salario minimo");
        salariominimo = double.Parse(Console.ReadLine());
        resultado = salario/ salariominimo;
        Console.WriteLine(resultado);
        }
}