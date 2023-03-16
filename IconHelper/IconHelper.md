## IconHelper

Eine Klasse um Symbole aus Ordnern, Dateierweiterungen oder Dateien zu Extrahieren.

Zur Zeit sind folgende Funktionen enthalten:

- GetIconCount - Die Funktion ermittelt die Anzahl der Icons die in einer Datei enthalten sind.
- GetIconImage - Die Funktion gibt ein Bitmap zurück welches einer Dateierweiteung, einem Ordner oder einer Datei zugeordnet ist.
- ExtractIcon - Die Funktion extrahiert ein bestimmtes Icon aus einer Bibliothek oder ausführbarn Datei un d gibt dieses als Bitmap zurück.

## Verwendung:

Füge die Datei IconHelper.vb zum Projekt hinzu.

```vb
'lokale Objektvariable
Private ReadOnly ih As New SchlumpfSoft.IconHelper

'Ordnersymbol abrufen
Dim MyIcon as new Bitmap = ih.GetIconImage(Folder) 
Dim MyIcon as new Bitmap = ih.GetIconImage(Folder,SchlumpfSoft.IconHelper.IconSizes.x32)

'Dateisymbol abrufen
Dim MyIcon as new Bitmap = ih.GetIconImage(File)
Dim MyIcon as new Bitmap = ih.GetIconImage(File, SchlumpfSoft.IconHelper.IconSizes.x32)

'Erweiterungssymbol abrufen
Dim MyIcon as new Bitmap = ih.GetIconImage(".ext")
Dim MyIcon as new Bitmap = ih.GetIconImage(".ext", SchlumpfSoft.IconHelper.IconSizes.x32)

'Anzahl der Symbole in einer Datei ermitteln
Dim IconCount as Integer = ih.GetIconCount(File)

'Ein Symbol aus einer Datei extrahieren
Dim MyIcon as new Bitmap = ih.ExtractIcon(File,Iconindex)
Dim MyIcon as new Bitmap = ih.ExtractIcon(File,Iconindex,SchlumpfSoft.IconHelper.IconSizes.x32)
```

## Literaturnachweise:

- [Eine Klasse zum Laden und Verwenden von mit Dateien verknüpften Symbolen](https://www.codeproject.com/Articles/25534/A-class-to-load-and-use-file-associated-icons?msg=2848839#xx2848839xx)
- [Extract Images and Icons of .NET Resources](https://www.codeproject.com/Articles/285720/Extract-Images-and-Icons-of-NET-Resources)
- [Associated Icons Image Control](https://www.codeproject.com/Articles/10530/Associated-Icons-Image-Control)
- [Extracting Icons from EXE/DLL and Icon Manipulation](https://www.codeproject.com/Articles/32617/Extracting-Icons-from-EXE-DLL-and-Icon-Manipulatio)
- [SHGetFileInfoA-Funktion (shellapi.h)](https://docs.microsoft.com/de-de/windows/win32/api/shellapi/nf-shellapi-shgetfileinfoa?redirectedfrom=MSDN)
- [Environment.SpecialFolder Enumeration](https://docs.microsoft.com/de-de/dotnet/api/system.environment.specialfolder?view=netframework-4.6)
- [Extract icons from EXE or DLL files](https://www.codeproject.com/Articles/26824/Extract-icons-from-EXE-or-DLL-files)
- [Symbole](https://learn.microsoft.com/en-us/previous-versions/ms997538(v=msdn.10)?redirectedfrom=MSDN)
