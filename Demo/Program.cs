using System.Runtime.InteropServices;

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

        }
    }
}
