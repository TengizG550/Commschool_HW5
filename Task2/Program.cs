Dictionary<string, string> contacts = new Dictionary<string, string>();
while (true)
{
    Console.WriteLine("Select operation number");
    Console.WriteLine("1 Insert contact");
    Console.WriteLine("2 Delete contact");
    Console.WriteLine("3 Update contact");
    var selectedOperationNumber = Convert.ToInt32(Console.ReadLine());
    switch (selectedOperationNumber)
    {
        case 1:
            {
                Console.WriteLine("Enter contact name");
                string conactName = Console.ReadLine();
                Console.WriteLine("Enter contact number");
                string contactNumber = Console.ReadLine().Trim();
                contacts.Add(contactNumber, conactName);
                Console.WriteLine("Operation successful");
                break;
            }
        case 2:
            {
                Console.WriteLine("Enter contact number");
                string contactNumber = Console.ReadLine().Trim();
                if (contacts.ContainsKey(contactNumber))
                {   contacts.Remove(contactNumber);
                    Console.WriteLine("Operation successful");
                }
                else Console.WriteLine("No such contact found");
                break;
            }
        case 3:
            {
                Console.WriteLine("Enter contact number");
                string contactNumber = Console.ReadLine().Trim();
                if (contacts.ContainsKey(contactNumber))
                {
                    Console.WriteLine("Contact information found");
                    contacts.Remove(contactNumber);
                    string conactName = "";
                    newInfoPromt:
                    Console.WriteLine("Enter updated contact number");
                    contactNumber = Console.ReadLine().Trim();

                    if (contacts.ContainsKey(contactNumber))
                    {
                        Console.WriteLine("Another contact with such number already exists");
                        goto newInfoPromt;
                    }
                    else
                    {
                        Console.WriteLine("Enter updated contact name");
                        conactName = Console.ReadLine();
                    }
                    contacts.Add(contactNumber, conactName);
                    Console.WriteLine("Operation successful");
                }

                else Console.WriteLine("No such contact found");

                break;

            }
        default:
            {
                Console.WriteLine("Enter valid operation number");
                break;

            }
    }
}
