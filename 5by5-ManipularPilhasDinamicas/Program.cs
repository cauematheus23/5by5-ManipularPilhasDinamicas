using _5by5_ManipularPilhasDinamicas;
using System.Drawing;
int opc,opc_stack;
void Menu()
{
    Console.Clear();
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("[1] - INSERT IN STACK"); //Ready
    Console.WriteLine("[2] - PRINT STACK"); //Ready
    Console.WriteLine("[3] - CHECK EQUAL SIZE "); //Ready
    Console.WriteLine("[4] - LARGEST SMALLEST AND ARITHMETIC AVERAGE ");
    Console.WriteLine("[5] - TRANSFER TO AUXILIAR STACK ");
    Console.WriteLine("[6] - RETURN QUANTITY AND ELEMENTS IMPARES ");
    Console.WriteLine("[7] - EXIT PROGRAM ");
}

StackInteger stack1 = new();
StackInteger stack2 = new();

do
{
    Menu();
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            do
            {
                Console.WriteLine("Chose which stack you want to manipulate 1 or 2: ");
                opc_stack = int.Parse(Console.ReadLine());
                if (opc != 1 && opc != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_stack)
                    {
                        case 1:
                            Console.WriteLine("Write the number to insert into stack: ");
                            stack1.Push(new(int.Parse(Console.ReadLine())));
                            break;
                        case 2:
                            Console.WriteLine("Write the number to insert into stack: ");
                            stack2.Push(new(int.Parse(Console.ReadLine())));
                            break;
                    }
                }
            } while(opc_stack != 1 &&  opc_stack != 2);
            break;
        case 2:
            do
            {
                Console.WriteLine("Chose which stack you want print 1 or 2: ");
                opc_stack = int.Parse(Console.ReadLine());
                if (opc != 1 && opc != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_stack)
                    {
                        case 1:
                            Console.WriteLine("===== STACK 1 ===== ");
                            stack1.Print();
                            break;
                        case 2:
                            Console.WriteLine("===== STACK 2 ===== ");
                            stack2.Print();
                            break;
                    }
                }
            } while (opc_stack != 1 && opc_stack != 2);
            break;
        case 3:
            int sizestack_1,sizestack_2;
            Console.WriteLine("Size stack 1: " + stack1.CheckSizeStack());
            Console.WriteLine("Size stack 2: " + stack2.CheckSizeStack());
            sizestack_1 = stack1.CheckSizeStack();
            sizestack_2 = stack2.CheckSizeStack();
            if (sizestack_1 == sizestack_2)
            {
                Console.WriteLine("The stacks are the same size");
            } else if(sizestack_1 > sizestack_2)
            {
                Console.WriteLine("Stack 1 is bigger");
            }
            else
            {
                Console.WriteLine("Stack 2 is bigger");
            }
            break;
        case 4:
            do
            {
                Console.WriteLine("Chose which stack you want check biggest,smallest and arithmetic 1 or 2: ");
                opc_stack = int.Parse(Console.ReadLine());
                if (opc_stack != 1 && opc_stack != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_stack)
                    {
                        case 1:
                            Console.WriteLine("===== STACK 1 ===== ");
                            stack1.CheckBiggest();
                            stack1.CheckSmallest();
                            stack1.CheckArithmetic();
                            break;
                        case 2:
                            Console.WriteLine("===== STACK 2 ===== ");
                            stack2.CheckBiggest();
                            stack2.CheckSmallest();
                            stack2.CheckArithmetic();
                            break;
                    }
                }
            } while (opc_stack != 1 && opc_stack != 2);
            break;
        case 5:
            do
            {
                Console.WriteLine("Chose which stack you want copy to auxiliar: ");
                opc_stack = int.Parse(Console.ReadLine());
                if (opc_stack != 1 && opc_stack != 2)
                {
                    Console.WriteLine("Write a valid value: ");
                }
                else
                {
                    StackInteger stack_aux = new();
                    switch (opc_stack) { 
                    
                        case 1:
                            Console.WriteLine("===== STACK 1 ===== ");
                            stack1.Print();
                            Console.WriteLine("===== STACK AUXILIAR =====");
                            stack1.TransferStack(stack_aux);
                            break;
                        case 2:
                            Console.WriteLine("===== STACK 2 ===== ");
                            stack2.Print();
                            Console.WriteLine("===== STACK AUXILIAR =====");
                            stack2.TransferStack(stack_aux);
                            break;
                    }
                }
            } while (opc_stack != 1 && opc_stack != 2);
            
            break;
        case 6:
            do
            {
                Console.WriteLine("Chose which stack you want check impairs and pairs: ");
                opc_stack = int.Parse(Console.ReadLine());
                if (opc_stack != 1 && opc_stack != 2)
                {
                    Console.WriteLine("Write a valid value");
                }
                else
                {
                    switch (opc_stack)
                    {
                        case 1:
                            stack1.CheckPairsAndImpairs();
                            break;
                        case 2:
                            stack2.CheckPairsAndImpairs();
                            break;
                    }
                }
            } while (opc_stack != 1 && opc_stack != 2);
            break;
        default:
            break;
            
    }
    Console.WriteLine("Press ENTER to continue");
    Console.ReadKey();

} while (opc != 7);
