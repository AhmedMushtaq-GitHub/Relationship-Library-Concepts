﻿using ABC;

Adress adress =  new Adress();
adress.id = 1;
adress.name = "House 25,Street 7";

City city = new City();
city.id = 2;
city.name = "Faisalabad";
Provence provence = new Provence();
provence.id = 3;
provence.name = "Punjab";
Country country = new Country();
country.id = 4;
country.name = "Pakistan";
Console.Write($"{adress.id}:My Adress is ");
Console.WriteLine(adress.name);
Console.Write($"{city.id}:My City name is ");
Console.WriteLine(city.name);
Console.Write($"{provence.id}:My provence name is ");
Console.WriteLine(provence.name);
Console.Write($"{country.id}:My Counrty name is ");
Console.WriteLine(country.name);
