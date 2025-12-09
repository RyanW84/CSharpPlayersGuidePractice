// Challenge: The Four Sisters and the Duckbear

Console.Write("How many eggs were gathered? ");
int eggCount = Convert.ToInt32(Console.ReadLine());

int sistersShare = eggCount /4;
int duckbearShare = eggCount % 4;

Console.WriteLine("Each sister gets: " + sistersShare + " and The duckbear gets: " + duckbearShare);