namespace ProjetoProdutos.Classes.Menus;

public class MenuBase
{
    public void EsperarInteracao()
    {
        Console.WriteLine("pressione enter para continuar...");
        Console.ReadLine();
    }

    public int pegaOpacaoMenu()
    {
        Console.Write("Opção: ");
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            return -1;
        }
    }
}
