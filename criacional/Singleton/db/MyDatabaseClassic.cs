using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace Singleton.db
{
    public class MyDatabaseClassic
    {
        private static MyDatabaseClassic? instance;
       
        //Construtor deve ser privado para não criar nova instancia da classe
        private MyDatabaseClassic(){}

        //Este metodo gerencia a propria criação da classe
        public static MyDatabaseClassic GetInstance()
        {
            if(instance is null)
                instance = new MyDatabaseClassic();
            
            return instance;
        }
    }
}