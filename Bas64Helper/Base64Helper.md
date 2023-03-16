## Base64Helper

Eine Klasse zum Codieren und Decodieren von Text, Bildern und beliebigen Dateien in Base64-Code und zurück.

z.Zt. sind folgende Funktionen enthalten:

- StringToBase64 - Text in Base64 konvertieren.
- StringFromBase64 - Base64 - Code in Text konvertieren.
- ImageToBase64 - Bild in Base64 konvertieren.
- ImageToHtml - Bild in einen HTML-Tag (<img ... />) konvertieren (zum einfügen in ein HTML-Dokument).
- ImageFromBase64 - Base64 - Code in Bild konvertieren.
- FileToBase64 - Beliebige Datei in Base64 konvertieren.
- FileFromBase64 - Base64 - Code in beliebige Datei konvertieren.

## Verwendung:

Füge die Datei Base64Helper.vb zum Projekt hinzu.

```vb
'Objektvariable erstellen
private b64 as New SchlumpfSoft.Base64Helper

'Text codieren
Dim B64Code as String = b64.StringToBase64(InputText as String)

'Text decodieren
Dim OutputText as String = b64.StringFromBase64(Base64Code as String)

'Bild als Base64code codieren
Dim B64Code as String = b64.ImageToBase64(InputImage as Image)

'Bild als HTMLcode codieren
Dim HtmlCode as String = b64.ImageToHtml(InputImage as Image)

'Bild Decodieren
Dim OutputImage as Image = b64.ImageFromBase64(Base64Code as String)

'beliebige Datei codieren
Dim B64Code as String = b64.FileToBase64(InputFileName as String)

'beliebige Datei decodieren
b64.FileFromBase64(Base64Code as String,OutputFileName as String)
```

## Literaturnachweise:
- [Base64-Codierung](https://www.vbarchiv.net/tipps/tipp_1491-base64-codierung-vbnet.html)
- [Convert.ToBase64String Methode](https://learn.microsoft.com/de-de/dotnet/api/system.convert.tobase64string?view=netframework-3.5)
- [Convert.FromBase64String(String) Methode](https://learn.microsoft.com/de-de/dotnet/api/system.convert.frombase64string?view=netframework-3.5)
