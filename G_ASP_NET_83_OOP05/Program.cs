namespace G_ASP_NET_83_OOP05
{
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



            #endregion



        }
    }
}
