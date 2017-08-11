public class Validator
    {
        public static void Main(string[] args)
        {
            // Sample data arrays
            string[] phoneNumbers = {"032-342-4323" , 
                                     "0323424323" , 
                                     "032 342 4323" ,
                                     "032.342.4323" , 
                                     "342 4323" ,
                                     "032-3232-TEST",
                                     "XXX-XXX-XXXX"};
                                     
            // Loops to go through array and validate data
            for(int i = 0; i < phoneNumbers.Length;i++)
            {
                   PhoneValidator(phoneNumbers[i]);
            }            
            Console.WriteLine("\n");            
        }
        public static void PhoneValidator(string number)
        {
            string PATTERN = @"^([0-9]){3}" + // Minimum of 3 digits
                             @"[-\s.]?" + // Optional hypen/whitespace/period
                             @"([0-9]){3}" + // Minimum of 3 digits
                             @"[-\s.]?" + // Optional hypen/whitespace/period
                             @"([0-9]){4}$"; // Minimum of 4 digits
            
            // New Regex object constructed with the pattern
            Regex regex = new Regex(PATTERN);
            
            // Print whether it is valid or not using ternary statement
            Console.WriteLine(regex.IsMatch(number) ? number + " is valid." : number + " is NOT valid.");
        }        
    }
