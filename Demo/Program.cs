using Demo.Encapsulation;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 Struct

            /*
             * 
                 * I use struct to build datatype, Like class we use it also to build datatype.
                 * Like if I need to build datatype represent ( product - person - employee ).
                 * Struct is value type - class is reference type , So each of them has different memory allocation mechanism [ struct -> STACK - class -> HEAP ].
                 * Class can be datatype or not -> ( Can be static class ).
                 * Like Console class, it's not datatype, it's just has some methods that help me, Like -> Console.WriteLine() - Console.ReadLine(), Just Container of (fields&Methods) To Help Me.
                 * Struct Can Only Be datatype, Not other thing.

                 * When say that this datatype should be represented as struct?
                 * - When size of data is small, that's explain why ( int(4byte) - char(2byte) - bool(1byte) - ... ) are structs , because they can contain small size of data.
                 * - Use class when size of data inside it is big.

                 * That's because memory allocation mechanism of struct, is that data stored in stack, and stack is fixed size.
                 * So we say that "string" is class(reference Type) because it may hold big size of chars, What if we have long string?
                 * It will be exceed the size of stack causing "STACK Overflow", So string is class to be stored in HEAP that has Dynamic size.

                 * Why use struct, Why not always using class?
                 * - Because data accessibility in struct is more faster
                 * - When you need to access data in struct, You just deal with stack to bring the data.
                 * - When try to access data in class which is reference Type mean that data is in HEAP and address of this data stored in reference in STACK
                 * - So When need to bring data, You need first get the address of this data from STACK and then bring data from heap (Slow).

             */

            #region Initialize The Attributes of object from Point struct with values without using constructor [Not Recommended]. 

            //Point p1;
            //p1.x = 10;
            //p1.y = 20;

            //Console.WriteLine(p1.x);//10
            //Console.WriteLine(p1.y);//20 

            #endregion

            #region Initialize The Attributes of object from Point struct with values using constructor by (new) KeyWord [Recommended]. 

            #region Initialize the object attributes using parameterless constructor.
            //Point p1 = new Point();
            //new with struct is just for choose the constructor that will initialize the struct object attributes with values.
            //In this case new will select the "parameterless constructor".
            //This constructor is responsible for initializing each and every attribute in struct object with the default value of attribute type.

            ///Before modify the default initialization of compiler to object attributes ->
            ///Console.WriteLine(p1.x);//0 [default value of numeric[value] types] like int.
            ///Console.WriteLine(p1.y);//0 [default value of numeric[value] types] like int.

            ///After modify the default initialization of compiler to object attributes ->
            ///Console.WriteLine(p1.x);//5
            ///Console.WriteLine(p1.y);//10 
            #endregion

            #region Initialize the object attributes using parametrized constructor.

            //Point p1 = new Point(50, 100);

            //Console.WriteLine(p1.x);//50
            //Console.WriteLine(p1.y);//100

            #endregion

            #endregion

            #region print (p1) cause Boxing

            //Point p1 = new Point(50, 100);
            //Console.WriteLine(p1);//BOXING, Because this function WriteLine(object? value), is overloaded, and in this case it take variable/reference of type Object.
            ////So, the struct object "p1" in STACK will boxed into object in HEAP, and CLR return address of this object in HEAP to the reference "value" in stack. 

            #endregion

            #region print (p1) Not cause Boxing

            //Point p1 = new Point(50, 100);
            //Console.WriteLine(p1.ToString());//Demo.Point
            ////this overload -> WriteLine(string? value), Take string value and ToString() Return string ( namespace.DataTypeName - Demo.Point ) => No BOXING. 

            #endregion

            #region override the default return of ToString() in struct, to let it return the status of the struct object (x,y) => private.

            //Point p1 = new Point(50, 100);
            //Console.WriteLine(p1.ToString());//(50,100)

            #endregion

            #endregion

            #region Part 02 Struct - Memory Allocation [Check NoteBook For More Details]

            #region Memory Allocation
            /*

                    * struct is value type so struct object stored in STACK.

                    * Point p1;
                    * - p1 is object in STACk of type point(struct).
                    * - CLR will Allocate (n) uninitialized bytes in STACk based on size of data in struct.

                    * p1 = new Point(2,5);
                    * - new used for choose constructor type, in this case choose the parametrized constructor.
                    * - Initialized the data in struct object "p1" with ( x = 2, y = 5)

            */
            #endregion

            #region When Say that this type will be struct or class?

            /*

                 * You Choose the type to be struct or class based on 
                 * 1- object size [size of data inside object].
                 * 2- Memory Allocation Mechanism
                 *      struct -> Stack [Fast Access to data] [Short life time for object because it's associated with life time of function that it declared in it]
                 *      class -> Heap   [slow Access to data] [Long life time for object because it's not associated with any thing, object will be in HEAP until be Unreachable object and Garbage Collector delete it]
                 * 3- Inheritance Support [struct not support inheritance - class support inheritance]     
             
             */

            #endregion

            #endregion

            #region Part 03 What is OOP
            //Done In NoteBook
            //OOP pillars -> [ Encapsulation - Inheritance - Polymorphism - Abstraction ].
            #endregion

            #region Part 04 OOP Pillars - Encapsulation

            //Employee emp = new Employee(1000, "Eslam", 10_000,22);
            //Console.WriteLine(emp);//State(data) of the object "emp"

            //What if i need to change/modify/access the value of "id" of this object "emp" to 1001?
            #region Change/set & get value of attribute through attribute itself by make attribute nonprivate [Violate Encapsulation].
            //Employee emp = new Employee(1000, "Eslam", 10_000, 22);

            //emp.id = 1001;//set the attribute (id) through the attribute itself not through setter method.
            //Console.WriteLine(emp.id);//get the attribute (id) through the attribute itself. not through getter method.

            /*
                 * In This Case (Development Against Fields/Attributes) itself outside the class/struct (violate Encapsulation pillar) I Fall Into 3 Problems : 
                 * 1- Changing on public attribute affect the lines that use this attribute inside & outside class [Error] | it's easy to rename inside class but what about outside class? [hard].
                 *   like if i change name of "id" attribute to "code".
                 *   emp.id = 1000;//Error.

                 * 2- You can't make the public attribute to be readonly attribute, mean that you can get it but you can't set it.
                 *    that's because it's public so you can set&get it.
                 *    if you make it private you can't set&get it.
  
                 * 3- You can't validate the value be setted to the nonprivate attribute when set it using attribute itself.
                 *     emp.id = 100000;//What if you need to say that max num of id is 4000 ? - You can't make this.
             */

            #endregion

            #region Apply Encapsulation (Change/set & get value of attribute) through Setter & Getter Methods [Old Approach].
            //Employee emp = new Employee(1000, "Eslam", 10_000, 22);

            //emp.SetId(1001);
            //Console.WriteLine(emp.getID());//1001

            /*
                 * In This Case Development Against Methods(Setters&Getters) outside the class/struct (Apply Encapsulation pillar) Solve the 3 problems : 
                 * 1- Changing on attribute[name or type] not affect the lines that use this attribute outside project because we deal with this attribute outside class using methods [setters & getters].

                 * 2- You can make the attribute to be readonly attribute, mean that you can get it but you can't set it, by making the setter method "private" or delete the set method.
                 *   private void SetID(int id) => this.id = id;

  
                 * 3- You can validate the value be setted to the attribute through set method.
                 *      public void SetId(int id)
                 *      {
                 *          this.id = (id > 1000 & id < 10000) ? id : 9999;
                 *      }
             */

            //emp.SetId(100000);//id attribute must be by value greater than (1000) and less than (10000) to be setted to "id" of the object, other wise it will be settted to default value (9999).
            //Console.WriteLine(emp.getID());//9999
            #endregion

            #region Apply Encapsulation (Change/set & get value of attribute) through Properties [New Approach] [Recommended because it's like you deal with field direct].
            //Employee emp = new Employee(1000, "Eslam", 10_000,22);

            //emp.Name = "Eslam Ashraf";
            //Console.WriteLine(emp.Name);//Eslam Ashraf

            //Console.Write("Enter New Name: ");
            //emp.Name = Console.ReadLine();// Not Enter AnyThing | Enter Space
            //Console.WriteLine(emp.Name);//No Name

            #endregion

            #region Using "init" with attribute make modidication on attribute with "init" happen using object initializer only. 

            // Employee emp = new Employee() { Name = "Eslam Elsaadany" };
            // Console.WriteLine(emp.Name);//Eslam Elsaa

            //// emp.Name = "Hamada";//init property can only assigned in an object initializer.


            #endregion

            #region Try Automatic Property

            //Employee emp = new Employee();
            //emp.Age = 22;
            //Console.WriteLine(emp.Age);//22 

            #endregion

            #region print State of object emp of Type Employee [struct].

            //Employee emp = new Employee(1000, "Eslam Elsaadany", 2000, 22);

            //Console.WriteLine(emp);// ID = 1000
            //                       // Name = Eslam Elsa
            //                       // Salary = $5,000.00
            //                       // Age = 22

            #endregion

            #endregion;

            #region Part 05 Encapsulation (Continued) - Indexer

            #region Ex01
            //PhoneBook note = new PhoneBook();
            //note.AddPerson(0, "Eslam", 01022010887);
            //note.AddPerson(1, "Ahmed", 0102689810887);
            //note.AddPerson(2, "Hany", 01022786287);
            //note.AddPerson(3, "Khaled", 010220250887);

            //Console.WriteLine(note.getNumber("Eslam"));// (0) -> Because There is no names array initialized and no numbers array initialized
            // you invoked the default constructor only that initialize fields with default value
            // not invoked the parameter constructor that make object of type array of string
            // and object of type array of ulong that of size (size) parameter and initialized with default value
            //note.getNumber() => return 0 if the names[] or numbers[] are not object/refer to null 
            #endregion

            #region Ex02

            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Eslam", 01022010887);
            //note.AddPerson(1, "Ahmed", 0102689810887);
            //note.AddPerson(2, "Hany", 01022786287);
            //note.AddPerson(3, "Khaled", 010220250887);


            //Console.WriteLine(note.getNumber("Eslaam"));//1022010887

            //note.setNumber("Eslam", 01015575349);
            //Console.WriteLine(note.getNumber("Eslam"));//1015575349

            //note.setNumber("Hanya", 01015575349);//Can't Found This Person [number Not Updated].
            //Console.WriteLine(note.getNumber("Hany"));//1022786287 [Number of hany still not changed]

            #endregion

            #region Ex03 => Using Indexer To Set Number and Get Number using name of the person

            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Eslam", 01022010887);
            //note.AddPerson(1, "Ahmed", 0102689810887);
            //note.AddPerson(2, "Hany", 01022786287);
            //note.AddPerson(3, "Khaled", 010220250887);

            //Console.WriteLine(note["Khaled"]);//10220250887

            //note["Khaled"] = 01015575349; 
            //Console.WriteLine(note["Khaled"]);//1015575349 [الصفر على الشمال ملوش معنى]

            #endregion

            #region EX04 print object data.

            //PhoneBook note = new PhoneBook(10);
            //note.AddPerson(0, "Eslam", 01022010887);
            //note.AddPerson(1, "Ahmed", 0102689810887);
            //note.AddPerson(2, "Hany", 01022786287);
            //note.AddPerson(3, "Khaled", 010220250887);

            #region Using Method

            //note.printPersons();   // 1- (Eslam, 1022010887)
            //                       // 2 - (Ahmed, 102689810887)
            //                       // 3 - (Hany, 1022786287)
            //                       // 4 - (Khaled, 1015575349)
            //                       // 5 - (, 0)
            //                       // 6 - (, 0)
            //                       // 7 - (, 0)  That's because i make object names[] & numbers[] of size 10 and initialized with the dafault value and i not filled them.         
            //                       // 8 - (, 0)  [ name[string] (array of string) (referenceType) => null , numbers[ulong] (array of ulong) (valueType) => 0 ]
            //                       // 9 - (, 0)
            //                       // 10 - (, 0)  

            #endregion

            #region Using Indexer that take index and return name&number of person as string

            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //}
            //// 1- (Eslam, 1022010887)
            //// 2 - (Ahmed, 102689810887)
            //// 3 - (Hany, 1022786287)
            //// 4 - (Khaled, 1015575349)
            //// 5 - (, 0)
            //// 6 - (, 0)
            //// 7 - (, 0) 
            //// 8 - (, 0)  
            //// 9 - (, 0)
            //// 10 - (, 0)  

            #endregion

            #region print object data [print only Real data] [not print the content of index with value null in names[string] array && not print the content of index with value 0 in numbers[ulong] array].

            #region Using Property Length

            //for (int i = 0; i < note.Length; i++)
            //{
            //    Console.WriteLine(note[i]);
            //} 

            #endregion

            #region Using Method countPersons()

            //for (int i = 0; i < note.countPersons(); i++)
            //{
            //    Console.WriteLine(note[i]);
            //}

            #endregion

            #endregion

            #endregion

            #endregion


        }
    }
}
