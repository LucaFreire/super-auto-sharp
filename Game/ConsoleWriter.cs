namespace SAS;
using static Console;

public static class ConsoleWriter
{
    public static void Init()
    {
        WriteLine("""
            ()                  __           ()               
            /\                 /  )  _/_     /\   /     
           /  ) . ._  _ __    /--/. ./ __   /  ) /_ __. __ _  
          /__/_(_//_)<// (_  /  ((_/<_(_)  /__/_/ /(_/|/ (/_)_
                 /                                       /     
                '                                       '         
        """);

        WriteLine("Bem-vindo ao Super Auto Sharp!\n");
    }

    public static void showMenu()
    {
        WriteLine("""
            1. Jogar
            2. Sair
        """);
    }
}