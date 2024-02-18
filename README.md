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

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
