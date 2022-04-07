using System;


namespace teste2
{
    public class Program
    {
        /**
        
        Dado um array int[] array1 e array2, criar uma função para verificar se todos os
        números de array1 estão presentes no array2 (ou vice versa),
        da forma mais perfomática possível.
        
        Regras:
        - não pode usar nenhuma função LINQ ou algo existente
        - não crie nenhum método, use tudo dentro deste método
        - Passar todos os testes (todos resultados devem ser positivos)
        
        */
        public static bool IsSubSet(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            bool res = false;

            for (int ctr = 0; ctr <= array1.GetUpperBound(0); ctr++)
            {
                foreach (var comparison in array2)
                    Console.WriteLine("{0} = {1} ({2}): {3}", array1[ctr],
                                      array1[ctr], comparison,
                                      String.Equals(array1[ctr], comparison));
                Console.WriteLine();
            }

            if (array1.Length <= array2.Length) 
            {
                foreach (int item in array1)
                {
                    foreach(int item2 in array2) { 
                        if(item == item2) { res = true; break; } else { res = false; }
                    }
                }
                return res;
            }
            if (array1.Length >= array2.Length)
            {
                foreach (int item in array2)
                {
                    foreach (int item2 in array1)
                    {
                        if (item == item2) { res = true; break; } else { res = false; }
                    }
                }
                return res;
            }

            return false;
        }

        public static void Main()
        {
            Console.WriteLine("Teste 1");
            int[] teste1_array1 = new int[] { 1, 2, 3 };
            int[] teste1_array2 = new int[] { 1, 2, 3, 4, 5 };
            bool teste1_result = IsSubSet(teste1_array1, teste1_array2);
            Console.WriteLine("Resultado teste 1: {0}", teste1_result ? "OK" : "NÃO OK");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Teste 2");
            int[] teste2_array1 = new int[] { 3, 1, 2 };
            int[] teste2_array2 = new int[] { 5, 2, 4, 3, 1, 9, 8, 13 };
            bool teste2_result = IsSubSet(teste2_array1, teste2_array2);
            Console.WriteLine("Resultado teste 2: {0}", teste2_result ? "OK" : "NÃO OK");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Teste 3");
            int[] teste3_array1 = new int[] { 3, 9, 2 };
            int[] teste3_array2 = new int[] { 5, 2, 4, 3, 1, 7, 8, 13 };
            bool teste3_result = IsSubSet(teste3_array1, teste3_array2);
            Console.WriteLine("Resultado teste 3: {0}", teste3_result ? "NÃO OK" : "OK");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Teste 4");
            int[] teste4_array1 = new int[] { 5, 2, 4, 3, 1, 9, 8, 13 };
            int[] teste4_array2 = new int[] { 3, 1, 2 };
            bool teste4_result = IsSubSet(teste4_array1, teste4_array2);
            Console.WriteLine("Resultado teste 4: {0}", teste4_result ? "OK" : "NÃO OK");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
