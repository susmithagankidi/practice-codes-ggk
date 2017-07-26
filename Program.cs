using System;
using System.Collections;
using System.Linq;


namespace automapper1
{
    class Implementation
    {
        public  void samenames(object source, object destination)
        {

         foreach(var sourceproperty in source.GetType().GetProperties())
             {
                       foreach(var destproperty in destination.GetType().GetProperties())
             {
                        if(destproperty.Name==sourceproperty.Name && destproperty.PropertyType == sourceproperty.PropertyType)
                        {
                            destproperty.SetValue(destination,sourceproperty.GetValue(source)); 
                        }
                         }
                          }
                         foreach(var prop in destination.GetType().GetProperties())
                             {
              Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(destination, null));
                            } 
                        }
                   }
    class A
    {
        public string Firstname {get; set; }
        public string Lastname {get; set; } 
        public string Salary{get;set;}
    }
     class B
     {
         public string Firstname{get;set;}
         public string Lastname{get;set;}
        public string Fname {get; set; }
        public string Lname {get; set; } 
        public string Fullname{get;set;}
        public string Salary {get; set; } 
     }   
     class C

     {
    static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Enter the first name");
            a.Firstname = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            a.Lastname = Console.ReadLine();
            Console.WriteLine("Enter the salary");
            a.Salary = Console.ReadLine();
            B b = new B();
          Console.WriteLine("\n The values in  class A \n ");
         foreach(var prop in a.GetType().GetProperties())
             {
               Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(a, null));
             }
             Console.WriteLine("\n the values in class B \n");
        foreach(var prop in b.GetType().GetProperties())
             {
              Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(b, null));
             }
             //passing the same types to other object type
             Implementation p = new Implementation();
             Console.WriteLine("\n passing objects of type A to objects of type B \n");
             p.samenames(a,b);    
             }
              }
               }


        
    



