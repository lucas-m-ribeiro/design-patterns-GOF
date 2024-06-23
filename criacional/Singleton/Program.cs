using Singleton.db;

//Aqui cria a instancia da classe MyDatabaseClassic chamando o método GetInstance()
var db1 = MyDatabaseClassic.GetInstance();
var db2 = MyDatabaseClassic.GetInstance();

// O retorno será true, porque após criar a instancia na primeira chamada db1 sera a mesma para segunda
//chamada db2
Console.WriteLine(db1 == db2);