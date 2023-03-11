## WmiHelper

Mit dieser Klasse ist es möglich verschiedene Informationen über das System zu erlangen.

Zur Zeit sind folgende Funktionen enthalten:

- GetMaiboradInfo - Informationen über das Mainboard
  (Hersteller,Bezeichnung,Seriennummer,Version)
- GetPhysikalDriveInfo - Informationen über die physikalischen Laufwerke
  (Anzahl der Laufwerke,Modell,Interfacetyp,Anzahl der Partitionen,
  gesamter Speicherplatz,Seriennummer)
- GetLogigDriveInfo - Informationen über die logischen Laufwerke
  (Anzahl der logischen Laufwerke,Laufwerksbezeichnung,Kompression,Laufwerksart,
  Art des Dateisystems,freier Speicherplatz,Netzwerkpfad,Speicheplatz,
  Volumenbezeichnung,Seriennummer)
- GetSystemInfo - Informationen über das Betriebssystem
  (Name des betriebssystems,Version,Buildnummer,Seriennummer,Architektur)

## Verwendung

Füge die Datei WmiHelper.vb zum Projekt hinzu.

```vb
'Objektvariable
Dim wmh as New SchlumpfSoft.WmiHelper

'Information erlangen
Dim Info as String = wmh.GetFunktionsname(SchlumpfSoft.WmiHelper.InfoTyp) 

'Hinweis

'Bei den Funktionen über Laufwerke kann noch der Index des Laufwerkes angegeben werden.
'(Ohne Index werden die Informationen zum 1. Laufwerk ermittelt)
```

## Literaturnachweise

- [Seriennummer eines Datenträgers auslesen (Microsoft Community)](https://social.msdn.microsoft.com/Forums/de-DE/488b2910-03bd-4d4c-a532-09d8f74de207/seriennummer-eines-datentrgers-auslesen?forum=vbasicexpresseditionde#488b2910-03bd-4d4c-a532-09d8f74de207)
- [Seriennummer eines Laufwerkes auslesen mit WMI (DotNet Snippetds.de)](https://dotnet-snippets.de/snippet/seriennummer-eines-laufwerkes-auslesen-mit-wmi/805)
