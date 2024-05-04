using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_ManipularPilhasDinamicas
{
    internal class StackInteger
    {
        int cont_impairs = 0, cont_pairs = 0;
        Integer top;
        public StackInteger()
        {
            this.top = null;
        }
        bool IsEmpty()
        {
            return this.top == null;
        }

        public void Push(Integer aux)
        {
            if (aux.getNumber() % 2 == 0)
            {
                cont_pairs++;
            }
            else
            {
                cont_impairs++;
            }
            if (IsEmpty())
            {
                this.top = aux;
            }
            else
            {
                
                aux.setPrevious(top);
                top = aux;
            }
        }
        public void Print()
        {
            Integer aux = this.top;
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty, nothing to print!");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getPrevious();
                } while (aux != null);
            }
        }
        public int CheckSizeStack()
        {
            int cont = 0;
            Integer stack = top;
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                do
                {
                    cont++;
                    stack = stack.getPrevious();

                } while (stack != null);
                return cont;   
            }
        }
        public void CheckBiggest()
        {
            Integer stack = top;
            if (!IsEmpty())
            {
                int biggest = top.getNumber();
                int number;
                do
                {
                    number = stack.getNumber();
                    if (biggest < number)
                    {
                        biggest = number;
                    } 
                    stack = stack.getPrevious();
                }while (stack != null);
                Console.WriteLine("Biggest: " + biggest);
            }
            else
            {
                Console.WriteLine("Don't exist biggest, because stack is empty!");
            }
        }
        public void CheckSmallest()
        {
            Integer stack = top;
            if (!IsEmpty())
            {
                int smallest = top.getNumber();
                int number;
                do
                {
                    number = stack.getNumber();
                    if (smallest > number)
                    {
                        smallest = number;
                    } 
                    stack = stack.getPrevious();
                }while (stack != null);
                Console.WriteLine("Smallest: " + smallest);
            }
            else
            {
                Console.WriteLine("Don't exist smallest, because stack is empty!");
            }
        }
        public void CheckArithmetic()
        {
            double sum = 0,cont = 0, arithmetic;
            
            if(!IsEmpty())
            {
                for (Integer aux = top; aux != null; aux = aux.getPrevious()) 
                {
                    cont++;
                    sum += aux.getNumber();
                }
                arithmetic = sum / cont;
                Console.WriteLine("Arithmetic: " + arithmetic);
            }
            else
            {
                Console.WriteLine("Stack is empty, no one arithmetic to show!");
            }
        }
        public void TransferStack(StackInteger stack_aux)
        { 
            if (IsEmpty())
            {
                stack_aux.top = null;
                Console.WriteLine("Impossible to transfer stack because stack is empty! ");
            }
            else
            { 
                for (Integer aux = top; aux != null; aux = aux.getPrevious())
                { Integer aux2 = new Integer(aux.getNumber());

                    if (stack_aux.IsEmpty())
                    {
                        stack_aux.top = aux2;
                    }
                    else
                    {
                        aux2.setPrevious(stack_aux.top);
                        stack_aux.top = aux2;
                    }
                    
                }
            } stack_aux.Print();

        }
        public void CheckPairsAndImpairs()
        {
            int[] pairs = new int[cont_pairs];
            int[] impairs = new int[cont_impairs];
            int cont_p = 0,cont_i = 0;
            if(!IsEmpty())
            {
                for (Integer aux = top; aux != null; aux = aux.getPrevious())
                {
                    if (aux.getNumber() % 2 == 0)
                    { 
                        pairs[cont_p] = aux.getNumber();
                        cont_p++;
                    }
                    else
                    {
                        impairs[cont_i] = aux.getNumber();
                        cont_i++;
                    }

                }
            }
            Console.WriteLine("Quantity of pairs: " + cont_p);
            Console.Write("Pairs: ");
            for (int i = 0;i < cont_p; i++)
            {
                Console.Write(" " + pairs[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Quantity of impairs: " + cont_i);
            Console.Write("Impairs: ");
            for (int i = 0;i < cont_i; i++)
            {
                Console.Write(" " + impairs[i]);
            }
            Console.WriteLine();
        }
    }

}

