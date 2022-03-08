using OOPS__AllSession;
using System;
using static OOPS__AllSession.S11__ClassAndTypes;


namespace OOPS__AllSession
{
    class OopsSessions
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********Welcome To Main Method***********");

            //S11__ClassAndTypes classType = new S11__ClassAndTypes();

            // StudentDetail abstractClass = new StudentDetail();
            //abstractClass.AbstractClassAndDisplayDetail();

            //PartialDetail partialClass = new PartialDetail();
            //partialClass.PartialClass();

            // StaticClass.Static_Method();

            //SealedClass sealedClass = new SealedClass();


            //S12__FourPilllars(Abstraction, Encapsulation, Polymorphism, Inheritance)
            // S12__FourPillars__AbsEncapPolyMorpInhrtnc fourPillars = new S12__FourPillars__AbsEncapPolyMorpInhrtnc();
            //fourPillars.NonAbstraction_Method();

            //Encapsulation polymorPhism = new Encapsulation();
            //polymorPhism.PolyMorphism();

            // Single_Inheritance childClass = new Single_Inheritance();
            //childClass.Single_InheritanceMethod();

            // Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance();
            //multiple_Inheritance.Parent_InheritanceMethod();



            // Console.WriteLine("********Welcome To Main Method***********");

            //S13__MethodAnd Types
            // S13__MethodsAndTypes_MthdOverlod_Override methods = new S13__MethodsAndTypes_MthdOverlod_Override();
            //methods.StringManupulation();
            //methods.Substraction(60,30);

            // MethodOverLoading methodOverload_Override = new MethodOverRiding();
            // methodOverload_Override.Addition_MethodOverride();
            // Console.ReadLine();


            // Console.WriteLine("********Welcome To Main Method***********");

            //S14__Extension Method And Interface

            // S14__ExtensionMethodAndInterface extensionMethod = new S14__ExtensionMethodAndInterface();
            //extensionMethod.StudentDetails();
            //extensionMethod.PrintMonth();
            //int[] number = { };
            //number.PrintArrayNumber();
            //extensionMethod.MultiDimensionalArray();
            //Console.ReadLine();


            // Console.WriteLine("********Welcome To Main Method***********");
            //S15__ConstructorAndTypes
            //S15__ConstructorAndTypes defaultConstructor = new S15__ConstructorAndTypes();
            //S15__ConstructorAndTypes parameteriseConstructor = new S15__ConstructorAndTypes(101, "Abhishek", 33, "Pune");
            //parameteriseConstructor.ParameterizedConstructor();
            //S15__ConstructorAndTypes copyConstructor = new S15__ConstructorAndTypes(parameteriseConstructor);
            //copyConstructor.ParameterizedConstructor();

            //PrivateConstructor privateConstructor = new PrivateConstructor();//Not Able to Create Object
            //PrivateConstructor.GetData();
            //Console.ReadLine();



            // Console.WriteLine("********Welcome To Main Method***********");


            //S16__Delegates
            // S16__Delegates delegates = new S16__Delegates();
            //Single
            // PrintNumbers positiveNumber = new PrintNumbers(S16__Delegates.PrintPositiveNumbers);  //Single
            //  positiveNumber.Invoke();

            //***************EVENTS * *****************
            //EventNotifications eventNotify = new EventNotifications();
            //eventNotify.notificationEvent += User1.User1_Message;
            //eventNotify.notificationEvent += User2.User2_Message;

            //eventNotify.NotificationMethod();

            // Multiple 1
            //string[] city = { "Panvel", "Pune", "Nanded", "Latur", "Beed", "Mumbai", "Dubai" };
            //PrintNames printCity = new PrintNames(delegates.PrintCityName);
            //printCity.Invoke(city);
            // Multiple 1
            //Adding Refrence to Method or Pointing to method
            //string[] names = { "Amit", "Amir", "Sahiba", "Imran", "Kanak", "Prakash", "Sayali", "Akhil", "Shubham" };
            //printCity = S16__Delegates.PrintPersonName;
            //printCity.Invoke(names);

            //Multicast
            //string[] fullName = { "ImranShaikh" };
            //printCity += S16__Delegates.PrintName;
            //printCity.Invoke(fullName);



            //S17__Anonymous Function And LambdaExpression

            // S17__AnonymousMethodAndLambdaExpression anonymousMethod = new S17__AnonymousMethodAndLambdaExpression();
            //S17__AnonymousMethodAndLambdaExpression.AnonymousMethod();



            S18__StringAndStrinBuilder stringBuilder = new S18__StringAndStrinBuilder();
            stringBuilder.StringManupulation();
            stringBuilder.StringBuilder();
            stringBuilder.StringBuilder_Methods();

            Console.ReadLine();
        }
    }
}
