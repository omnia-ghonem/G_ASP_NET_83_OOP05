namespace G_ASP_NET_83_OOP05
{

    static class Calculator
    {
        public static int studentCount;     // static
        public static int Add(int x, int y)
        {
            return x + y;
        }
        static Calculator() { }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1 — Object Copying
            #region a) What happens when you assign one object variable to another?
            // copying the reference not the object. The value of the fields inside the object can be changed.
            // if the second object assign a new reference so it will start pointing to another part of heap and the changes will not affect the first one.

            #endregion

            #region b) Does assigning one object to another create a new object?
            // No, both references refer to the same object in heap.
            #endregion

            #region c) Difference between copying an object and copying its reference
            // When copying a reference:
            // no new object is created but both variables/ references refer to the same object in heap.
            // Changes through one variable affect the same object shared by both of them.
            // When copying a value:
            // A new object is created. No shared object, they are completely separated.
            // Changes to one object may affect the other, depending on whether the copy is shallow or deep.
            #endregion

            #endregion

            #region Q2 - Shallow Copy vs Deep Copy

            #region a) What is a Shallow Copy?
            /*
             A shallow copy creates a new object and copies the values of old object's members as they are.
             The value types are not affect by any changes but the reference types as they are copying references to the values
             therefore, the reference to the nested member is copied. So, both objects can refer to the same nested object.
             
             */
            #endregion

            #region b) What is a Deep Copy?
            /*
             A deep copy creates a new objec. Both value and reference type members their values are copied.
             The reference types only the values of nested member not the reference is copied. So the objects are separeted.

             
             */
            #endregion

            #region c) What happens to reference-type members in a Shallow Copy?
            /*
             Their references are copied.So, both objects can refer to the same nested object.
             */
            #endregion

            #region  d) What happens to reference-type members when a Deep Copy is created?
            /*
             The reference-type members themselves are copied into new objects.
             modifying the nested members of the copied object will not modify the original object.
             */
            #endregion

            #region e) Give one situation where Deep Copy would be safer than Shallow Copy. 
            /*
             Deep copy is safer to modify the copied object without modifying the original.
             
             */

            #endregion

            #endregion

            #region Q3 - Static Members 

            #region a) What is a static field, and how is it different from an instance field? 
            /*
             A static field belongs to the class itself, not to individual objects.It shared along whole project
             can have static field inside a normal class.
             */

            #endregion

            #region b) What is a static method? Can a static method directly access instance members? 
            /*
            A static method is a method that belongs to the class rather than to an object.It cannot directly access instance fields because C# doesn't know which  object you mean.
            can have static method inside a normal class.

             
             */

            #endregion

            #region c) What is a static constructor?, and when is it executed?
            /*
             A static constructor is used to initialize static data or perform one-time static initialization.
             Initialize the class/type itself before it is used or any static member is accessed.
             Don't have parameters, as it cannot accept arguments.
             It executes a maximum of one time per application lifecycle.
             Cannot invoke/ call a static constructor manually.
             */

            #endregion

            #region d) What is a static class?
            /*
             A static class is a class that contains static members and cannot be instantiated.
             Use a static class when the class itself doesn't represent an object and you only need its functionality.
             Cannot contain instance members (fields, methods).
             Contain only static members.
             Cannot use public or private access modifiers.
             Cannot create object of static class.
             */

            #endregion


            #endregion

            #endregion


        }
    }
}
