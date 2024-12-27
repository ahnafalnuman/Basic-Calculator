namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = 0; 
            double y = 0; 
            bool validInput = false; // Declare validInput

            do
            {
                try
                {
                    Console.Write("Enter the value for x: ");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("Enter the value for y: ");
                    y = double.Parse(Console.ReadLine());

                    validInput = true; // Input is valid  THEN .. exit the loop
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }

            } while (!validInput);



            Calculator calc = new Calculator(x, y);

            Console.WriteLine(calc.GetResults());

            
        }
    }
}
