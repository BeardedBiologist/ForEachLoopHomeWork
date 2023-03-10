/* BREIF:
 * 
 * Ask the user for their first name. Continue asking for first names until 
 * there are no more. Then loop through each name using foreach and tell each 
 * person hello on the Console.
 * 
 */
Console.Write("Please write comma-separated list of first names (no spaces): ");
string? firstNamesStr = Console.ReadLine();

List<string> firstNames = firstNamesStr.Split(',').ToList();

foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}