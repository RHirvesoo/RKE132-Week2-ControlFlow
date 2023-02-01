// See https://aka.ms/new-console-template for more information


//rakendus küsib sugu m/f
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajad järgmiselt:
//"Welcome, Mr. (kasutaja perekonnanimi) / "Welcom, Ms.(kasutaja perekonnanime)"

Console.WriteLine("Please select your gender (m/f)");

char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist maha andmeid string(sõne) formaadis

Console.WriteLine("Please, enter your last name:");
string userSurname = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userSurname}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userSurname}!");
}
else
{
    Console.WriteLine($"Welcome {userSurname}!");
}

