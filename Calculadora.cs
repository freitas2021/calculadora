class Calculadora
{
    static void Main()
    {
        int v1;
        int v2;
        bool controler = true;
        string operacao;

        while(controler)
        {

        Console.WriteLine("Digite a operação que deseja realizar: \n + para somar\n * para multiplicar\n / para dividir\n - para diminuir");
        operacao = Console.ReadLine();
        Console.WriteLine("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        switch (operacao)
        {
            case "+" :
                soma(v1, v2);
                break;
            case "*" :
                multiplicacao(v1, v2);
                break;
            case "/" :
                divisao(v1, v2);
                break;
            case "-" :
                subtracao(v1, v2);
                break;
            
            default:
                Console.WriteLine("Opção inválida, por favor escola uma opção válida");
                break;
        }
        Console.WriteLine("Aperte qualquer tecla para continuar ou digite [s] para sair.\n");

        string sair = Console.ReadLine();
        if(sair == "s"){
            controler = false;

        }
        
        }
    }

    static void soma(int n1, int n2)
    {
        int res = n1 + n2; 
        Console.WriteLine($"A soma de {n1} e {n2} é: {res}\n");
    }
    static void multiplicacao(int n1, int n2)
    {
        int res = n1 * n2;
        Console.WriteLine($"A multiplicação de {n1} e {n2} é: {res}");
    }
    static void divisao(int n1, int n2)
    {
        int res = n1 / n2;
        Console.WriteLine($"A divisão de {n1} e {n2} é: {res}");
    }
    static void subtracao(int n1, int n2)
    {
        int res = n1 - n2;
        Console.WriteLine($"A divisão de {n1} e {n2} é: {res}");
    }
}