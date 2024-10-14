using System.Diagnostics.Metrics;

string[] allLines = File.ReadAllLines("games_dataset.csv");

string[] title = new string[allLines.Length];
int[] genreID = new int[allLines.Length];
string[] publisher = new string[allLines.Length];
string[] stadiaReleaseDate = new string[allLines.Length];
string[] originanReleaseDate = new string[allLines.Length];

for (int i = 0; i < allLines.Length - 1; i++) {
    string[] splitted = allLines[i + 1].Split(";");

    title[i] = splitted[0];
    genreID[i] = int.Parse(splitted[1]);
    publisher[i] = splitted[2];
    stadiaReleaseDate[i] = splitted[3];
    originanReleaseDate[i] = splitted[4];
    
}


string allGenreLines = File.ReadAllText("genre.txt");

string[] genreArr = allGenreLines.Split(", ");
for (int i = 0; i < genreArr.Length; i++) {

}



int db = 0;
for(int i = 0; i < allLines.Length; i++) {
    if(publisher[i] == "Ubisoft") {
        db++;
    }
}

Console.WriteLine("ubisoft jatekok: " + db);