using AllSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllSesion.AllSession1;

namespace AllSesion
{
    class Program: S4_AccessModifiereAndKeyword
    {
        static void Main(string[] args)
        {
            //session1 A = new session1();
            //A.Addition();

            //AllSession1.session1 B = new AllSession1.session1();
            //B.multiplication();
            //Console.ReadLine();


            //Session 2 Varibale and Data Types

            // S2_VaribaleAndDatatypes varibaleDatatype = new S2_VaribaleAndDatatypes();
            //varibaleDatatype.VariablesAndUses();

            //Session 3 Operator and Conversion

            // S3_OperatorAndTypeConversion operators = new S3_OperatorAndTypeConversion();
            // operators.OperatorAndConversion();
            // Console.ReadLine();




            //S4_AccessModifiereAndKeyword modifier = new S4_AccessModifiereAndKeyword();
            //modifier.PublicArithmaticOperation();
            ////modifier.PrivateAssignmentOperator();    //need to PrivateMethod explain

            //Program prg = new Program();
            ////Child Class
            //ChildClass child = new ChildClass();
            //child.PublicLogicalOperation();
            //prg.ProtectedOperation();
            //Console.ReadLine();


            // S5_StatmntAndSelectionStmntProgram stmnt = new S5_StatmntAndSelectionStmntProgram();
            //stmnt.MarkChecker();
            //stmnt.NestedIf();
            //stmnt.SwitchCase();
            //stmnt.SwitchGroup();
            //Console.ReadLine();

            //Session 6 Exception Handling
            //S6_StatmntAndExecptionHandlingProgram exception = new S6_StatmntAndExecptionHandlingProgram();

            //exception.LoopThroughName();
            //exception.WhileLoopTable();
            //exception.DoWhileLoopTable();
            //exception.ContinueBreakGoTo();
            //exception.TryCatchBlockWithMultipleCatch();
            //exception.UserException();
            //Console.ReadLine();

            //Session 7 Array and Types
            // S7__ArraysAndTypes array = new S7__ArraysAndTypes();
            //array.SingleDimensionalArray();
            // array.MultiDimensionalArray();
            //Console.ReadLine();


            //Session1 8 Call by Value And Call By Refrence
            //S8__CallBy_ValuesAndRefrenceProgram callBy = new S8__CallBy_ValuesAndRefrenceProgram();
            //callBy.PassByValue();
            //callBy.PassByRefrence();
            //callBy.PassByOut();
            //Console.ReadLine();



            //Session 9 Var and Dynamic
           // S9__VarAndDynamicAndProperties varDynamic = new S9__VarAndDynamicAndProperties();
           // varDynamic.VarAndDynamic();
           // varDynamic.PropertiesMethod();
           // varDynamic.StaticProperty();
           // Console.ReadLine();


            //S10__Params
            S10__ParamsAndIndexer param = new S10__ParamsAndIndexer();
            param.Params_Operation(20, 22, 33, 44);
            param.Params_Array("Sumit", "Sujit", "Abhilasha", "Imran", "Amit", "Anmol");
            param.Params_MultipleValue(2, 3, 4, 'A', 'B', "Amit", "Somesh", "Sohel");
            IndexerAccept.Indexer_Accept();
            Console.ReadLine();




        }
    }
}
