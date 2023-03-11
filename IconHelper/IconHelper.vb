'****************************************************************************************************************
'IconHelper.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'
'Zur Zeit sind folgende Funktionen enthalten:
'
'- GetIconCount - Die Funktion ermittelt die Anzahl der Icons die in einer Datei enthalten sind.
'- GetIconImage - Die Funktion gibt ein Bitmap zurück welches einer Dateierweiteung, einem Ordner oder einer Datei zugeordnet ist.
'- ExtractIcon - Die Funktion extrahiert ein bestimmtes Icon aus einer Bibliothek oder ausführbarn Datei un d gibt dieses als Bitmap zurück.
'
'Verwendung:
'
'lokale Objektvariable
'Private ReadOnly ih As New SchlumpfSoft.IconHelper
'
'Ordnersymbol abrufen
'Dim MyIcon As New Bitmap = ih.GetIconImage(Folder)
'Dim MyIcon As New Bitmap = ih.GetIconImage(Folder,SchlumpfSoft.IconHelper.IconSizes.x32)
'
'Dateisymbol abrufen
'Dim MyIcon As New Bitmap = ih.GetIconImage(File)
'Dim MyIcon As New Bitmap = ih.GetIconImage(File, SchlumpfSoft.IconHelper.IconSizes.x32)
'
'Erweiterungssymbol abrufen
'Dim MyIcon As New Bitmap = ih.GetIconImage(".ext")
'Dim MyIcon As New Bitmap = ih.GetIconImage(".ext", SchlumpfSoft.IconHelper.IconSizes.x32)
'
'Anzahl der Symbole in einer Datei ermitteln
'Dim IconCount As Integer = ih.GetIconCount(File)
'
'Ein Symbol aus einer Datei extrahieren
'Dim MyIcon As New Bitmap = ih.ExtractIcon(File,Iconindex)
'Dim MyIcon As New Bitmap = ih.ExtractIcon(File,Iconindex,SchlumpfSoft.IconHelper.IconSizes.x32)
'
'Literaturnachweise:
'
'- Eine Klasse zum Laden und Verwenden von mit Dateien verknüpften Symbolen
'  https://www.codeproject.com/Articles/25534/A-class-to-load-And-use-file-associated-icons?msg=2848839#xx2848839xx
'- Extract Images And Icons of .NET Resources
'  https://www.codeproject.com/Articles/285720/Extract-Images-And-Icons-of-NET-Resources
'- Associated Icons Image Control
'  https://www.codeproject.com/Articles/10530/Associated-Icons-Image-Control
'- Extracting Icons from EXE/DLL And Icon Manipulation
'  https://www.codeproject.com/Articles/32617/Extracting-Icons-from-EXE-DLL-And-Icon-Manipulatio
'- SHGetFileInfoA-Funktion (shellapi.h)
'  https://docs.microsoft.com/de-de/windows/win32/api/shellapi/nf-shellapi-shgetfileinfoa?redirectedfrom=MSDN
'- Environment.SpecialFolder Enumeration
'  https://docs.microsoft.com/de-de/dotnet/api/system.environment.specialfolder?view=netframework-4.6
'
'****************************************************************************************************************

Namespace SchlumpfSoft


	''' <summary>
	''' Eine Klasse zum Laden und Verwenden von mit Dateien, Ordnern oder Dateierweiterungen verknüpften Symbolen
	''' </summary>
	Public Class IconHelper


#Region "Fields"

		Private Const ARGUMENTOUTOFRANGEEXCEPTIONMESSAGE = "Das Argument ""{0}"" muß innerhalb des zulässigen Bereiches liegen."
		Private Const FILENOTFOUNDEXCEPTIONMESSAGE = "Die Datei ""{0}"" wurde nicht gefunden."
		Private Const ISNULLOREMPTYEXEPTIONMESSAGE = "Das Argument ""{0}"" darf nicht leer oder NULL sein."

#End Region


#Region "Enums"

		''' <summary>
		''' Aufzählung der möglichen Symbolgrößen
		''' </summary>
		<Flags>
		Public Enum IconSizes
			x32 = 0
			x16 = 1
		End Enum

#End Region


#Region "Public Methods"

		''' <summary>
		''' Gibt das angeforderte Symbol zurück.
		''' </summary>
		''' <param name="File">
		''' Vollständiger Pfad zu der Datei aus der das Symbol extrahiert werden soll.
		''' </param>
		''' <param name="Index">
		''' Nullbasierter Index des Symbols welches extrahiert werden soll.
		''' </param>
		''' <param name="Size">
		''' Größe des Symbols das extrahiert werden soll.
		''' </param>
		''' <exception cref="ArgumentNullException">
		''' Wird ausgelöst wenn der Parameter "<paramref name="File"/>" NULL oder leer ist.
		''' </exception>
		''' <exception cref="IO.FileNotFoundException">
		''' Wird ausgelöst wenn die im Parameter "<paramref name="File"/>" angegebene Datei nicht gefunden wird.
		''' </exception>
		''' <exception cref="ArgumentOutOfRangeException">
		''' Wird ausgelöst wenn der Parameter "<paramref name="Index"/>" ausserhalb des gültigen Bereiches lag.
		''' </exception>
		Public Function ExtractIcon(File As String, Index As Integer, Optional Size As IconSizes = IconSizes.x16) As System.Drawing.Bitmap

			'Fehler erzeugen wenn Parameter leerist
			If String.IsNullOrEmpty(File) Then
				Throw New ArgumentException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(File))) : Exit Function
			End If

			'Fehler erzeugen wenn Datei nicht existiert
			If Not IO.File.Exists(File) Then
				Throw New IO.FileNotFoundException(String.Format(FILENOTFOUNDEXCEPTIONMESSAGE, NameOf(File))) : Exit Function
			End If

			'Fehler erzeugen wenn der Symbolindex < 0 und >= Anzahl der Symbol in der Datei ist
			If Index < 0 Or Index >= GetIconCount(File) Then
				Throw New ArgumentOutOfRangeException(String.Format(ARGUMENTOUTOFRANGEEXCEPTIONMESSAGE, NameOf(Index))) : Exit Function
			End If

			'Handle auf das Symbol erstellen
			Dim hIcon As IntPtr = Nothing
			Select Case Size

				Case IconSizes.x16
					'kleines Symbol extrahieren wenn gefordert
					Dim unused = NativeMethods.ExtractIconExW(File, Index, Nothing, hIcon, 1)

				Case IconSizes.x32
					'großes Symbol extrahieren wenn gefordert
					Dim unused1 = NativeMethods.ExtractIconExW(File, Index, hIcon, Nothing, 1)

			End Select

			'Symbol extrahieren	und Ergebnis zurück
			ExtractIcon = System.Drawing.Icon.FromHandle(hIcon).ToBitmap

			'Handle zerstören
			Dim unused2 = NativeMethods.DestroyIcon(hIcon)

		End Function

		''' <summary>
		''' Gibt die Anzahl der Symbole zurück die in der Datei enthalten sind,
		''' die im Parameter "<paramref name="File"/>" angegeben ist.
		''' </summary>
		''' <param name="File">
		''' Pfad und Datei deren Symbolanzahl ermittelt werden soll.
		''' </param>
		''' <exception cref="io.FileNotFoundException">
		''' Wird ausgelöst wenn die im Parameter "<paramref name="File"/>" angegebene Datei nicht gefunden wird.
		''' </exception>
		''' <exception cref="ArgumentNullException">
		''' Wird ausgelöst wenn der Parameter "<paramref name="File"/>" NULL oder leer ist.
		''' </exception>
		Public Function GetIconCount(File As String) As Integer

			'Fehler erzeugen wenn Parameter leer ist
			If String.IsNullOrEmpty(File) Then
				Throw New ArgumentNullException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(File))) : Exit Function
			End If

			'Fehler erzeugen wenn Datei nicht vorhanden ist
			If Not IO.File.Exists(File) Then
				Throw New IO.FileNotFoundException(String.Format(FILENOTFOUNDEXCEPTIONMESSAGE, NameOf(File))) : Exit Function
			End If

			'Anzahl der in der Datei vorhandenen Symbole ermitteln und Ergebnis zurück
			GetIconCount = CInt(NativeMethods.ExtractIconExW(File, -1, Nothing, Nothing, 0))

		End Function

		''' <summary>
		''' Ruft ein Bitmap-Bild der angegebenen Datei, ein Ordner-Symbol oder das zugeordnete Symbol einer Dateierweiterung ab.
		''' </summary>
		''' <param name="FilePathOrExt">
		''' Der vollständige Pfad zu dem Ordner oder einer Datei in der das Symbol enthalten ist,
		''' oder einfach nur eine Dateierweiterung (.ext) um das registrierte Symbol des Dateityp zu erhalten.
		''' </param>
		''' <param name="Size">
		''' Die Größe des Symbols welches zurückgegeben werden soll (Standard ist 16x16).
		''' </param>
		''' <exception cref="ArgumentNullException">
		''' Wird ausgelöst wenn der Parameter "<paramref name="FilePathOrExt"/>" NULL oder leer ist.
		''' </exception>
		Public Function GetIconImage(FilePathOrExt As String, Optional Size As IconSizes = IconSizes.x16) As System.Drawing.Bitmap

			'Fehler erzeugen wenn Parameter Null oder leer ist
			If String.IsNullOrEmpty(FilePathOrExt) Then

				Throw New ArgumentNullException(String.Format(ISNULLOREMPTYEXEPTIONMESSAGE, NameOf(FilePathOrExt)))
				Exit Function

			End If

			Dim fi As New NativeMethods.SHFILEINFOW
			Dim fa = If(FilePathOrExt.StartsWith(".", True, Globalization.CultureInfo.CurrentCulture),
				Size Or NativeMethods.SHGFI_USEFILEATTRIBUTES, Size)

			If NativeMethods.SHGetFileInfoW(FilePathOrExt, 0, fi, Runtime.InteropServices.Marshal.SizeOf(fi),
											NativeMethods.SHGFI_ICON Or fa) <> 0 Then

				GetIconImage = System.Drawing.Icon.FromHandle(fi.hIcon).ToBitmap
				Dim unused = NativeMethods.DestroyIcon(fi.hIcon)
				Exit Function

			End If

			GetIconImage = Nothing

		End Function

#End Region


#Region "Classes"

		''' <summary>
		''' API-Definitionen
		''' </summary>
		Private Class NativeMethods


#Region "Fields"

			Public Const SHGFI_ICON = &H100
			Public Const SHGFI_USEFILEATTRIBUTES = &H10

#End Region

#Region "Public Methods"

			''' <summary>
			''' Zerstört ein Symbol und gibt jeglichen Speicher frei, den das Symbol belegt hat.
			''' </summary>
			''' <param name="hIcon">
			''' Ein Handle für das Symbol, das zerstört werden soll. Das Symbol darf nicht verwendet werden.
			''' </param>
			''' <remarks>
			''' https://learn.microsoft.com/de-de/windows/win32/api/winuser/nf-winuser-destroyicon
			''' </remarks>
			<Runtime.InteropServices.DllImport("User32.dll", EntryPoint:="DestroyIcon")>
			Public Shared Function DestroyIcon(hIcon As IntPtr) As Integer : End Function

			''' <summary>
			''' Erstellt ein Array von Handles für große oder kleine Symbole, die aus der angegebenen
			''' ausführbaren Datei, DLL oder Symboldatei extrahiert wurden.
			''' </summary>
			''' <param name="lpszFile">
			''' </param>
			''' <param name="nIconIndex">
			''' </param>
			''' <param name="phiconLarge">
			''' </param>
			''' <param name="phiconSmall">
			''' </param>
			''' <param name="nIcons">
			''' </param>
			''' <remarks>
			''' https://docs.microsoft.com/en-us/windows/win32/api/shellapi/nf-shellapi-extracticonexw
			''' </remarks>
			<Runtime.InteropServices.DllImport("shell32.dll", EntryPoint:="ExtractIconExW")>
			Public Shared Function ExtractIconExW(
				<Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)>
				lpszFile As String,
				nIconIndex As Integer,
				ByRef phiconLarge As IntPtr,
				ByRef phiconSmall As IntPtr,
				nIcons As UInteger) As UInteger
			End Function

			''' <summary>
			''' Ruft Informationen zu einem Objekt im Dateisystem ab, z. B. eine Datei, einen Ordner,
			''' ein Verzeichnis oder einen Laufwerkstamm.
			''' </summary>
			''' <param name="pszPath">
			''' Ein Zeiger auf eine nullterminierte Zeichenfolge der maximalen Länge MAX_PATH, die den Pfad und den Dateinamen enthält.
			''' Sowohl absolute als auch relative Pfade sind gültig.
			''' </param>
			''' <param name="dwFileAttributes">
			''' </param>
			''' <param name="psfi">
			''' </param>
			''' <param name="cbFileInfo">
			''' </param>
			''' <param name="uFlags">
			''' </param>
			''' <remarks>
			''' https://docs.microsoft.com/en-us/windows/win32/api/shellapi/nf-shellapi-shgetfileinfow
			''' </remarks>
			<Runtime.InteropServices.DllImport("shell32.dll", EntryPoint:="SHGetFileInfoW")>
			Public Shared Function SHGetFileInfoW(
				<Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.LPWStr)>
				pszPath As String,
				dwFileAttributes As Integer,
				ByRef psfi As SHFILEINFOW,
				cbFileInfo As Integer,
				uFlags As Integer) As Integer
			End Function

#End Region

#Region "Structs"

			''' <summary>
			''' Enthält Informationen zu einem Dateiobjekt.
			''' </summary>
			''' <remarks>
			''' https://learn.microsoft.com/de-de/windows/win32/api/shellapi/nf-shellapi-shgetfileinfow
			''' </remarks>
			<Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
			Public Structure SHFILEINFOW
				Public hIcon As IntPtr
				Public iIcon As Integer
				Public dwAttributes As Integer

				<Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=260)>
				Public szDisplayName As String

				<Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=80)>
				Public szTypeName As String

			End Structure

#End Region

		End Class

#End Region


	End Class


End Namespace