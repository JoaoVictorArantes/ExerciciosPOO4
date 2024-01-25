namespace ExerciciosPOO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um funcionário 
             * (nome,salário bruto e imposto). Em seguida,
             * mostrar os dados do funcionário (nome e salário líquido).
             * Em seguida, aumentar o salário do funcionário com base 
             * em uma porcentagem dada (somente o salário bruto é afetado 
             * pela porcentagem) e mostrar novamente os dados do funcionário.
             * Use a classe projetada abaixo.*/

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: ");

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Imposto em reais: ");
            funcionario.Imposto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {funcionario}");

            Console.ReadKey();
        }
    }
}
