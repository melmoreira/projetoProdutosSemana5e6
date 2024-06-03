using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
