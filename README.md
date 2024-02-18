# LA1303

Verschlüsselungsverfahren

# Projekt-Dokumentation

Salma Tanner

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    12.01.2024   | 0.0.1   | Informieren über das Projekt, Ideensuche |
|   19.01.2024    | 0.0.2    |  Planen der Arbeitspackete, Zeitplan erstellen, Projektidee festigen                                                  |
|   26.01.2024    | 0.0.3   |  Beginn mit Implementation des Projektes, abarbeiten der Arbeitspackete |
|   02.02.2024    | 0.0.4   | Abarbeiten der fehlenden Arbeitspackete   |
|   23.02.2024    | 0.0.5  |  Abschliessen der Implementation, Dokumentation und Erstellen des Portfolioeintrags.  |

## 1 Informieren

### 1.1 Ihr Projekt


Ich programmiere ein Verschlüsselungsprogramm , bei welchem man zwischen dem Monoalphabetisches Substitutionsverfahren, Vignere-Verfahren, ROT13 wählen kann, um seine Nachricht zu verschlüsseln. 

Ich habe mich dazu erntschieden die Chiffre-Verschlüsselungsverfahren genauer anzuschauen und habe mich somit für die obigen drei Verfahren entschieden. Ich erhoffe mir das Erlernen von standartmässiger Implementation eines Chiffre-Verschlüsselungsverfahren, zu vertsehen wie das Grundgerüst einer solchen Applikation aussehen kann und allenfalls ein Muster bei den drei Verfahren zu erkennen. Meine Applikation werde ich in Visual Studio in C# implementieren.

### 1.2 User Stories

| US-№ | Typ |  Verbindlichkeit | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|Funktional|Muss|Als ein User möchte ich aus drei Verfahren auswählen können, damit ich die Zusammensetzung des Schlüssels selber bestimmen kann|
|2|Funktional|Muss|ALs ein User möchte ich, dass ich beliebig lange Botschaften in der Applikation ver-/entschlüsseln kann, damit ich diese als Geheimtext verarbeiten kann.|
|3|Funktional|Muss|ALs ein User möchte ich, dass ich den Schlüssel selber bestimmen können, damit ich meine Botschaften ent- und Verschlüsseln kann.|
|4|Funktional|Muss|Als ein User möchte ich meine Ver- und Entschlüsseln können, damit ich Geheime Botschaften versenden/erhalten kann.|
|5|Funktional|Muss|Als ein User möchte ich, dass ich informiert werde, in welchem Format der Schlüssel sein sollte, damit ich die Logik hinter dem Verfahren verstehe.|
|6|Funktional|Muss|Als ein User möchte ich eine Fehlermeldung erhalten, sobald ich etwas Inkorrektes eingegeben habe, damit ich meine Eingabe korrigieren kann.|
|7|Funktional|Muss|Als ein User möchte ich, dass ich am Ende die Möglichkeit habe, nochmals eine Botschaft zu ent-/verschlüsseln.|
|8|Qualität|Kann|Als ein Entwickler möchte ich, dass die Farbe der Konsole wechselt, sobald ein Verfahren ausgewählt wurde.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Konsole startet, Verahren sind aufgezählt |1|Sie haben sich für die Vigenere-Verschlüsselung entschieden!|
| 2.1  |  Konsole läuft, Schlüssel wurde festgelegt| MeineGeheimBotschaft         |    MetnwGphwixBgtdczaqt               |
| 3.1  |  Konsole läuft, Methode wurde ausgewählt            | MeinSchluessel        |   Geben Sie Ihre Botschaft ein                |
| 4.1  |   Konsole läuft, Verfahren wurde gewählt           |  V       |   Geben Sie einen Schlüssel ein (beliebig lange Buchstaben-Abfolge):              |
| 5.1  |    Konsole läuft, Verfahren wurde gewählt  | V        |    Geben Sie einen Schlüssel ein (Alphabet in beliebiger Reihenfolge)               |
| 6.1  |    Konsole läuft, warten auf Benutzereingabe         |  1e       |   Ungültige Eingabe! Geben Sie Ihre Wahl richtig an:                |
| 7.1  |  Konsole läuft, Geheimtext wurde ausgegeben, warten auf Benutzereingabe      |   Ja      |  *Wiederholen der Applikation                 |
| 8.1  |  Konsole läuft, warten auf Benutzereingabe|  3       |  *Schrift wird Rot                 |









## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | 
| ---- | ----- | --------- | ------------ |               
| 1.A  |   26.01.2024     | Salma Tanner          |     Implementation der Benutzereingaben(Auswahl des Verfahrens, der Methode, EIngabe des Schlüssels)       |               
| 2.A  |   26.01.2024    |Salma Tanner           |   Implementation der Vigenere Entschlüsselungsmethode           |               
| 2.B  |   26.01.2024    | Salma Tanner          |   Implementation der Vigenere Verschlüsselungsmethode           |               
| 3.A  |   26.01.2024   | Salma Tanner          |       Implementation der Substitutions Entschlüsselungsmethode                     |               
| 3.B  |    26.01.2024   |Salma Tanner           |   Implementation der Substitutions Verschlüsselungsmethode           |               
| 4.A  |    02.02.2024   |Salma Tanner           |          Implementation der ROT13 Entschlüsselungsmethode                  |               
| 4.B  |    02.02.2024   |Salma Tanner           |    Implementation der ROT13 Verschlüsselungsmethode          |  
| 5.A  |    02.02.2024   |Salma Tanner           |    Implementation der Farbwechsel der Konsole nach Auswahl des Verfahrens          |     
| 6.A  |    02.02.2024   |Salma Tanner           |    Verbinden der einzelnen, zusammenarbeitenden Klassen und Methoden        |    
| 7.A  |    02.02.2024   |Salma Tanner           |    Einbauen von Fehlermeldungen im gesamten Code          |     


## 3 Entscheiden

Ich habe mich dazu entschieden immer das selbe Muster sozusagen bei der Implementation der Methoden zu verwenden. Das ganze geschieht durch Wiederholungen und Verschiebungen der Schlüssel und Botschafts Variablen.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  26.01.2024      |  Salma Tanner         |  60min             |      60min             |
| 2.A  |  26.01.2024      |   Salma Tanner         |   120min            |      150min             |
| 2.B  |  26.01.2024      |  Salma Tanner          |    120min           |     120min              |
| 3.A  | 26.01.2024       |  Salma Tanner          |   120min            |    90min               |
| 3.B  | 26.01.2024       |  Salma Tanner          |    120min           |      90min             |
| 4.A  |  02.02.2024       | Salma Tanner           |     120min          |     90min              |
| 4.B  |  02.02.2024       | Salma Tanner           |     120min          |     90min              |
| 5.A  |  02.02.2024       |  Salma Tanner          |     10min          |     10min              |
| 6.A  |   02.02.2024      |  Salma Tanner          |     30min          |      30min             |
| 7.A  |   02.02.2024      |  Salma Tanner          |     30min          |     30min              |




## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 23.02.2024      |  Funktioniert        | Salma Tanner       |
| 2.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 3.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 4.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 5.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 6.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 7.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |
| 8.1  | 23.02.2024      |   Funktioniert        | Salma Tanner        |

Die Applikation funktioniert so, wie sie sollte. Fehlermeldungen werden ausgegeben, man ist in der Lage aus drei Verfahren zu wählen, aus einer der beiden Methoden (Ver-/Entschlüsseln) und die Konsole wechselt wie gedacht, die Farbe, sobald man eines der Verfahren ausgewählt hat. Der Schlüssel kann man ausser beim ROT13 Verfahren selbst wählen, die Botschaft darf beliebig lang und ebenfalls selbstgewählt sein. Ergebnis ist zufriedenstellend.


