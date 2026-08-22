using G_ASP_NET_83_OOP05;
using System.Text.Json;

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

            #region Q4 - Extension Methods 

            #region a) What is an Extension Method? 

            /*
            An extension method allows you to add a method to an existing type without modifying its original source code or inheriting from it.
            To write fluent/readable syntax.
            Example: cannot modify string because string is part of .NET. Also can't inherit from string to solve this in the normal way.
            */

            #endregion

            #region b) What keyword must be used in the first parameter of an extension method? 

            /*
            this, tells the compiler which type the method is being attached to.

            */

            #endregion

            #region c) Where must an extension method be declared? 

            /*
            in a non-generic static class as static method

            */

            #endregion

            #region d) Can an extension method access private members of the class it extends? 

            /*
            No, it is not a part of the original class/type.

            */


            #endregion

            #endregion

            #region Q5  Partial Classes and Partial Methods 

            #region a) What is a Partial Class? 
            /*
             A partial class allows one class to be split across multiple files.The compiler combines them into one class.
             can split many parts of a class, including: fields, properties, methods, constructors, nested types

             */

            #endregion

            #region b) Why would a developer split one class into multiple files? 
            /*
            To improve organization and maintainability.
            It is mainly about code organization, not  OOP.
            */


            #endregion

            #region c) What is a Partial Method? 

            /*
            A partial method allows one part of a partial class to declare a method and another part to implement it.

            */

            #endregion

            #region d) What happens if a declared partial method has no implementation? 
            /*
            removed by the compiler.

            */

            #endregion

            #endregion

            #endregion


            #region Part 02 - Practical
            // Smart Delivery Management System
            // Continue from your Assignment 02 project. Nothing that already works should be removed — you are extending 
            // behavior, not replacing it.
            Console.WriteLine();
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Smart Delivery Management System");
            DeliveryUtilities.PrintSeparator();

            #region Create Delivery Center
            // =========================================
            // Create Delivery Center
            // =========================================


            //string centerName = Validations.ReadValidString("Enter Delivery Center Name: ");

            DeliveryCenter center = new DeliveryCenter("cairo");
            #endregion

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Creating Shipments...");
            DeliveryUtilities.PrintSeparator();
             


            #region Standard Shipment
            // =========================
            // Standard Shipment
            // =========================

            Console.WriteLine("Standard Shipment");


            string standardTrackingCode = Validations.ValidName_digitallowed("Tracking Code: ");

            string standardDescription = Validations.ValidName_digitallowed("Description: ");

            string standardStatus = Validations.ValidName_digitallowed("Status: ");

            decimal standardWeight = Validations.ReadValidPositiveDecimal("Weight: ");

            decimal standardFee = Validations.ReadValidPositiveDecimal("Delivery Fee: ");

            string standardStreet = Validations.ValidName_digitallowed("Street: ");

            string standardCity = Validations.ReadValidString("City: ");

            int standardBuildingNumber = Validations.ReadValidPositiveInt("Building Number: ");

            DeliveryAddress standardAddress =
                new DeliveryAddress(standardCity, standardStreet, standardBuildingNumber);

            DeliveryAddress standardAddress2 =
            new DeliveryAddress(standardCity, standardStreet, standardBuildingNumber);  

            StandardShipment standardShipment =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardFee,
                    standardAddress, standardStatus);


            StandardShipment standardShipment2 =
                new StandardShipment(
                    standardTrackingCode,
                    standardDescription,
                    standardWeight,
                    standardFee,
                    standardAddress2, standardStatus);

            #endregion


            #region ExpressShipment

            // =========================
            // Express Shipment
            // =========================

            Console.WriteLine("Express Shipment");

            string expressTrackingCode = Validations.ValidName_digitallowed("Tracking Code: ");

            string expressDescription = Validations.ValidName_digitallowed("Description: ");

            string expressStatus = Validations.ValidName_digitallowed("Status: ");

            decimal expressWeight = Validations.ReadValidPositiveDecimal("Weight: ");

            decimal expressFee = Validations.ReadValidPositiveDecimal("Delivery Fee: ");

            decimal extraFee = Validations.ReadValidPositiveDecimal("Extra Fee: ");

            string expressStreet = Validations.ValidName_digitallowed("Street: ");

            string expressCity = Validations.ReadValidString("City: ");

            int expressBuildingNumber = Validations.ReadValidPositiveInt("Building Number: ");

            DeliveryAddress expressAddress =
                new DeliveryAddress(expressCity, expressStreet, expressBuildingNumber);


            ExpressShipment expressShipment =
                        new ExpressShipment(
                            expressTrackingCode,
                            expressDescription,
                            expressWeight,
                            expressFee,
                            expressAddress,
                            extraFee, expressStatus);

            #endregion


            #region International Shipment
            // =========================
            // International Shipment
            // =========================

            Console.WriteLine("International Shipment");


            string internationalTrackingCode = Validations.ValidName_digitallowed("Tracking Code: ");

            string internationalDescription = Validations.ValidName_digitallowed("Description: ");

            string internationalStatus = Validations.ValidName_digitallowed("Status: ");

            decimal internationalWeight = Validations.ReadValidPositiveDecimal("Weight: ");

            decimal internationalFee = Validations.ReadValidPositiveDecimal("Delivery Fee: ");

            decimal customsFee = Validations.ReadValidPositiveDecimal("Customs Fee: ");

            string internationalStreet = Validations.ValidName_digitallowed("Street: ");

            string internationalCity = Validations.ReadValidString("City: ");

            int internationalBuildingNumber = Validations.ReadValidPositiveInt("Building Number: ");

            string destinationCountry = Validations.ReadValidString("Destination Country: ");

            DeliveryAddress internationalAddress =
                new DeliveryAddress(internationalCity, internationalStreet, internationalBuildingNumber);


            InternationalShipment internationalShipment =
                                new InternationalShipment(
                                    internationalTrackingCode,
                                    internationalDescription,
                                    internationalWeight,
                                    internationalFee,
                                    internationalAddress,
                                    destinationCountry,
                                    customsFee, internationalStatus);


            #endregion


            Console.WriteLine();
            #region Add all shipments to the DeliveryCenter
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);
            center.AddShipment(standardShipment2);

            #endregion


            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");




            #region  Object Copying
            
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Object Copying");
            DeliveryUtilities.PrintSeparator();

            // Reference assignment
            Shipment shipment1 = standardShipment;

            Console.WriteLine($"Reference assignment: {ReferenceEquals(shipment1, standardShipment)}");

            // copy
            Shipment shipment2 = standardShipment.CopyShipment();
            Console.WriteLine(
                $"Copied Shipment: {ReferenceEquals(shipment1, standardShipment)}");

            #endregion

            #region Shallow Copy
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Shallow Copy ");
            DeliveryUtilities.PrintSeparator();


            Shipment shallowCopy = standardShipment.ShallowCopy();
            Console.WriteLine($"shallow Copy : {ReferenceEquals(shallowCopy, standardShipment)}");

            Console.WriteLine($"Original Shipment Address : {shallowCopy.Destination.city} ");
            Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.city}");
            Console.WriteLine(" ");

            Console.WriteLine("Changing copied shipment address...");
            shallowCopy.Destination.city = "Giza";

            Console.WriteLine($"Original Shipment Address : {standardShipment.Destination.city} ");
            Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.city}");
            Console.WriteLine(" ");

            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standardShipment.Destination, shallowCopy.Destination)}");

            #endregion

            #region Deep Copy 
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Deep Copy ");
            DeliveryUtilities.PrintSeparator();


            Shipment shipment_deep_copy = standardShipment2.DeepCopy();
            Console.WriteLine($"Original Shipment Address : {standardShipment2.Destination.GetFullAddress()} ");
            Console.WriteLine($"Copied Shipment Address : {shipment_deep_copy.Destination.GetFullAddress()}");
            //Console.WriteLine($"Same Shipment Object : {ReferenceEquals(standardShipment2, shipment_deep_copy)}");
            Console.WriteLine(" ");

            Console.WriteLine("Changing copied shipment address...");
            shipment_deep_copy.Destination.city = "Giza";
            Console.WriteLine($"Original Shipment Address : {standardShipment2.Destination.city} ");
            Console.WriteLine($"Copied Shipment Address : {shipment_deep_copy.Destination.city}");
            Console.WriteLine(" ");
            Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(standardShipment2.Destination, shipment_deep_copy.Destination)}");


            #endregion

            #region Static Method
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion

            #region Extension Methods
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Extension Methods");
            DeliveryUtilities.PrintSeparator();

            Console.WriteLine(standardShipment.GetSummary());
            Console.WriteLine(expressShipment.GetSummary());
            Console.WriteLine(internationalShipment.GetSummary());
            Console.WriteLine(" ");
            #region  IsDelivered
            Console.WriteLine($"{standardShipment.trackingCode} Is Delivered : {standardShipment.IsDelivered()}");
            Console.WriteLine($"{internationalShipment.trackingCode} Is Delivered : {internationalShipment.IsDelivered()}");

            #endregion
            #endregion


            #region Tracking Status 

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Tracking Status");
            DeliveryUtilities.PrintSeparator();
            expressShipment.UpdateTrackingStatus("Delivered");


            #endregion


            #region Static Utilities 
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle("Static Utilities");
            DeliveryUtilities.PrintSeparator();

            DeliveryUtilities.PrintSeparator_single();
            DeliveryUtilities.PrintSystemTitle("Delivery Center ");
            DeliveryUtilities.PrintSeparator_single();

            Console.WriteLine();

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");


            #endregion


            #region Partial Method 

            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Partial Method");

            DeliveryUtilities.PrintSeparator();

            internationalShipment.UpdateTrackingStatus("Delivered");

            #endregion


            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Assignment Completed");
            DeliveryUtilities.PrintSeparator();



            #endregion



        }
    }
}
