using oop_reviewer;

internal class Program
{
    private static void Main(string[] args)
    {
        // Instance of Person Class
        Person person1 = new Person("Juan Dela Cruz", 20, true);
        person1.printDetails();

        // Instance of College Class
        College cgc = new College("CITI Global College");
        cgc.address = "Cabuyao, Laguna";
        cgc.courses = new string[] { "BSCS", "BSPsych", "BSEntrep", "BSAT"};
        Console.WriteLine(cgc.getLocation("Binan", "Cabuyao"));

        // Instance of SeniorHigh Class
        SeniorHigh binhs = new SeniorHigh();
        binhs.name = "Binan Integrated National High School";
        binhs.address = "Binan, Laguna";
        binhs.strands = new string[] { "STEM", "HUMSS", "GAS", "ABM" };
        Console.WriteLine(binhs.getLocation());
    }
}