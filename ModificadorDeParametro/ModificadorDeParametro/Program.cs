namespace Modificador_Params;
public class Application {

    static void Main(string[] args) {
        // Metodo 1, tenho que limitar conforme os parametro do método
        Sum(3, 4, 5);

        Console.WriteLine("---------------\n");
        
        // Metodo 2, tenho que adicionar um vetor (Array)
        int[] vet = {2,5,6,7,8,8,5,3,2,4,6,7 };
        Sum(vet);
        
        Console.WriteLine("---------------\n");
        
        // Metodo 3,  com o modificador ( Params ), apenas add os numeros sem limites
        // desde que não seja superior o tamanho máximo do inteiro  
        Sum2(5, 6, 97, 3,46, 59, 7, 4,6,7,8,9,664,4,5741,6874,2,3,5,6,76443434,346432132,58744);
    }

    // Metodo 1 com parametros comum
    public static void Sum(int n1, int n2, int n3) {
        double sum = n1 + n2 + n2;
        Console.WriteLine(" Sum 1 :" + sum);


    }      
    // Metodo 2 com  Arrays
    public static void Sum(int[] numbers) {
        int sun = 0;
        for (int i = 0; i < numbers.Length; i++) {
            sun += numbers[i];
        }

        Console.WriteLine("Sum 2 : " + sun);
    }

    // Metodo 3 com o modificador ( Params )
    public static void Sum2(params int[] numbers) {
        double sum = 0.0;
        for (int i = 0; i < numbers.Length; i++) {
            sum += numbers[i];
        }
        Console.WriteLine("Sum 2 : " + sum);
    }
}
