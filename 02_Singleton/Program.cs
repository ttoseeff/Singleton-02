// See https://aka.ms/new-console-template for more information
using _02_Singleton;

Console.WriteLine("Sigleton Program");

Singleton FromStudent = Singleton.Instance;
FromStudent.PrintDetails("From Student");

Singleton FromEmployee = Singleton.Instance;
FromEmployee.PrintDetails("From Employee");

/*
 * why we should use sealed keyword in the singleton class
 * 
 *Singleton.SingletonDerived singletonDerived = new Singleton.SingletonDerived();
 *singletonDerived.PrintDetails("Derived Class");
 *
 */

