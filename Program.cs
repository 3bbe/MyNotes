
Page FirstPage = new Page("Formål: Et Hello, World!-program er en enkel måde at bekræfte, at dit programmeringssprog og udviklingsmiljø er korrekt opsat. Det er normalt det første program, en programmør skriver, når de lærer et nyt sprog eller et nyt miljø.");

Page Second = new Page("Standard output: Målet med et Hello, World!-program er at skrive en simpel besked til standard output (ofte skærmen) for at vise, at programmet fungerer som forventet.");

Page Third = new Page("Sprogafhængighed: Selvom selve beskeden Hello, World! er den samme, vil syntaksen og strukturen for at skrive programmet variere afhængigt af det programmeringssprog, du bruger.");

Page Fourth = new Page("Grundlæggende koncepter: Selvom det er simpelt, inkluderer Hello, World!-programmer ofte vigtige koncepter som deklaration af funktioner (som main() i C++ og Java), brug af nøgleord og biblioteker (som import i Java) og udskrivning til standard output (som print() eller cout <<).");

Page Fifth = new Page("Fejlfinding: Selvom Hello, World!-programmer er simple, kan der stadig opstå fejl. Dette giver dig mulighed for at blive fortrolig med fejlfindingsværktøjer og processen med at finde og løse fejl i koden.");
Page Sixth = new Page("Første skridt: Et Hello, World!-program er normalt det første skridt i at lære et nyt sprog. Når du har fået det til at fungere, kan du begynde at udforske mere avancerede funktioner og bygge mere komplekse programmer.");
Page seven = new Page("Forståelse af kode: Selvom det er kort, kan det at skrive Hello, World! hjælpe dig med at forstå nogle grundlæggende aspekter af et sprog, som syntaksen for udskrivning, formatering og struktur af et program.");
Page eight = new Page("Konsistens: Uanset hvilket sprog du lærer, er Hello, World! en konsistent introduktion og det første skridt i at mestre det pågældende sprog.");

FirstPage.Read();



Chapter Kapitel = new Chapter("variabler");

Kapitel.Pages.Add(FirstPage);
Kapitel.Pages.Add(Second);
Kapitel.Pages.Add(Third);
Kapitel.Pages.Add(Fourth);
Kapitel.Pages.Add(Fifth);
Kapitel.Pages.Add(Sixth);
Kapitel.Pages.Add(seven);
Kapitel.Pages.Add(eight);

Kapitel.Read();


Book mybook = new Book("Hello world");
mybook.Chapters.Add(Kapitel);
mybook.Start();

Console.ReadLine();