# Watch-Your-Eyes-
Huber Fynn 21.08.2025

**Applikation welche einem fortlaufend, z.B alle 20 Minuten, eine Benachrichtigung anzeigt, dass man seine Augen kurz ausruhen sollte.**

&nbsp;


# Entstehung
Je länger ich am Laptop arbeite und je häufiger ich mehrere Stunden ohne richtige Pause verbringe, desto mehr merke ich, dass sich dies negativ auf meine Leistungsfähigkeit auswirkt. Im Hinterkopf war mir immer bewusst, dass man regelmässig Pausen machen sollte, um die Augen zu entspannen, daran gehalten habe ich mich jedoch nie.

Um dies zu ändern, habe ich ein kleines, simples Programm geschrieben, das einen daran erinnert, den Augen eine Pause zu gönnen.

&nbsp;

# Idee "Eye-Care-App"
Warum eine eigene Applikation und nicht einfach einen Timer stellen?
Diese Frage habe ich mir anfangs auch gestellt. Das Problem beim Timer war jedoch, dass man ihn jedes Mal manuell stoppen und wieder neu starten musste, und das immer und immer wieder.

Um diesen Prozess zu vereinfachen, bzw. zu Optimieren, wollte ich eine Applikation entwickeln. Disese sollte automatisch, z.B alle 20 Minuten, eine Benachrichtgung anzeigen dass man eine Pause einlegen soll. Der Timer soll sich dabei so oft wiederholen bis er vom Benutzer gestoppt wird. 

Für die Umsetzung wollte ich ausserdem ein neues GUI-Framework ausprobieren, Ich habe mich deshalb für WPF (Windows Presentation Foundation) entschieden. Das zusammenspiel aus Design und Funktion ist Simpel, wehsalb es perfekt war für eine kleine Applikation wie diese. Nach rund 30 Minuten hatte ich das Prinzip verstanden und konnte mit der Applikation beginnen.

&nbsp;

# Applikation
Die Fertige Applikation ist nicht umbedingt die schönste, worauf ich aber auch keinen Wert gelegt habe. Es ist ein simples kleines Fenster bei welchem man in einer Drop-down Liste die Zeit auswählen kann. Ich habe mich für die range von 5-60 Minuten entschieden, da man sowieso mindestens jede Stunde eine kleine Pause für die Augen machen sollte.

Unter dem Info Knopf findet man eine Inspiration über die 20-20-20 Regel, damit man einen Ansatz hat wie man die Applikation benutzen könnte. 

&nbsp;

## Bilder

**Benutzeroberfläche**                              
<img src="https://github.com/Fynn8962/Watch-Your-Eyes-/blob/main/images/App.png" alt="App Benutzeroberfläche" width="500" >


**Benutzeroberfläche Zeit auswählen**                                              
<img src="https://github.com/Fynn8962/Watch-Your-Eyes-/blob/main/images/App_select_time.png" alt="App Benutzeroberfläche Zeitauswahl" width="500" >


**Infofenster Text**                                      
<img src="https://github.com/Fynn8962/Watch-Your-Eyes-/blob/main/images/App_info.png" alt="Text Infofenster" width="500" >


**Benachrichtigung**    
<img src="https://github.com/Fynn8962/Watch-Your-Eyes-/blob/main/images/App_message.png" alt="Benachrichtigung unten rechts" width="500" >
<img src="https://github.com/Fynn8962/Watch-Your-Eyes-/blob/main/images/App_message_zoom.png" alt="Benachrichtigung gross" width="500" >       

&nbsp;

## Probleme und Behebungen

**1. Wenn man ohne Zeitauswahl auf den Start-Knopf drückt, stürzt das Programm ab.**
Um dies zu beheben, habe ich am Anfang der Methode, welche für die Funktionen des Timers verantwortlich ist, eine Überprüfung gemacht, ob das Dropdown-Menü (SetCountdown) null ist. Falls ja, wird die Methode abgebrochen.

**2. Der Timer lässt sich nicht stoppen.**
Als ich fertig war, habe ich gemerkt, dass sich der Timer nicht stoppen liess, was ja sehr kontraproduktiv ist. Deshalb habe ich eine Umgebungsvariable namens "isStarted" erstellt. Diese wird, wenn der Timer gestartet wird, auf true gesetzt. Beim erneuten Drücken des Start-Buttons wird überprüft, welchen Wert diese Variable hat. Je nachdem wird dann der Timer gestoppt oder gestartet.

**3. Auswahl der Zeit und einsetzen in der Timer Funktion ohne Fehler.**
Anfangs wollte ich das man die Zeit frei eintippen kann. Da dies jedoch zu unnötigen Problemen wie Eingabefehlern, zu grosse Werte, falscher Syntax etc. kommen kann, habe ich mich für die Dropdown Liste entschieden. 
Anfangs habe ich beim Auswählen der Zeit die entsprechenden Sekunden an die Methode übergeben, um diese dann in Minuten und Sekunden umzurechnen, schnell merkte ich jedoch, dass dies ein besser gehen musste.
Mithilfe von Tutorials habe ich herausgefunden, dass es schon integrierte Methoden gibt, um mit Zeitwerten umzugehen. Mithilfe von KI habe mir die Umsetzung erklären lassen und konnte somit erfolgreich die Funktion des Timers umsetzen. 

&nbsp;

# Fazit
Das ziel des kleinen Projekts war nicht umbedingt etwas neues zu lernen, sondern eine Applikation zu schreiben welche ich einsetzen kann. Trotzdem habe ich neue Dinge gelernt und auch eine neue Art GUI-Framework. Ich habe genau das erreicht was ich erreichen wollte. Eine Applikation welche mir eine bestimmte Tätigkeit erleichtert. 


