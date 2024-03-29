﻿
using Ex_09.Entities;

// // BusinessAccount businessAccount = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
// // Console.WriteLine(businessAccount.Balance);

// Account acc = new Account(1001,"Alex",0.0);
// BusinessAccount bacc = new BusinessAccount(1002,"Maria",0.0,500.0);

// //UPCASTING - 
// Account acc1 = bacc;
// Account acc2 = new BusinessAccount(1003,"Bob", 0.0,200.0);
// Account acc3 = new SavingAccount(1004,"Anna",0.0,0.01);

// //DOWNCASTING - UTILIZAR SOMENTE QUANDO NECESSARIO, POIS NAO É SEGURO
// BusinessAccount acc4 = (BusinessAccount)acc2;
// acc4.Loan(100.0);

// //BusinessAccount acc5 = (BusinessAccount)acc3; //só da erro em execucao, pois no tem como converter BusinessAccount para SavingAccount
// //COMO TESTAR SE UMA VARIAVEL É INSTANCIA DE BUSINESSACCOUNT
// if(acc3 is BusinessAccount)
// {
//     //BusinessAccount acc5 = (BusinessAccount)acc3;
//     BusinessAccount acc5 = acc3 as BusinessAccount; //sintaxe alternativa
//     acc5.Loan(200.0);
//     Console.WriteLine("Loan!");
// }

// //VERIFICA SE ACC3 É UMA INSTANCIA DE SavingAccount
// if(acc3 is SavingAccount)
// {
//     //SavingAccount acc5 = (SavingAccount)acc3;
//     SavingAccount acc5 = acc3 as SavingAccount;
//     acc5.UpdateBalance();
//     Console.WriteLine("Update!");
// }

Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingAccount(1002,"Anna",500.0,0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);
