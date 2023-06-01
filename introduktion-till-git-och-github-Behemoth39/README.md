# Introduktion till Git och GitHub

Du ska nu få göra övning som introducerar hur du kan använda Git, GitHub och GitHub flow i ett utvecklingsprojekt. Eftersom vi inte börjat skriva kod än, så kommer uppgiften bestå i att hantera enkla textfiler. Övningen består av sex steg och fem av dem kommer göras med Git och GitHub. Den sjätte är inlämning i lärplattformen Canvas. Du kommer använda Git lokalt på din dator, men skicka upp, ofta kallat "pusha upp", ändringarna till GitHub och öppna Pull Request samt i uppgift 5 även begära granskning. Om du kör fast, så kan du ställa en fråga i Diskussioner i Canvas eller fråga i Slack-kanalen. **Lycka till!**

## Uppgifter
### 1. Klona repot och skapa en ny branch
Hämta en klon av detta repo till din dator med kommandot `git clone`. Instruktioner om hur du kan klona från GitHub finns [här](https://help.github.com/en/articles/cloning-a-repository). Skapa en ny branch som du döper till `uppgift1-3` och byt till den, till exempel med kommandot 

`git checkout -b uppgift1-3`

Skapa en fil med namn `git_experience.txt` i Visual Studio Code. I denna skriver du ditt svar på frågan "Hur lång är din tidigare erfarenhet av att använda Git och GitHub?". 
Lägg till filen med `git add` och gör en commit med `git commit`. Pusha upp din nya branch till GitHub med 

`git push -u origin uppgift1-3`

### 2. Lägg till två nya filer
Skapa en ny fil `programming_experience.txt`. I filen skriver du ditt svar på frågan "Vilka programmeringsspråk har du använt?" Skapa ännu en fil `goals.txt` där du svarar på frågan "Vilka är dina mål med att gå en utbildning till webbutvecklare?" Lägg till filerna med `git add` och gör en commit med `git commit`.

### 3. Gör en pull request och en merge utan att begära granskning
Skicka återigen upp dina ändringar med `git push`. Öppna en pull request i GitHub och gör en merge till `master` i webbläsaren. Om du inte minns hur man gör en pull request kan du repetera instruktionerna i GitHub Hello World. Du kan ta bort den branch du skapade efteråt. Nu finns ändringarna i `master` på GitHub, men inte i ditt lokala repos `master`. Du ska därför uppdatera din lokala `master` nu. Tillbaka i ditt lokala repo byter du till `master` genom kommandot `git checkout master`. Ta sedan ned senaste versionen av `master` med kommandot `git pull`. Fick du ned de två filerna du skapade i branchen `uppgift1-3` till `master`? Du kan ta bort den andra branchen lokalt med kommandot `git branch -d uppgift1-3`, om du vill.

### 4. Gör en snabb ändring
Uppgift 4 och 5 går ut på att lägga till svaret på frågan "Vad är dina intryck om Git och GitHub?" i filen `git_experience.txt`, men du ska göra det i arbetsflödet GitHub flow som i uppgift 1. Du behöver använda:

- `git branch`och `git checkout` eller `git checkout -b`
- `git add`
- `git commit`
- `git push`

### 5. Öppna en pull request och begär granskning (review)
Öppna en pull request och begär en review från **FThelin**. En guide om hur du begär en review finns [här](https://help.github.com/en/articles/requesting-a-pull-request-review). Du kommer få återkoppling från din granskare.

### 6. Merge och inlämning
När du fått klartecken att göra en merge, så kan du göra det. Slutför uppgiften genom att skriva in ditt användarnamn på GitHub i uppgiftens textruta i Canvas.
